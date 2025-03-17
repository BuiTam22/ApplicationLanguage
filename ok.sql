create table AppUser(
  id varchar(10) primary key,
  userName varchar(10) unique not null,
  passWord varchar(50) not null,
  name nvarchar2(50),
  email varchar(150) unique
);

create table Topic(
  id varchar(2) primary key,
  userNameCreated varchar(10),
  nameTopic nvarchar2(50),
  description nvarchar2(200),
  foreign key (userNameCreated) references AppUser(userName)
);

create table WordType(
  id varchar(2) primary key,
  nameWordType nvarchar2(50),
  description nvarchar2(200)
);

create table Vocabulary(
  id varchar(5) primary key,
  englishWord varchar(100),
  vietnamWord nvarchar2(150),
  transcription nvarchar2(100),
  idTopic varchar(2),
  idWordType varchar(2),
  foreign key (idTopic) references Topic(id),
  foreign key (idWordType) references WordType(id)
);


insert all
  into AppUser(id, userName, passWord, name, email) values('u01', 'tambui', '1', 'B�i V?n T�m', 'tamse22032004@gmail.com')
  into AppUser(id, userName, passWord, name, email) values('u02', 'thanhloc', '1', 'Nguy?n Th�nh L?c', 'thanhloc@gmail.com')
select * from dual;
select * from AppUser

insert all
  into Topic(id, userNameCreated, nameTopic, description) values('01', 'tambui', 'Technology', 'Topic n�y ch?a nh?ng t? li�n quan ??n l?nh v?c c�ng ngh?')
  into Topic(id, userNameCreated, nameTopic, description) values('02', 'thanhloc', 'Education', 'Topic n�y ch?a nh?ng t? li�n quan h?c t?p')
select * from dual;
select * from Topic

insert all
  into WordType(id, nameWordType, description) values('01', 'Adverd', 'Tr?ng t? b? ngh?a cho ??ng t?')
  into WordType(id, nameWordType, description) values('02', 'Noun', 'Danh t? th??ng l�m ch? ng?')
select * from dual;

insert all
  into Vocabulary(id, englishWord, vietnamWord, transcription, idTopic, idWordType) 
  values('01', 'Costly', '??t ??', '/?k??st.li/', '01', '02')

  into Vocabulary(id, englishWord, vietnamWord, transcription, idTopic, idWordType) 
  values('02', 'Prize', 'Gi?i th??ng', '/pra?z/', '02', '02')

select * from dual;

select * from Vocabulary;

CREATE OR REPLACE PROCEDURE SignUpUser(
    p_userName IN VARCHAR2,
    p_passWord IN VARCHAR2,
    p_name IN NVARCHAR2,
    p_email IN VARCHAR2
)
AS
    v_count NUMBER;
    v_id VARCHAR2(10);
BEGIN
    -- Ki?m tra xem Username ho?c Email ?� t?n t?i ch?a
    SELECT COUNT(*) INTO v_count FROM AppUser WHERE userName = p_userName OR email = p_email;

    IF v_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Username ho?c Email ?� t?n t?i!');
    ELSE
        -- L?y ID m?i t? sequence
        SELECT 'u' || LPAD(AppUser_Seq.NEXTVAL, 2, '0') INTO v_id FROM dual;

        -- Th�m user m?i v�o b?ng
        INSERT INTO AppUser (id, userName, passWord, name, email)
        VALUES (v_id, p_userName, p_passWord, p_name, p_email);

        COMMIT;
    END IF;
END SignUpUser;


CREATE SEQUENCE AppUser_Seq
START WITH 3
INCREMENT BY 1
NOCACHE
NOCYCLE;

DELETE FROM AppUser WHERE userName = 'danhquang';
COMMIT;


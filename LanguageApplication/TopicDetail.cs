using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageApplication
{
    public partial class TopicDetail : Form
    {
        private string idTopic = "";
        public TopicDetail()
        {
            InitializeComponent();
            
        }
        public TopicDetail(string idTopic)
        {
            InitializeComponent();
            this.idTopic = idTopic;
        }
        private void btnViewVocabulary_Click(object sender, EventArgs e)
        {
            ViewVocabulary viewVocabulary = new ViewVocabulary(idTopic);
            viewVocabulary.Show();
        }

        private void btnPracticeVocabulary_Click(object sender, EventArgs e)
        {
            PracticeVocabulary practiceVocabulary = new PracticeVocabulary(idTopic);
            practiceVocabulary.Show();
        }

        private void btnPracticePronunciation_Click(object sender, EventArgs e)
        {
            PracticePronunciation practicePronunciation = new PracticePronunciation(idTopic);  
            practicePronunciation.Show();
        }
    }
}

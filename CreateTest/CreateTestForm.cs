using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CreateTest
{
    public partial class CreateTestForm : Form
    {
        public CreateTestForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(700, 400);
        }

        private List<Question> questions = new List<Question>();

        private void SaveToFile(string path)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = File.Open(path, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, questions);
            }
        }

        private void OneAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            questions.Add(new OneAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + questions.Count);
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (questions.Count == 0)
                return;
            int current = lbQuestions.SelectedIndex;
            if (current == -1)
                return;
            var testControl = TestControlFactory.Create(questions[current]);
            panel.Controls.Add(testControl);
        }

        private void SaveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files(*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                SaveToFile(saveFileDialog.FileName);
        }

        private void MultipleAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            questions.Add(new MultipleAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + questions.Count);
        }

        private void CustomAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            questions.Add(new CustomAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + questions.Count);
        }

        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            CreateTestForm_Resize(sender, e);
            lbQuestions.Enabled = false;
        }

        private void CreateTestForm_Resize(object sender, EventArgs e)
        {
            lbQuestions.ClientSize = new Size(lbQuestions.ClientSize.Width, this.ClientSize.Height);
        }

        private void RemoveQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
                return;
            int current = lbQuestions.SelectedIndex;
            questions.RemoveAt(current);
            lbQuestions.Items.RemoveAt(questions.Count);
            if (questions.Count == 0)
                lbQuestions.Enabled = false;
            lbQuestions_SelectedIndexChanged(null, null);
        }
    }
}

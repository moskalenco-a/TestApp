using System;
using System.Drawing;
using System.Windows.Forms;
using TestCore;

namespace CreateTest
{
    public partial class CreateTestForm : Form
    {
        public CreateTestForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(700, 400);
        }

        private QuestionCollection collection = new QuestionCollection();

        private void OneAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            collection.Add(new OneAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + collection.Count);
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (collection.Count == 0)
                return;
            int current = lbQuestions.SelectedIndex;
            if (current == -1)
                return;
            var testControl = TestControlFactory.Create(collection[current]);
            panel.Controls.Add(testControl);
        }

        private void SaveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files(*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                collection.SaveToFile(saveFileDialog.FileName);
        }

        private void MultipleAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            collection.Add(new MultipleAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + collection.Count);
        }

        private void CustomAnswerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbQuestions.Enabled = true;
            collection.Add(new CustomAnswerQuestion());
            lbQuestions.Items.Add("Вопрос " + collection.Count);
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
            collection.RemoveAt(lbQuestions.SelectedIndex);
            lbQuestions.Items.RemoveAt(collection.Count);
            if (collection.Count == 0)
                lbQuestions.Enabled = false;
            lbQuestions_SelectedIndexChanged(null, null);
        }
    }
}
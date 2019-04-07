using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace PlayTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Question> questions;
        private List<TestUserControl> testControls = new List<TestUserControl>();
        private int current;

        private List<Question> GetQuestionsFromFile(string path)
        {
            List<Question> questionsList = null;
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new StreamReader(path))
            {
                questionsList = (List<Question>)serializer.Deserialize(stream);
            }
            return questionsList;
        }

        private void UpdateButtonsState()
        {
            btnNext.Enabled = btnPrev.Enabled = true;
            if (current == 0)
                btnPrev.Enabled = false;
            if (current == questions.Count - 1)
                btnNext.Text = "Завершить";

            btnPrev.Top = btnNext.Top = testControls[current].Height + 20;
            //this.Height = btnNext.Top + btnNext.Height + 30;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            questions = GetQuestionsFromFile("data.xml");
            for (int i = 0; i < questions.Count; i++)
            {
                var testControl = TestControlFactory.CreateControl(questions[i]);
                testControl.Top = testControl.Left = 0;
                testControl.Visible = false;
                testControls.Add(testControl);
                this.Controls.Add(testControl);
            }
            current = 0;
            UpdateButtonsState();
            testControls[current].Visible = true;
            this.Text = "Вопрос 1";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            testControls[current].Visible = false;
            current--;
            testControls[current].Visible = true;
            UpdateButtonsState();
            this.Text = "Вопрос " + (current + 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current == questions.Count - 1)
            {
                int correctAnswers = 0;
                foreach (TestUserControl control in testControls)
                {
                    if (control is ucOneAnswerTest)
                    {
                        if ((control as ucOneAnswerTest).IsAnswerCorrect)
                            correctAnswers++;
                    }

                    if (control is ucMultipleAnswerTest)
                    {
                        if ((control as ucMultipleAnswerTest).IsAnswerCorrect)
                            correctAnswers++;
                    }

                    if (control is ucCustomAnswerTest)
                    {
                        if ((control as ucCustomAnswerTest).IsAnswerCorrect)
                            correctAnswers++;
                    }
                }
                string info = string.Format("Тест завершен\nПравильных ответов: {0} / {1}", correctAnswers, questions.Count);
                MessageBox.Show(info, "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = btnPrev.Enabled = false;
                return;
            }
            testControls[current].Visible = false;
            current++;
            testControls[current].Visible = true;
            UpdateButtonsState();
            this.Text = "Вопрос " + (current + 1);
        }
    }
}

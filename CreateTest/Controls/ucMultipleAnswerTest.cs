using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestCore;

namespace CreateTest
{
    public partial class ucMultipleAnswerTest : ucBaseTest
    {
        private MultipleAnswerQuestion question;
        private List<CheckedTextBox> checkBoxes = new List<CheckedTextBox>(10);

        public ucMultipleAnswerTest(MultipleAnswerQuestion question)
        {
            InitializeComponent();
            this.question = question;
            tbQuestion.Text = question.Text;
            numericUpDown.Value = question.Answers.Count;
            UpdateCheckBoxes();
            for (int i = 0; i < question.Answers.Count; i++)
                checkBoxes[i].Checked = question.Answers[i].IsTrue;
        }

        public void UpdateCheckBoxes()
        {
            var answers = question.Answers;
            if (checkBoxes.Count < answers.Count)
            {
                for (int index = checkBoxes.Count; index < answers.Count; index++)
                {
                    int i = index;
                    var checkedTextBox = new CheckedTextBox();
                    if (i == 0)
                        checkedTextBox.Top = lbAnswers.Top + lbAnswers.Height + 5;
                    else
                        checkedTextBox.Top = checkBoxes.Last().Top + checkBoxes.Last().Height;
                    checkedTextBox.Left = tbQuestion.Left;
                    checkedTextBox.Width = this.Width - 15;
                    checkedTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    checkedTextBox.Text = answers[i].Text;
                    checkedTextBox.TextChanged += (s, e) =>
                    {
                        answers[i].Text = (s as CheckedTextBox).Text;
                    };
                    checkedTextBox.CheckedChanged += (s, e) =>
                    {
                        this.question.Answers[i].IsTrue = (s as CheckedTextBox).Checked;
                    };
                    checkBoxes.Add(checkedTextBox);
                    this.Controls.Add(checkedTextBox);
                }
                return;
            }

            for (int i = checkBoxes.Count - 1; i >= answers.Count; i--)
            {
                this.Controls.Remove(checkBoxes[i]);
            }
            checkBoxes = checkBoxes.Take(answers.Count).ToList();
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            question.Text = (sender as TextBox).Text;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newSize = (int)numericUpDown.Value;
            if (newSize > question.Answers.Count)
            {
                for (int i = newSize; i > question.Answers.Count; i--)
                    question.Answers.Add(new Answer());
            }
            else question.Answers = question.Answers.Take(newSize).ToList();
            UpdateCheckBoxes();
        }
    }
}
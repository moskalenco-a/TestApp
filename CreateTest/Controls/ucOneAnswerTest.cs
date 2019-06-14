using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestCore;

namespace CreateTest
{
    public partial class ucOneAnswerTest : ucBaseTest
    {
        private OneAnswerQuestion question;
        private List<RadioTextBox> radioButtons = new List<RadioTextBox>(10);

        public ucOneAnswerTest(OneAnswerQuestion question = null)
        {
            InitializeComponent();
            this.question = question;
            tbQuestion.Text = question.Text;
            numericUpDown.Value = question.Answers.Count;
            UpdateRadioButtons();
            if (question.Answers.Count > 0)
                radioButtons[question.CorrectAnswerIndex].Checked = true;
        }

        public void UpdateRadioButtons()
        {
            var rbt = radioButtons;
            var answers = question.Answers;
            if (rbt.Count < answers.Count)
            {
                for (int index = rbt.Count; index < answers.Count; index++)
                {
                    int i = index;
                    var radioTextBox = new RadioTextBox();
                    if (i == 0)
                        radioTextBox.Top = lbAnswers.Top + lbAnswers.Height + 5;
                    else
                        radioTextBox.Top = rbt.Last().Top + rbt.Last().Height;
                    radioTextBox.Left = tbQuestion.Left;
                    radioTextBox.Width = this.Width - 15;
                    radioTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    radioTextBox.Text = answers[i];
                    radioTextBox.TextChanged += (s, e) =>
                    {
                        answers[i] = (s as RadioTextBox).Text;
                    };
                    radioTextBox.CheckedChanged += (s, e) =>
                    {
                        if ((s as RadioTextBox).Checked)
                            this.question.CorrectAnswerIndex = i;
                    };
                    rbt.Add(radioTextBox);
                    this.Controls.Add(radioTextBox);
                }
                return;
            }

            for (int i = rbt.Count - 1; i >= answers.Count; i--)
            {
                this.Controls.Remove(rbt[i]);
            }
            radioButtons = radioButtons.Take(answers.Count).ToList();
            //rbt.Resize(answers.Count);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDown.Value;
            if (count < question.Answers.Count)
            {
                question.Answers = question.Answers.Take(count).ToList();
            }
            else
            {
                for (int i = question.Answers.Count; i < count; i++)
                    question.Answers.Add("");
            }
            //question.Answers.Resize((int)numericUpDown.Value);
            UpdateRadioButtons();
            if (question.CorrectAnswerIndex >= question.Answers.Count)
            {
                var cnt = question.Answers.Count;
                question.CorrectAnswerIndex =  cnt - 1;
                radioButtons[cnt - 1].Checked = true;
            }
        }
                
        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            question.Text = (sender as TextBox).Text;
        }
    }
}

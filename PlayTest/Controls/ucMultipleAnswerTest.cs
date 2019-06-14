using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using TestCore;

namespace PlayTest
{
    public partial class ucMultipleAnswerTest : TestUserControl
    {
        private MultipleAnswerQuestion question;
        private List<bool> isChecked;

        public ucMultipleAnswerTest(MultipleAnswerQuestion question)
        {
            InitializeComponent();

            this.question = question;
            int answersCount = question.Answers.Count;
            isChecked = Enumerable.Repeat(false, answersCount).ToList();

            lbQuestion.Text = question.Text;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            int margin = 20;
            int currentTop = lbQuestion.Top + lbQuestion.Height + margin;

            for (int index = 0; index < answersCount; index++)
            {
                int i = index;
                var checkBox = new CheckBox
                {
                    Text = question.Answers[i].Text,
                    AutoSize = true,
                    Left = 20,
                    Top = currentTop,
                    Checked = false
                };
                checkBox.CheckedChanged += (s, e) =>
                {
                    isChecked[i] = (s as CheckBox).Checked;
                };
                currentTop += checkBox.Height;
                this.Controls.Add(checkBox);
                if (i == answersCount - 1)
                {
                    var width = this.ClientSize.Width;
                    var height = checkBox.Top + checkBox.Height;// + margin;
                    this.ClientSize = new System.Drawing.Size(width, height);
                }
            }
        }

        public override object GetUserAnswer()
        {
            return isChecked;
        }
    }
}

using System.Windows.Forms;
using TestCore;

namespace PlayTest
{
    public partial class ucOneAnswerTest : TestUserControl
    {
        private OneAnswerQuestion question;
        private int index;

        public ucOneAnswerTest(OneAnswerQuestion question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.Text;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            int answersCount = question.Answers.Count;
            int margin = 20;
            int rbFirstTop = lbQuestion.Top + lbQuestion.Height + margin;
            int lastTop = lbQuestion.Top + lbQuestion.Height + margin;
            for (int ind = 0; ind < answersCount; ind++)
            {
                int i = ind;
                var radioButton = new RadioButton
                {
                    Text = question.Answers[i],
                    AutoSize = true,
                    Left = 20,
                    Top = lastTop
                };
                radioButton.CheckedChanged += (s, e) =>
                {
                    if ((s as RadioButton).Checked)
                        index = i;
                };
                lastTop += radioButton.Height;
                this.Controls.Add(radioButton);
                if (i == answersCount - 1)
                {
                    var width = this.ClientSize.Width;
                    var height = radioButton.Top + radioButton.Height;// + margin;
                    this.ClientSize = new System.Drawing.Size(width, height);
                }
            }
        }

        public override object GetUserAnswer()
        {
            return index;
        }
    }
}
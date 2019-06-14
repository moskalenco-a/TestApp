using TestCore;

namespace PlayTest
{
    public partial class ucCustomAnswerTest : TestUserControl
    {
        private CustomAnswerQuestion question;

        public ucCustomAnswerTest(CustomAnswerQuestion question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.Text;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            tbAnswer.Left = (this.Width - tbAnswer.Width) / 2;
        }

        public override object GetUserAnswer()
        {
            return tbAnswer.Text;
        }
    }
}
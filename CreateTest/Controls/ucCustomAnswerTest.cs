using TestCore;

namespace CreateTest
{
    public partial class ucCustomAnswerTest : ucBaseTest
    {
        public ucCustomAnswerTest(CustomAnswerQuestion question)
        {
            InitializeComponent();
            tbQuestion.DataBindings.Add("Text", question, "Text");
            tbCorrectAnswer.DataBindings.Add("Text", question, "CorrectAnswer");
        }
    }
}
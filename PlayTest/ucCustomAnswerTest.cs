using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayTest
{
    public partial class ucCustomAnswerTest : TestUserControl
    {
        private Question question;

        public ucCustomAnswerTest(Question question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.QuestionText;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            tbAnswer.Left = (this.Width - tbAnswer.Width) / 2;
        }

        public override bool IsAnswerCorrect
        {
            get
            {
                return tbAnswer.Text.ToLower() == question.CorrectAnswer.ToLower();
            }
        }
    }
}

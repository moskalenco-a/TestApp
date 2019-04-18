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
        private CustomAnswerQuestion question;

        public ucCustomAnswerTest(CustomAnswerQuestion question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.Text;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            tbAnswer.Left = (this.Width - tbAnswer.Width) / 2;
        }

        public override bool IsAnswerCorrect()
        {
            return tbAnswer.Text.ToLower() == question.CorrectAnswer.ToLower();
        }
    }
}

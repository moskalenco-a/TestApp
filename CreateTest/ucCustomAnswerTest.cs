using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CreateTest
{
    public partial class ucCustomAnswerTest : ucBaseTest
    {
        private CustomAnswerQuestion question;

        public ucCustomAnswerTest(CustomAnswerQuestion question)
        {
            InitializeComponent();
            this.question = question;
            tbQuestion.Text = question.Text;
            tbCorrectAnswer.Text = question.CorrectAnswer;
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            question.Text = (sender as TextBox).Text;
        }

        private void tbCorrectAnswer_TextChanged(object sender, EventArgs e)
        {
            question.CorrectAnswer = (sender as TextBox).Text;
        }
    }
}

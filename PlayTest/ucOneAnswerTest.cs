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
    public partial class ucOneAnswerTest : TestUserControl
    {
        private Question question;

        public ucOneAnswerTest(Question question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.QuestionText;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            int answersCount = question.Answers.Count;
            int margin = 20;
            int rbFirstTop = lbQuestion.Top + lbQuestion.Height + margin;
            int lastTop = lbQuestion.Top + lbQuestion.Height + margin;
            for (int i = 0; i < answersCount; i++)
            {
                var rb = new RadioButton
                {
                    Text = question.Answers[i].Text,
                    AutoSize = true,
                    Left = 20,
                    Top = lastTop,
                    Name = "rb" + i
                };
                lastTop += rb.Height;
                this.Controls.Add(rb);
                if (i == answersCount - 1)
                    this.Height = rb.Top + rb.Height + margin;
            }
        }

        public override bool IsAnswerCorrect
        {
            get
            {
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if ((this.Controls["rb" + i] as RadioButton).Checked != question.Answers[i].IsTrue)
                        return false;
                }
                return true;
            }
        }
    }
}

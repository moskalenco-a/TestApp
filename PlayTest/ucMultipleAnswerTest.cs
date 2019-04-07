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
    public partial class ucMultipleAnswerTest : TestUserControl
    {
        private Question question;

        public ucMultipleAnswerTest(Question question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.QuestionText;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            int answersCount = question.Answers.Count;
            int margin = 20;
            int cbFirstTop = lbQuestion.Top + lbQuestion.Height + margin;
            int lastTop = lbQuestion.Top + lbQuestion.Height + margin;
            for (int i = 0; i < answersCount; i++)
            {
                var cb = new CheckBox
                {
                    Text = question.Answers[i].Text,
                    AutoSize = true,
                    Left = 20,
                    Top = lastTop,
                    Name = "cb" + i
                };
                lastTop += cb.Height;
                this.Controls.Add(cb);
                if (i == answersCount - 1)
                    this.Height = cb.Top + cb.Height + margin;
            }
        }

        public override bool IsAnswerCorrect
        {
            get
            {
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if ((this.Controls["cb" + i] as CheckBox).Checked != question.Answers[i].IsTrue)
                        return false;
                }
                return true;
            }
        }
    }
}

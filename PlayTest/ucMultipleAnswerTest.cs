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
        private MultipleAnswerQuestion question;

        public ucMultipleAnswerTest(MultipleAnswerQuestion question)
        {
            InitializeComponent();

            this.question = question;
            lbQuestion.Text = question.Text;
            lbQuestion.Left = (this.Width - lbQuestion.Width) / 2;
            int answersCount = question.Answers.Count;
            int margin = 20;
            int currentTop = lbQuestion.Top + lbQuestion.Height + margin;
            for (int i = 0; i < answersCount; i++)
            {
                var cb = new CheckBox
                {
                    Text = question.Answers[i].Text,
                    AutoSize = true,
                    Left = 20,
                    Top = currentTop,
                    Name = "cb" + i
                };
                //cb.Paint += cb_Paint;
                currentTop += cb.Height;
                this.Controls.Add(cb);
                if (i == answersCount - 1)
                    this.Height = cb.Top + cb.Height + margin;
            }
        }

        void cb_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Blue);
            var rectangle = new Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(pen, rectangle);
        }

        public override bool IsAnswerCorrect()
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

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
        private OneAnswerQuestion question;

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
            for (int i = 0; i < answersCount; i++)
            {
                var rb = new RadioButton
                {
                    Text = question.Answers[i],
                    AutoSize = true,
                    Left = 20,
                    Top = lastTop,
                    Name = "rb" + i
                };
                rb.Paint += rb_Paint;
                lastTop += rb.Height;
                this.Controls.Add(rb);
                if (i == answersCount - 1)
                    this.Height = rb.Top + rb.Height + margin;
            }
        }

        void rb_Paint(object sender, PaintEventArgs e)
        {
            //var pen = new Pen(Color.Blue);
            //var rectangle = new Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            //e.Graphics.DrawRectangle(pen, rectangle);
        }

        public override bool IsAnswerCorrect()
        {
            var index = question.CorrectAnswerIndex;
            var rb = this.Controls["rb" + index] as RadioButton;
            return rb.Checked;
        }
    }
}

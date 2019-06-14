using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlayTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Test test;
        private TestUserControl currentTestControl = null;

        private void UpdateButtons()
        {
            btnNext.Text = test.IsLast ? "Завершить" : "Вперед";
        }

        public void ChangeTestControl()
        {
            if (currentTestControl != null)
                this.Controls.Remove(currentTestControl);
            currentTestControl = TestControlFactory.CreateControl(test.Current);
            currentTestControl.Top = currentTestControl.Left = 0;
            this.Controls.Add(currentTestControl);
        }

        public void ResizeForm()
        {
            var mg = 15;
            var top = currentTestControl.Height + mg;
            btnPrev.Top = btnNext.Top = top;
            var formWidth = currentTestControl.Width;
            var formHeight = top + btnPrev.Height + mg;
            this.ClientSize = new Size(formWidth, formHeight);
        }

        public void UpdateUI()
        {
            btnPrev.Enabled = btnNext.Enabled = false;
            ChangeTestControl();
            ResizeForm();
            UpdateButtons();
            btnPrev.Enabled = btnNext.Enabled = true;
            this.Text = $"Вопрос {test.GetCurrentIndex + 1}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            test = new Test("test.xml");
            UpdateUI();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            test.CheckCurrentQuestion(currentTestControl.GetUserAnswer());
            test.Prev();
            UpdateUI();
        }
                
        private void btnNext_Click(object sender, EventArgs e)
        {
            test.CheckCurrentQuestion(currentTestControl.GetUserAnswer());
            if (test.IsLast)
            {
                int all = test.QuestionCount();
                int correct = test.GetCorrectCount();
                string info = $"Тест завершен\nПравильных ответов: {correct} / {all}";
                MessageBox.Show(info, "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = btnPrev.Enabled = false;
                return;
            }
            test.Next();
            UpdateUI();
        }
    }
}
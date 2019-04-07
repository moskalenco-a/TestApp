using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CreateTest
{
    public partial class CreateTestForm : Form
    {
        public CreateTestForm()
        {
            InitializeComponent();
        }

        private List<Question> questions = new List<Question>();
        private int? current = null;

        private void QuestionsTreeAddItem()
        {
            questionsTree.Nodes[0].Nodes.Add(string.Format("Вопрос {0}", questions.Count));
            questionsTree.Nodes[0].Expand();
        }

        private void QuestionTreeDeleteItem()
        {
            questionsTree.Nodes[0].LastNode.Remove();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            questions.Add(new Question());
            QuestionsTreeAddItem();
        }

        private void RebindControls()
        {
            tbQuestion.DataBindings.Clear();
            tbQuestion.Clear();

            dgvAnswers.DataSource = null;

            tbCorrectAnswer.DataBindings.Clear();
            tbCorrectAnswer.Clear();

            if (questions.Count == 0 || current == null)
                return;
            int index = current.Value;
            var binding = new Binding("Text", questions[index], "QuestionText");
            tbQuestion.DataBindings.Add(binding);

            var type = questions[index].Type;
            rbOneAnswer.Checked = type == QuestionType.OneAnswer;
            rbMultipleAnswer.Checked = type == QuestionType.MultipleAnswer;
            rbCustomAnswer.Checked = type == QuestionType.CustomAnswer;
            
            if (type == QuestionType.CustomAnswer)
            {
                lbCorrectAnswer.Visible = true;
                tbCorrectAnswer.Visible = true;
                tbCorrectAnswer.DataBindings.Add("Text", questions[index], "CorrectAnswer");
            }
            else
            {
                var bs = new BindingSource();
                bs.DataSource = questions[index].Answers;
                dgvAnswers.DataSource = bs;
                dgvAnswers.Update();
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            questions.RemoveAt(current.Value);
            QuestionTreeDeleteItem();
            RebindControls();
        }

        private void questionsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            current = questionsTree.SelectedNode.Index;
            if (questionsTree.SelectedNode == questionsTree.Nodes[0])
                current = null;
            RebindControls();
        }

        private void rbQuestionType_CheckedChanged(object sender, EventArgs e)
        {
            if (current == null)
                return;
            int index = current.Value;
            lbCorrectAnswer.Visible = tbCorrectAnswer.Visible = false;
            if (rbOneAnswer.Checked)
                questions[index].Type = QuestionType.OneAnswer;
            if (rbMultipleAnswer.Checked)
                questions[index].Type = QuestionType.MultipleAnswer;
            if (rbCustomAnswer.Checked)
            {
                questions[index].Type = QuestionType.CustomAnswer;
                questions[index].Answers.Clear();
                lbCorrectAnswer.Visible = true;
                tbCorrectAnswer.Visible = true;
                this.Width = 436;
            }
            else this.Width = 813;
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            int index = current.Value;
            //new AddAnswerForm(questions[index].Answers).ShowDialog(this);
            questions[index].Answers.Add(new Answer
            {
                Text = "Введите вариант ответа",
                IsTrue = false
            });
            RebindControls();
        }

        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            var tooltip = new ToolTip();
            tooltip.SetToolTip(btnAddQuestion, "Добавить вопрос");
            tooltip.SetToolTip(btnDeleteQuestion, "Удалить вопрос");

            tooltip.SetToolTip(btnAddAnswer, "Добавить");
            tooltip.SetToolTip(btnDeleteAnswer, "Удалить");
            RebindControls();
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            int index = current.Value;
            int currentRow = dgvAnswers.CurrentCell.RowIndex;
            questions[index].Answers.RemoveAt(currentRow);
            RebindControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new StreamWriter("test.xml"))
            {
                serializer.Serialize(stream, questions);
            }
        }
    }
}

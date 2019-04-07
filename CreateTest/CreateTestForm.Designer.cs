namespace CreateTest
{
    partial class CreateTestForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Вопросы");
            this.questionsTree = new System.Windows.Forms.TreeView();
            this.gbQuestionType = new System.Windows.Forms.GroupBox();
            this.rbCustomAnswer = new System.Windows.Forms.RadioButton();
            this.rbMultipleAnswer = new System.Windows.Forms.RadioButton();
            this.rbOneAnswer = new System.Windows.Forms.RadioButton();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbAnswers = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.tbCorrectAnswer = new System.Windows.Forms.TextBox();
            this.dgvAnswers = new System.Windows.Forms.DataGridView();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbQuestionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsTree
            // 
            this.questionsTree.Location = new System.Drawing.Point(0, 0);
            this.questionsTree.Name = "questionsTree";
            treeNode3.Name = "Root";
            treeNode3.Text = "Вопросы";
            this.questionsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.questionsTree.Size = new System.Drawing.Size(121, 210);
            this.questionsTree.TabIndex = 0;
            this.questionsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.questionsTree_AfterSelect);
            // 
            // gbQuestionType
            // 
            this.gbQuestionType.Controls.Add(this.rbCustomAnswer);
            this.gbQuestionType.Controls.Add(this.rbMultipleAnswer);
            this.gbQuestionType.Controls.Add(this.rbOneAnswer);
            this.gbQuestionType.Location = new System.Drawing.Point(192, 51);
            this.gbQuestionType.Name = "gbQuestionType";
            this.gbQuestionType.Size = new System.Drawing.Size(216, 84);
            this.gbQuestionType.TabIndex = 2;
            this.gbQuestionType.TabStop = false;
            this.gbQuestionType.Text = "Тип вопроса:";
            // 
            // rbCustomAnswer
            // 
            this.rbCustomAnswer.AutoSize = true;
            this.rbCustomAnswer.Location = new System.Drawing.Point(18, 61);
            this.rbCustomAnswer.Name = "rbCustomAnswer";
            this.rbCustomAnswer.Size = new System.Drawing.Size(167, 17);
            this.rbCustomAnswer.TabIndex = 2;
            this.rbCustomAnswer.TabStop = true;
            this.rbCustomAnswer.Text = "Ответ вводит пользователь";
            this.rbCustomAnswer.UseVisualStyleBackColor = true;
            this.rbCustomAnswer.CheckedChanged += new System.EventHandler(this.rbQuestionType_CheckedChanged);
            // 
            // rbMultipleAnswer
            // 
            this.rbMultipleAnswer.AutoSize = true;
            this.rbMultipleAnswer.Location = new System.Drawing.Point(18, 40);
            this.rbMultipleAnswer.Name = "rbMultipleAnswer";
            this.rbMultipleAnswer.Size = new System.Drawing.Size(188, 17);
            this.rbMultipleAnswer.TabIndex = 1;
            this.rbMultipleAnswer.TabStop = true;
            this.rbMultipleAnswer.Text = "Несколько правильных ответов";
            this.rbMultipleAnswer.UseVisualStyleBackColor = true;
            this.rbMultipleAnswer.CheckedChanged += new System.EventHandler(this.rbQuestionType_CheckedChanged);
            // 
            // rbOneAnswer
            // 
            this.rbOneAnswer.AutoSize = true;
            this.rbOneAnswer.Location = new System.Drawing.Point(18, 19);
            this.rbOneAnswer.Name = "rbOneAnswer";
            this.rbOneAnswer.Size = new System.Drawing.Size(147, 17);
            this.rbOneAnswer.TabIndex = 0;
            this.rbOneAnswer.TabStop = true;
            this.rbOneAnswer.Text = "Один правильный ответ";
            this.rbOneAnswer.UseVisualStyleBackColor = true;
            this.rbOneAnswer.CheckedChanged += new System.EventHandler(this.rbQuestionType_CheckedChanged);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(191, 25);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(217, 20);
            this.tbQuestion.TabIndex = 3;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(189, 9);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(85, 13);
            this.lbQuestion.TabIndex = 4;
            this.lbQuestion.Text = "Текст вопроса:";
            // 
            // lbAnswers
            // 
            this.lbAnswers.AutoSize = true;
            this.lbAnswers.Location = new System.Drawing.Point(431, 9);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(103, 13);
            this.lbAnswers.TabIndex = 5;
            this.lbAnswers.Text = "Варианты ответов:";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Location = new System.Drawing.Point(189, 154);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(105, 13);
            this.lbCorrectAnswer.TabIndex = 10;
            this.lbCorrectAnswer.Text = "Правильный ответ:";
            // 
            // tbCorrectAnswer
            // 
            this.tbCorrectAnswer.Location = new System.Drawing.Point(192, 170);
            this.tbCorrectAnswer.Name = "tbCorrectAnswer";
            this.tbCorrectAnswer.Size = new System.Drawing.Size(216, 20);
            this.tbCorrectAnswer.TabIndex = 11;
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.AllowUserToAddRows = false;
            this.dgvAnswers.AllowUserToDeleteRows = false;
            this.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswers.Location = new System.Drawing.Point(434, 55);
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.RowHeadersVisible = false;
            this.dgvAnswers.Size = new System.Drawing.Size(345, 155);
            this.dgvAnswers.TabIndex = 13;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackgroundImage = global::CreateTest.Properties.Resources.delete24;
            this.btnDeleteQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(26, 216);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteQuestion.TabIndex = 12;
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.BackgroundImage = global::CreateTest.Properties.Resources.delete24;
            this.btnDeleteAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAnswer.Location = new System.Drawing.Point(460, 25);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteAnswer.TabIndex = 9;
            this.btnDeleteAnswer.UseVisualStyleBackColor = true;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.btnDeleteAnswer_Click);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackgroundImage = global::CreateTest.Properties.Resources.add24;
            this.btnAddAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAnswer.Location = new System.Drawing.Point(434, 25);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(24, 24);
            this.btnAddAnswer.TabIndex = 7;
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackgroundImage = global::CreateTest.Properties.Resources.add24;
            this.btnAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQuestion.Location = new System.Drawing.Point(0, 216);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(24, 24);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить тест";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 244);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAnswers);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.tbCorrectAnswer);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.lbAnswers);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.gbQuestionType);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.questionsTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateTestForm";
            this.Text = "Редактор тестов";
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.gbQuestionType.ResumeLayout(false);
            this.gbQuestionType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView questionsTree;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.GroupBox gbQuestionType;
        private System.Windows.Forms.RadioButton rbCustomAnswer;
        private System.Windows.Forms.RadioButton rbMultipleAnswer;
        private System.Windows.Forms.RadioButton rbOneAnswer;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbAnswers;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.TextBox tbCorrectAnswer;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.DataGridView dgvAnswers;
        private System.Windows.Forms.Button btnSave;

    }
}


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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SaveTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OneAnswerTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultipleAnswerTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomAnswerTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.lbQuestions = new CreateTest.CustomListBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTestToolStripMenuItem,
            this.AddQuestionToolStripMenuItem,
            this.RemoveQuestionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(523, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SaveTestToolStripMenuItem
            // 
            this.SaveTestToolStripMenuItem.Name = "SaveTestToolStripMenuItem";
            this.SaveTestToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.SaveTestToolStripMenuItem.Text = "Сохранить тест";
            this.SaveTestToolStripMenuItem.Click += new System.EventHandler(this.SaveTestToolStripMenuItem_Click);
            // 
            // AddQuestionToolStripMenuItem
            // 
            this.AddQuestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneAnswerTestToolStripMenuItem,
            this.MultipleAnswerTestToolStripMenuItem,
            this.CustomAnswerTestToolStripMenuItem});
            this.AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            this.AddQuestionToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.AddQuestionToolStripMenuItem.Text = "Добавить вопрос";
            // 
            // OneAnswerTestToolStripMenuItem
            // 
            this.OneAnswerTestToolStripMenuItem.Name = "OneAnswerTestToolStripMenuItem";
            this.OneAnswerTestToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.OneAnswerTestToolStripMenuItem.Text = "Один вариант ответа";
            this.OneAnswerTestToolStripMenuItem.Click += new System.EventHandler(this.OneAnswerTestToolStripMenuItem_Click);
            // 
            // MultipleAnswerTestToolStripMenuItem
            // 
            this.MultipleAnswerTestToolStripMenuItem.Name = "MultipleAnswerTestToolStripMenuItem";
            this.MultipleAnswerTestToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.MultipleAnswerTestToolStripMenuItem.Text = "Несколько вариантов ответа";
            this.MultipleAnswerTestToolStripMenuItem.Click += new System.EventHandler(this.MultipleAnswerTestToolStripMenuItem_Click);
            // 
            // CustomAnswerTestToolStripMenuItem
            // 
            this.CustomAnswerTestToolStripMenuItem.Name = "CustomAnswerTestToolStripMenuItem";
            this.CustomAnswerTestToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.CustomAnswerTestToolStripMenuItem.Text = "Ответ вводит пользователь";
            this.CustomAnswerTestToolStripMenuItem.Click += new System.EventHandler(this.CustomAnswerTestToolStripMenuItem_Click);
            // 
            // RemoveQuestionToolStripMenuItem
            // 
            this.RemoveQuestionToolStripMenuItem.Name = "RemoveQuestionToolStripMenuItem";
            this.RemoveQuestionToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.RemoveQuestionToolStripMenuItem.Text = "Удалить вопрос";
            this.RemoveQuestionToolStripMenuItem.Click += new System.EventHandler(this.RemoveQuestionToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(144, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(379, 292);
            this.panel.TabIndex = 2;
            // 
            // lbQuestions
            // 
            this.lbQuestions.EmptyText = "Добавьте вопросы";
            this.lbQuestions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.ItemHeight = 19;
            this.lbQuestions.Location = new System.Drawing.Point(1, 24);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(138, 251);
            this.lbQuestions.TabIndex = 3;
            this.lbQuestions.SelectedIndexChanged += new System.EventHandler(this.lbQuestions_SelectedIndexChanged);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 316);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CreateTestForm";
            this.Text = "Редактор тестов";
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.Resize += new System.EventHandler(this.CreateTestForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OneAnswerTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MultipleAnswerTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomAnswerTestToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private CustomListBox lbQuestions;


    }
}


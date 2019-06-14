namespace CreateTest
{
    partial class ucMultipleAnswerTest
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lbAnswers = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(176, 54);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(37, 26);
            this.numericUpDown.TabIndex = 44;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lbAnswers
            // 
            this.lbAnswers.AutoSize = true;
            this.lbAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnswers.Location = new System.Drawing.Point(3, 58);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(167, 19);
            this.lbAnswers.TabIndex = 43;
            this.lbAnswers.Text = "Количество вариантов:";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestion.Location = new System.Drawing.Point(3, 3);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(107, 19);
            this.lbQuestion.TabIndex = 42;
            this.lbQuestion.Text = "Текст вопроса:";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuestion.Location = new System.Drawing.Point(7, 25);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(206, 26);
            this.tbQuestion.TabIndex = 41;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // ucMultipleAnswerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lbAnswers);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.tbQuestion);
            this.Name = "ucMultipleAnswerTest";
            this.Size = new System.Drawing.Size(221, 240);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnswers;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

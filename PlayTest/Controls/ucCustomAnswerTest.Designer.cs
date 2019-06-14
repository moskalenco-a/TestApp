namespace PlayTest
{
    partial class ucCustomAnswerTest
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(20, 16);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(82, 13);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Текст вопроса";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(25, 42);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(300, 20);
            this.tbAnswer.TabIndex = 1;
            // 
            // ucCustomAnswerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lbQuestion);
            this.Name = "ucCustomAnswerTest";
            this.Size = new System.Drawing.Size(350, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
    }
}

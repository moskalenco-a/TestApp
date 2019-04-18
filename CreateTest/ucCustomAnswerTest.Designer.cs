namespace CreateTest
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
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.tbCorrectAnswer = new System.Windows.Forms.TextBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(3, 58);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(140, 19);
            this.lbCorrectAnswer.TabIndex = 26;
            this.lbCorrectAnswer.Text = "Правильный ответ:";
            // 
            // tbCorrectAnswer
            // 
            this.tbCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCorrectAnswer.Location = new System.Drawing.Point(7, 80);
            this.tbCorrectAnswer.Name = "tbCorrectAnswer";
            this.tbCorrectAnswer.Size = new System.Drawing.Size(206, 26);
            this.tbCorrectAnswer.TabIndex = 25;
            this.tbCorrectAnswer.TextChanged += new System.EventHandler(this.tbCorrectAnswer_TextChanged);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestion.Location = new System.Drawing.Point(3, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(107, 19);
            this.lbQuestion.TabIndex = 24;
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
            this.tbQuestion.TabIndex = 23;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // ucCustomAnswerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.tbCorrectAnswer);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.tbQuestion);
            this.Name = "ucCustomAnswerTest";
            this.Size = new System.Drawing.Size(221, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.TextBox tbCorrectAnswer;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}

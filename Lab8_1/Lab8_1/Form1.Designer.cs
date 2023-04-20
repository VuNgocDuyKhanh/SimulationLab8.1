namespace Lab8_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question = new System.Windows.Forms.TextBox();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 12);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(776, 22);
            this.Question.TabIndex = 0;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(12, 40);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnswerBtn.TabIndex = 1;
            this.AnswerBtn.Text = "Answer";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(12, 69);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(100, 22);
            this.AnswerBox.TabIndex = 2;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(93, 41);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(120, 22);
            this.Num.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.Question);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.NumericUpDown Num;
    }
}


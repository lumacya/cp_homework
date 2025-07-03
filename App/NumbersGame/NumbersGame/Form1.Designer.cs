namespace NumbersGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_try = new System.Windows.Forms.Button();
            this.write_number = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_try
            // 
            this.button_try.Location = new System.Drawing.Point(366, 257);
            this.button_try.Name = "button_try";
            this.button_try.Size = new System.Drawing.Size(75, 23);
            this.button_try.TabIndex = 0;
            this.button_try.Text = "Проверить";
            this.button_try.UseVisualStyleBackColor = true;
            this.button_try.Click += new System.EventHandler(this.button1_Click);
            // 
            // write_number
            // 
            this.write_number.Location = new System.Drawing.Point(294, 148);
            this.write_number.Name = "write_number";
            this.write_number.Size = new System.Drawing.Size(219, 20);
            this.write_number.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(363, 71);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            this.Result.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.write_number);
            this.Controls.Add(this.button_try);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_try;
        private System.Windows.Forms.TextBox write_number;
        private System.Windows.Forms.Label Result;
    }
}


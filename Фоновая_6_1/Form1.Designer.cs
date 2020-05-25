namespace Фоновая_6_1
{
    partial class BtnForm
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
            this.A = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(60, 230);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(75, 23);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(242, 444);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 23);
            this.C.TabIndex = 1;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(556, 329);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(75, 23);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // BtnForm
            // 
            this.AcceptButton = this.B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A);
            this.Name = "BtnForm";
            this.Text = "BtnForm";
            this.Load += new System.EventHandler(this.BtnForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
    }
}


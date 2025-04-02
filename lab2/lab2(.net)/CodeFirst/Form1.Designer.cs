namespace CodeFirst
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
            this.СreateBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // СreateBD
            // 
            this.СreateBD.Location = new System.Drawing.Point(243, 101);
            this.СreateBD.Name = "СreateBD";
            this.СreateBD.Size = new System.Drawing.Size(288, 227);
            this.СreateBD.TabIndex = 0;
            this.СreateBD.Text = "Создай_БД!";
            this.СreateBD.UseVisualStyleBackColor = true;
            this.СreateBD.Click += new System.EventHandler(this.CreateBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.СreateBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button СreateBD;
    }
}


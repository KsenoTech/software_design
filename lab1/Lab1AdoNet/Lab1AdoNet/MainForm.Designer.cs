namespace Lab1AdoNet
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePhones = new System.Windows.Forms.TabPage();
            this.deleteCathTovar = new System.Windows.Forms.Button();
            this.textCatchTovar = new System.Windows.Forms.TextBox();
            this.buttonSavePhone = new System.Windows.Forms.Button();
            this.dataGridViewTovary = new System.Windows.Forms.DataGridView();
            this.Conf_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPagOrders = new System.Windows.Forms.TabPage();
            this.deleteCathZakaz = new System.Windows.Forms.Button();
            this.textCatchZakaz = new System.Windows.Forms.TextBox();
            this.buttonSaveOrders = new System.Windows.Forms.Button();
            this.dataGridViewZakazy = new System.Windows.Forms.DataGridView();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.comboBoxManufReport1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovary)).BeginInit();
            this.tabPagOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZakazy)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhones);
            this.tabControl1.Controls.Add(this.tabPagOrders);
            this.tabControl1.Controls.Add(this.tabPageQuery);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePhones
            // 
            this.tabPagePhones.Controls.Add(this.deleteCathTovar);
            this.tabPagePhones.Controls.Add(this.textCatchTovar);
            this.tabPagePhones.Controls.Add(this.buttonSavePhone);
            this.tabPagePhones.Controls.Add(this.dataGridViewTovary);
            this.tabPagePhones.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhones.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Name = "tabPagePhones";
            this.tabPagePhones.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Size = new System.Drawing.Size(1044, 517);
            this.tabPagePhones.TabIndex = 0;
            this.tabPagePhones.Text = "Мотоциклы";
            this.tabPagePhones.UseVisualStyleBackColor = true;
            // 
            // deleteCathTovar
            // 
            this.deleteCathTovar.Location = new System.Drawing.Point(959, 13);
            this.deleteCathTovar.Name = "deleteCathTovar";
            this.deleteCathTovar.Size = new System.Drawing.Size(78, 22);
            this.deleteCathTovar.TabIndex = 3;
            this.deleteCathTovar.Text = "Очистить";
            this.deleteCathTovar.UseVisualStyleBackColor = true;
            // 
            // textCatchTovar
            // 
            this.textCatchTovar.Location = new System.Drawing.Point(454, 13);
            this.textCatchTovar.Multiline = true;
            this.textCatchTovar.Name = "textCatchTovar";
            this.textCatchTovar.Size = new System.Drawing.Size(499, 22);
            this.textCatchTovar.TabIndex = 2;
            // 
            // buttonSavePhone
            // 
            this.buttonSavePhone.Location = new System.Drawing.Point(0, 7);
            this.buttonSavePhone.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSavePhone.Name = "buttonSavePhone";
            this.buttonSavePhone.Size = new System.Drawing.Size(236, 28);
            this.buttonSavePhone.TabIndex = 1;
            this.buttonSavePhone.Text = "Сохранить изменения";
            this.buttonSavePhone.UseVisualStyleBackColor = true;
            this.buttonSavePhone.Click += new System.EventHandler(this.buttonSavePhone_Click);
            // 
            // dataGridViewTovary
            // 
            this.dataGridViewTovary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Conf_Type});
            this.dataGridViewTovary.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewTovary.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTovary.Name = "dataGridViewTovary";
            this.dataGridViewTovary.RowHeadersWidth = 51;
            this.dataGridViewTovary.Size = new System.Drawing.Size(1037, 469);
            this.dataGridViewTovary.TabIndex = 0;
            this.dataGridViewTovary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewTovary_DataError);
            // 
            // Conf_Type
            // 
            this.Conf_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Conf_Type.DataPropertyName = "id_Type_FK";
            this.Conf_Type.HeaderText = "Conf_Type";
            this.Conf_Type.MinimumWidth = 6;
            this.Conf_Type.Name = "Conf_Type";
            this.Conf_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Conf_Type.Width = 125;
            // 
            // tabPagOrders
            // 
            this.tabPagOrders.Controls.Add(this.deleteCathZakaz);
            this.tabPagOrders.Controls.Add(this.textCatchZakaz);
            this.tabPagOrders.Controls.Add(this.buttonSaveOrders);
            this.tabPagOrders.Controls.Add(this.dataGridViewZakazy);
            this.tabPagOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPagOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Name = "tabPagOrders";
            this.tabPagOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Size = new System.Drawing.Size(1044, 517);
            this.tabPagOrders.TabIndex = 1;
            this.tabPagOrders.Text = "Тип";
            this.tabPagOrders.UseVisualStyleBackColor = true;
            // 
            // deleteCathZakaz
            // 
            this.deleteCathZakaz.Location = new System.Drawing.Point(951, 15);
            this.deleteCathZakaz.Name = "deleteCathZakaz";
            this.deleteCathZakaz.Size = new System.Drawing.Size(86, 23);
            this.deleteCathZakaz.TabIndex = 4;
            this.deleteCathZakaz.Text = "Очистить";
            this.deleteCathZakaz.UseVisualStyleBackColor = true;
            // 
            // textCatchZakaz
            // 
            this.textCatchZakaz.Location = new System.Drawing.Point(446, 16);
            this.textCatchZakaz.Multiline = true;
            this.textCatchZakaz.Name = "textCatchZakaz";
            this.textCatchZakaz.Size = new System.Drawing.Size(499, 22);
            this.textCatchZakaz.TabIndex = 3;
            // 
            // buttonSaveOrders
            // 
            this.buttonSaveOrders.Location = new System.Drawing.Point(0, 8);
            this.buttonSaveOrders.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveOrders.Name = "buttonSaveOrders";
            this.buttonSaveOrders.Size = new System.Drawing.Size(238, 28);
            this.buttonSaveOrders.TabIndex = 1;
            this.buttonSaveOrders.Text = "Сохранить изменения";
            this.buttonSaveOrders.UseVisualStyleBackColor = true;
            this.buttonSaveOrders.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // dataGridViewZakazy
            // 
            this.dataGridViewZakazy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZakazy.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewZakazy.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewZakazy.Name = "dataGridViewZakazy";
            this.dataGridViewZakazy.RowHeadersWidth = 51;
            this.dataGridViewZakazy.Size = new System.Drawing.Size(1037, 514);
            this.dataGridViewZakazy.TabIndex = 0;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.dataGridViewReport1);
            this.tabPageQuery.Controls.Add(this.groupBox1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Size = new System.Drawing.Size(1044, 517);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Отчет1";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewReport1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.RowHeadersWidth = 51;
            this.dataGridViewReport1.Size = new System.Drawing.Size(865, 400);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetReport1);
            this.groupBox1.Controls.Add(this.comboBoxManufReport1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(865, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тут должна быть красота";
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(487, 21);
            this.buttonGetReport1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(100, 24);
            this.buttonGetReport1.TabIndex = 2;
            this.buttonGetReport1.Text = "Найти";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // comboBoxManufReport1
            // 
            this.comboBoxManufReport1.FormattingEnabled = true;
            this.comboBoxManufReport1.Location = new System.Drawing.Point(123, 22);
            this.comboBoxManufReport1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManufReport1.Name = "comboBoxManufReport1";
            this.comboBoxManufReport1.Size = new System.Drawing.Size(356, 24);
            this.comboBoxManufReport1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид мотоцикла";
            // 
            // tabPageSP
            // 
            this.tabPageSP.Controls.Add(this.label3);
            this.tabPageSP.Controls.Add(this.numericUpDown1);
            this.tabPageSP.Controls.Add(this.buttonReport2);
            this.tabPageSP.Controls.Add(this.dataGridViewReport2);
            this.tabPageSP.Controls.Add(this.label2);
            this.tabPageSP.Controls.Add(this.checkedListBox1);
            this.tabPageSP.Location = new System.Drawing.Point(4, 25);
            this.tabPageSP.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSP.Size = new System.Drawing.Size(1044, 517);
            this.tabPageSP.TabIndex = 3;
            this.tabPageSP.Text = "Отчет2";
            this.tabPageSP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наличие";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(291, 18);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(739, 8);
            this.buttonReport2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(72, 38);
            this.buttonReport2.TabIndex = 4;
            this.buttonReport2.Text = "Найти";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewReport2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.RowHeadersWidth = 51;
            this.dataGridViewReport2.Size = new System.Drawing.Size(795, 455);
            this.dataGridViewReport2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите сумму, которая у Вас имеется";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Есть",
            "Нет"});
            this.checkedListBox1.Location = new System.Drawing.Point(550, 8);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(172, 55);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhones.ResumeLayout(false);
            this.tabPagePhones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovary)).EndInit();
            this.tabPagOrders.ResumeLayout(false);
            this.tabPagOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZakazy)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhones;
        private System.Windows.Forms.TabPage tabPagOrders;
        private System.Windows.Forms.DataGridView dataGridViewZakazy;
        private System.Windows.Forms.DataGridView dataGridViewTovary;
        private System.Windows.Forms.Button buttonSavePhone;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.ComboBox comboBoxManufReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonSaveOrders;
        private System.Windows.Forms.TextBox textCatchTovar;
        private System.Windows.Forms.TextBox textCatchZakaz;
        private System.Windows.Forms.Button deleteCathTovar;
        private System.Windows.Forms.Button deleteCathZakaz;
        private System.Windows.Forms.DataGridViewComboBoxColumn Conf_Type;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
    }
}


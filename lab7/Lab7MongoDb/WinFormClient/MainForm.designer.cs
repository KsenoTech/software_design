using System;

namespace Lab4DI
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePhones = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewPhones = new System.Windows.Forms.DataGridView();
            this.bindingSourcePhones = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagOrders = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.comboBoxManufReport1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceManuf = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagePhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhones)).BeginInit();
            this.tabPagOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManuf)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhones);
            this.tabControl1.Controls.Add(this.tabPagOrders);
            this.tabControl1.Controls.Add(this.tabPageQuery);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Location = new System.Drawing.Point(-1, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1322, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePhones
            // 
            this.tabPagePhones.Controls.Add(this.btnDelete);
            this.tabPagePhones.Controls.Add(this.btnUpdate);
            this.tabPagePhones.Controls.Add(this.btnAdd);
            this.tabPagePhones.Controls.Add(this.dataGridViewPhones);
            this.tabPagePhones.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePhones.Name = "tabPagePhones";
            this.tabPagePhones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePhones.Size = new System.Drawing.Size(1314, 517);
            this.tabPagePhones.TabIndex = 0;
            this.tabPagePhones.Text = "Товары";
            this.tabPagePhones.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(467, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 7);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewPhones
            // 
            this.dataGridViewPhones.AutoGenerateColumns = false;
            this.dataGridViewPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerIdDataGridViewTextBoxColumn,
            this.Description});
            this.dataGridViewPhones.DataSource = this.bindingSourcePhones;
            this.dataGridViewPhones.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewPhones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPhones.Name = "dataGridViewPhones";
            this.dataGridViewPhones.RowHeadersWidth = 51;
            this.dataGridViewPhones.Size = new System.Drawing.Size(1306, 469);
            this.dataGridViewPhones.TabIndex = 0;
            // 
            // bindingSourcePhones
            // 
            this.bindingSourcePhones.DataSource = typeof(DTO.PhoneDto);
            // 
            // tabPagOrders
            // 
            this.tabPagOrders.Controls.Add(this.button2);
            this.tabPagOrders.Controls.Add(this.button1);
            this.tabPagOrders.Controls.Add(this.btnMakeOrder);
            this.tabPagOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPagOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPagOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagOrders.Name = "tabPagOrders";
            this.tabPagOrders.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagOrders.Size = new System.Drawing.Size(1314, 517);
            this.tabPagOrders.TabIndex = 1;
            this.tabPagOrders.Text = "Заказы";
            this.tabPagOrders.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnChangeOrder_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(12, 7);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(100, 28);
            this.btnMakeOrder.TabIndex = 2;
            this.btnMakeOrder.Text = "Заказать";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewOrders.DataSource = this.bindingSourceOrders;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1310, 514);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Address";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn10.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OrderedPhones";
            this.dataGridViewTextBoxColumn12.HeaderText = "OrderedPhones";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // bindingSourceOrders
            // 
            this.bindingSourceOrders.DataSource = typeof(DTO.OrderDto);
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.dataGridViewReport1);
            this.tabPageQuery.Controls.Add(this.groupBox1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageQuery.Size = new System.Drawing.Size(1314, 517);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Linq";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewReport1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(865, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(563, 25);
            this.buttonGetReport1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(100, 28);
            this.buttonGetReport1.TabIndex = 2;
            this.buttonGetReport1.Text = "Найти";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // comboBoxManufReport1
            // 
            this.comboBoxManufReport1.FormattingEnabled = true;
            this.comboBoxManufReport1.Location = new System.Drawing.Point(149, 21);
            this.comboBoxManufReport1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель";
            // 
            // tabPageSP
            // 
            this.tabPageSP.Controls.Add(this.numericUpDown2);
            this.tabPageSP.Controls.Add(this.numericUpDown1);
            this.tabPageSP.Controls.Add(this.buttonReport2);
            this.tabPageSP.Controls.Add(this.dataGridViewReport2);
            this.tabPageSP.Controls.Add(this.label3);
            this.tabPageSP.Controls.Add(this.label2);
            this.tabPageSP.Location = new System.Drawing.Point(4, 25);
            this.tabPageSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSP.Size = new System.Drawing.Size(1044, 517);
            this.tabPageSP.TabIndex = 3;
            this.tabPageSP.Text = "Отчет2";
            this.tabPageSP.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(409, 16);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            DateTime.Now.Year,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 18);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(611, 12);
            this.buttonReport2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(119, 28);
            this.buttonReport2.TabIndex = 4;
            this.buttonReport2.Text = "Найти";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(16, 55);
            this.dataGridViewReport2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.RowHeadersWidth = 51;
            this.dataGridViewReport2.Size = new System.Drawing.Size(713, 455);
            this.dataGridViewReport2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Заказы за месяц";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerIdDataGridViewTextBoxColumn
            // 
            this.manufacturerIdDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.HeaderText = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerIdDataGridViewTextBoxColumn.Name = "manufacturerIdDataGridViewTextBoxColumn";
            this.manufacturerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manufacturerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhones)).EndInit();
            this.tabPagOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManuf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhones;
        private System.Windows.Forms.TabPage tabPagOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.BindingSource bindingSourcePhones;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.ComboBox comboBoxManufReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedPhonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Manuf;
        private System.Windows.Forms.BindingSource bindingSourceManuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn manufacturerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}


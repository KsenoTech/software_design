namespace Lab3NLayer
{
    partial class lab5My
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
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewMoto = new System.Windows.Forms.DataGridView();
            this.bindingSourceMoto = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagOrders = new System.Windows.Forms.TabPage();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.dataGridBindingSourceOrder = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedMotosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingSourceTypes = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conf_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.brandnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagePhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMoto)).BeginInit();
            this.tabPagOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBindingSourceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhones);
            this.tabControl1.Controls.Add(this.tabPagOrders);
            this.tabControl1.Controls.Add(this.tabPageQuery);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1343, 546);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePhones
            // 
            this.tabPagePhones.Controls.Add(this.button1);
            this.tabPagePhones.Controls.Add(this.deleteButton);
            this.tabPagePhones.Controls.Add(this.updateButton);
            this.tabPagePhones.Controls.Add(this.addButton);
            this.tabPagePhones.Controls.Add(this.dataGridViewMoto);
            this.tabPagePhones.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhones.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Name = "tabPagePhones";
            this.tabPagePhones.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Size = new System.Drawing.Size(1335, 517);
            this.tabPagePhones.TabIndex = 0;
            this.tabPagePhones.Text = "Мотоциклы";
            this.tabPagePhones.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить табличку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(422, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 29);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(301, 7);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 29);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(189, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewMoto
            // 
            this.dataGridViewMoto.AutoGenerateColumns = false;
            this.dataGridViewMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Conf_Type,
            this.brandnameDataGridViewTextBoxColumn,
            this.modelnameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.idTypeFKDataGridViewTextBoxColumn});
            this.dataGridViewMoto.DataSource = this.bindingSourceMoto;
            this.dataGridViewMoto.Location = new System.Drawing.Point(11, 52);
            this.dataGridViewMoto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMoto.Name = "dataGridViewMoto";
            this.dataGridViewMoto.RowHeadersWidth = 51;
            this.dataGridViewMoto.Size = new System.Drawing.Size(1278, 457);
            this.dataGridViewMoto.TabIndex = 0;
            this.dataGridViewMoto.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMoto_DataError);
            // 
            // bindingSourceMoto
            // 
            this.bindingSourceMoto.DataSource = typeof(DTO.MotoDto);
            // 
            // tabPagOrders
            // 
            this.tabPagOrders.Controls.Add(this.deleteOrderButton);
            this.tabPagOrders.Controls.Add(this.changeOrderButton);
            this.tabPagOrders.Controls.Add(this.createOrderButton);
            this.tabPagOrders.Controls.Add(this.dataGridBindingSourceOrder);
            this.tabPagOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPagOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Name = "tabPagOrders";
            this.tabPagOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Size = new System.Drawing.Size(1335, 517);
            this.tabPagOrders.TabIndex = 1;
            this.tabPagOrders.Text = "Заказ";
            this.tabPagOrders.UseVisualStyleBackColor = true;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(280, 11);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(118, 26);
            this.deleteOrderButton.TabIndex = 7;
            this.deleteOrderButton.Text = "Удалить";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.Location = new System.Drawing.Point(153, 11);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(121, 27);
            this.changeOrderButton.TabIndex = 6;
            this.changeOrderButton.Text = "Редактировать";
            this.changeOrderButton.UseVisualStyleBackColor = true;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(9, 10);
            this.createOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(137, 28);
            this.createOrderButton.TabIndex = 5;
            this.createOrderButton.Text = "Создать заказ";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click_1);
            // 
            // dataGridBindingSourceOrder
            // 
            this.dataGridBindingSourceOrder.AutoGenerateColumns = false;
            this.dataGridBindingSourceOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBindingSourceOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.orderedMotosDataGridViewTextBoxColumn});
            this.dataGridBindingSourceOrder.DataSource = this.bindingSourceOrders;
            this.dataGridBindingSourceOrder.Location = new System.Drawing.Point(0, 44);
            this.dataGridBindingSourceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBindingSourceOrder.Name = "dataGridBindingSourceOrder";
            this.dataGridBindingSourceOrder.RowHeadersWidth = 51;
            this.dataGridBindingSourceOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBindingSourceOrder.Size = new System.Drawing.Size(1286, 446);
            this.dataGridBindingSourceOrder.TabIndex = 0;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderedMotosDataGridViewTextBoxColumn
            // 
            this.orderedMotosDataGridViewTextBoxColumn.DataPropertyName = "OrderedMotos";
            this.orderedMotosDataGridViewTextBoxColumn.HeaderText = "OrderedMotos";
            this.orderedMotosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedMotosDataGridViewTextBoxColumn.Name = "orderedMotosDataGridViewTextBoxColumn";
            this.orderedMotosDataGridViewTextBoxColumn.Width = 125;
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
            this.tabPageQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Size = new System.Drawing.Size(1335, 517);
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
            this.tabPageSP.Size = new System.Drawing.Size(1335, 517);
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
            // bindingSourceTypes
            // 
            this.bindingSourceTypes.DataSource = typeof(DTO.TypeDto);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
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
            // brandnameDataGridViewTextBoxColumn
            // 
            this.brandnameDataGridViewTextBoxColumn.DataPropertyName = "Brand_name";
            this.brandnameDataGridViewTextBoxColumn.HeaderText = "Brand_name";
            this.brandnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandnameDataGridViewTextBoxColumn.Name = "brandnameDataGridViewTextBoxColumn";
            this.brandnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelnameDataGridViewTextBoxColumn
            // 
            this.modelnameDataGridViewTextBoxColumn.DataPropertyName = "Model_name";
            this.modelnameDataGridViewTextBoxColumn.HeaderText = "Model_name";
            this.modelnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelnameDataGridViewTextBoxColumn.Name = "modelnameDataGridViewTextBoxColumn";
            this.modelnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTypeFKDataGridViewTextBoxColumn
            // 
            this.idTypeFKDataGridViewTextBoxColumn.DataPropertyName = "id_Type_FK";
            this.idTypeFKDataGridViewTextBoxColumn.HeaderText = "id_Type_FK";
            this.idTypeFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTypeFKDataGridViewTextBoxColumn.Name = "idTypeFKDataGridViewTextBoxColumn";
            this.idTypeFKDataGridViewTextBoxColumn.Visible = false;
            this.idTypeFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // lab5My
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "lab5My";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMoto)).EndInit();
            this.tabPagOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBindingSourceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhones;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridViewMoto;
        private System.Windows.Forms.TabPage tabPagOrders;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.ComboBox comboBoxManufReport1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingSource bindingSourceMoto;
        private System.Windows.Forms.BindingSource bindingSourceTypes;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.DataGridView dataGridBindingSourceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedMotosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotorcycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Conf_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeFKDataGridViewTextBoxColumn;
    }
}


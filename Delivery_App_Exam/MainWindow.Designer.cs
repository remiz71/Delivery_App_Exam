namespace Delivery_App_Exam
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDBDataSet = new Delivery_App_Exam.DeliveryDBDataSet();
            this.orderSetTableAdapter = new Delivery_App_Exam.DeliveryDBDataSetTableAdapters.OrderSetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveLicenseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licenseCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrierSetTableAdapter = new Delivery_App_Exam.DeliveryDBDataSetTableAdapters.CarrierSetTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.orderStatusSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderStatusSetTableAdapter = new Delivery_App_Exam.DeliveryDBDataSetTableAdapters.OrderStatusSetTableAdapter();
            this.carrierSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKCarrierOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCarrierOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deliveryAdressDataGridViewTextBoxColumn,
            this.orderDescriptionDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryCostDataGridViewTextBoxColumn,
            this.carrierIdDataGridViewTextBoxColumn,
            this.orderStatusIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderSetBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(18, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderSetBindingSource
            // 
            this.orderSetBindingSource.DataMember = "OrderSet";
            this.orderSetBindingSource.DataSource = this.deliveryDBDataSet;
            // 
            // deliveryDBDataSet
            // 
            this.deliveryDBDataSet.DataSetName = "DeliveryDBDataSet";
            this.deliveryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderSetTableAdapter
            // 
            this.orderSetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить доставщика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Посмотреть список доставщиков";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.haveLicenseDataGridViewCheckBoxColumn,
            this.licenseCategoryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.carrierSetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(421, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 232);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // haveLicenseDataGridViewCheckBoxColumn
            // 
            this.haveLicenseDataGridViewCheckBoxColumn.DataPropertyName = "HaveLicense";
            this.haveLicenseDataGridViewCheckBoxColumn.HeaderText = "HaveLicense";
            this.haveLicenseDataGridViewCheckBoxColumn.Name = "haveLicenseDataGridViewCheckBoxColumn";
            this.haveLicenseDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // licenseCategoryDataGridViewTextBoxColumn
            // 
            this.licenseCategoryDataGridViewTextBoxColumn.DataPropertyName = "LicenseCategory";
            this.licenseCategoryDataGridViewTextBoxColumn.HeaderText = "LicenseCategory";
            this.licenseCategoryDataGridViewTextBoxColumn.Name = "licenseCategoryDataGridViewTextBoxColumn";
            this.licenseCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrierSetBindingSource
            // 
            this.carrierSetBindingSource.DataMember = "CarrierSet";
            this.carrierSetBindingSource.DataSource = this.deliveryDBDataSet;
            // 
            // carrierSetTableAdapter
            // 
            this.carrierSetTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "Показать заказы по статусу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Получено",
            "Доставляется",
            "Доставлено",
            "Отказ/Возврат",
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(218, 518);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 56);
            this.button6.TabIndex = 9;
            this.button6.Text = "Обновить форму\\";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // orderStatusSetBindingSource
            // 
            this.orderStatusSetBindingSource.DataMember = "OrderStatusSet";
            this.orderStatusSetBindingSource.DataSource = this.deliveryDBDataSet;
            // 
            // orderStatusSetTableAdapter
            // 
            this.orderStatusSetTableAdapter.ClearBeforeFill = true;
            // 
            // carrierSetBindingSource1
            // 
            this.carrierSetBindingSource1.DataMember = "CarrierSet";
            this.carrierSetBindingSource1.DataSource = this.deliveryDBDataSet;
            // 
            // fKCarrierOrderBindingSource
            // 
            this.fKCarrierOrderBindingSource.DataMember = "FK_CarrierOrder";
            this.fKCarrierOrderBindingSource.DataSource = this.carrierSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryAdressDataGridViewTextBoxColumn
            // 
            this.deliveryAdressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAdress";
            this.deliveryAdressDataGridViewTextBoxColumn.Frozen = true;
            this.deliveryAdressDataGridViewTextBoxColumn.HeaderText = "Адрес доставки";
            this.deliveryAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryAdressDataGridViewTextBoxColumn.Name = "deliveryAdressDataGridViewTextBoxColumn";
            this.deliveryAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDescriptionDataGridViewTextBoxColumn
            // 
            this.orderDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OrderDescription";
            this.orderDescriptionDataGridViewTextBoxColumn.Frozen = true;
            this.orderDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание заказа";
            this.orderDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDescriptionDataGridViewTextBoxColumn.Name = "orderDescriptionDataGridViewTextBoxColumn";
            this.orderDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Frozen = true;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryCostDataGridViewTextBoxColumn
            // 
            this.deliveryCostDataGridViewTextBoxColumn.DataPropertyName = "DeliveryCost";
            this.deliveryCostDataGridViewTextBoxColumn.Frozen = true;
            this.deliveryCostDataGridViewTextBoxColumn.HeaderText = "Стоимость доставки";
            this.deliveryCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryCostDataGridViewTextBoxColumn.Name = "deliveryCostDataGridViewTextBoxColumn";
            this.deliveryCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrierIdDataGridViewTextBoxColumn
            // 
            this.carrierIdDataGridViewTextBoxColumn.DataPropertyName = "CarrierId";
            this.carrierIdDataGridViewTextBoxColumn.Frozen = true;
            this.carrierIdDataGridViewTextBoxColumn.HeaderText = "Доставщик";
            this.carrierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrierIdDataGridViewTextBoxColumn.Name = "carrierIdDataGridViewTextBoxColumn";
            this.carrierIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carrierIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusIdDataGridViewTextBoxColumn
            // 
            this.orderStatusIdDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus_Id";
            this.orderStatusIdDataGridViewTextBoxColumn.DataSource = this.orderStatusSetBindingSource;
            this.orderStatusIdDataGridViewTextBoxColumn.DisplayMember = "Status";
            this.orderStatusIdDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
            this.orderStatusIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusIdDataGridViewTextBoxColumn.Name = "orderStatusIdDataGridViewTextBoxColumn";
            this.orderStatusIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderStatusIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderStatusIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.orderStatusIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 565);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCarrierOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DeliveryDBDataSet deliveryDBDataSet;
        private System.Windows.Forms.BindingSource orderSetBindingSource;
        private DeliveryDBDataSetTableAdapters.OrderSetTableAdapter orderSetTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource carrierSetBindingSource;
        private DeliveryDBDataSetTableAdapters.CarrierSetTableAdapter carrierSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn haveLicenseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource orderStatusSetBindingSource;
        private DeliveryDBDataSetTableAdapters.OrderStatusSetTableAdapter orderStatusSetTableAdapter;
        private System.Windows.Forms.BindingSource carrierSetBindingSource1;
        private System.Windows.Forms.BindingSource fKCarrierOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderStatusIdDataGridViewTextBoxColumn;
    }
}


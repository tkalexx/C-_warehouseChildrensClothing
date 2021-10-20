namespace wareHouse
{
    partial class FormFull
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clients = new System.Windows.Forms.TabPage();
            this.grid_clients = new System.Windows.Forms.DataGridView();
            this.employees = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editEmpl = new System.Windows.Forms.Button();
            this.btn_addEmployees = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_employees = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_editT = new System.Windows.Forms.Button();
            this.btn_addT = new System.Windows.Forms.Button();
            this.btn_delT = new System.Windows.Forms.Button();
            this.grid_product = new System.Windows.Forms.DataGridView();
            this.sales = new System.Windows.Forms.TabPage();
            this.grid_sell = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.grid_postav = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.grid_pt = new System.Windows.Forms.DataGridView();
            this.report = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_summEmpl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tx_box_s = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.TabPage();
            this.filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.param = new System.Windows.Forms.TextBox();
            this.box_param = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.box_str = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_table = new System.Windows.Forms.ComboBox();
            this.grid_poisk = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).BeginInit();
            this.employees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).BeginInit();
            this.product.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_postav)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pt)).BeginInit();
            this.report.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.scan.SuspendLayout();
            this.filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_poisk)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clients);
            this.tabControl1.Controls.Add(this.employees);
            this.tabControl1.Controls.Add(this.product);
            this.tabControl1.Controls.Add(this.sales);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.report);
            this.tabControl1.Controls.Add(this.scan);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // clients
            // 
            this.clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clients.Controls.Add(this.grid_clients);
            this.clients.Location = new System.Drawing.Point(4, 22);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(490, 345);
            this.clients.TabIndex = 2;
            this.clients.Text = "Клиенты";
            // 
            // grid_clients
            // 
            this.grid_clients.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_clients.Location = new System.Drawing.Point(5, 3);
            this.grid_clients.Name = "grid_clients";
            this.grid_clients.Size = new System.Drawing.Size(478, 339);
            this.grid_clients.TabIndex = 0;
            this.grid_clients.Text = "dataGridView1";
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.employees.Controls.Add(this.groupBox1);
            this.employees.Controls.Add(this.grid_employees);
            this.employees.Location = new System.Drawing.Point(4, 22);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(490, 345);
            this.employees.TabIndex = 3;
            this.employees.Text = "Сотрудники";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.editEmpl);
            this.groupBox1.Controls.Add(this.btn_addEmployees);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление сотрудниками";
            // 
            // editEmpl
            // 
            this.editEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editEmpl.Location = new System.Drawing.Point(116, 55);
            this.editEmpl.Name = "editEmpl";
            this.editEmpl.Size = new System.Drawing.Size(189, 38);
            this.editEmpl.TabIndex = 3;
            this.editEmpl.Text = "Редактировать данные сотрудника";
            this.editEmpl.UseVisualStyleBackColor = false;
            this.editEmpl.Click += new System.EventHandler(this.editEmpl_Click);
            // 
            // btn_addEmployees
            // 
            this.btn_addEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addEmployees.Location = new System.Drawing.Point(6, 19);
            this.btn_addEmployees.Name = "btn_addEmployees";
            this.btn_addEmployees.Size = new System.Drawing.Size(189, 30);
            this.btn_addEmployees.TabIndex = 1;
            this.btn_addEmployees.Text = "Добавить сотрудника";
            this.btn_addEmployees.UseVisualStyleBackColor = false;
            this.btn_addEmployees.Click += new System.EventHandler(this.btn_addEmployees_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(222, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Уволить сотрудника";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_employees
            // 
            this.grid_employees.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_employees.Location = new System.Drawing.Point(6, 3);
            this.grid_employees.Name = "grid_employees";
            this.grid_employees.Size = new System.Drawing.Size(477, 234);
            this.grid_employees.TabIndex = 0;
            this.grid_employees.Text = "dataGridView1";
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.product.Controls.Add(this.groupBox3);
            this.product.Controls.Add(this.grid_product);
            this.product.Location = new System.Drawing.Point(4, 22);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(490, 345);
            this.product.TabIndex = 1;
            this.product.Text = "Товар";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btn_editT);
            this.groupBox3.Controls.Add(this.btn_addT);
            this.groupBox3.Controls.Add(this.btn_delT);
            this.groupBox3.Location = new System.Drawing.Point(6, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 99);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление товарами";
            // 
            // btn_editT
            // 
            this.btn_editT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editT.Location = new System.Drawing.Point(116, 55);
            this.btn_editT.Name = "btn_editT";
            this.btn_editT.Size = new System.Drawing.Size(189, 38);
            this.btn_editT.TabIndex = 3;
            this.btn_editT.Text = "Редактировать данные товара";
            this.btn_editT.UseVisualStyleBackColor = false;
            this.btn_editT.Click += new System.EventHandler(this.btn_editT_Click);
            // 
            // btn_addT
            // 
            this.btn_addT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addT.Location = new System.Drawing.Point(6, 19);
            this.btn_addT.Name = "btn_addT";
            this.btn_addT.Size = new System.Drawing.Size(189, 30);
            this.btn_addT.TabIndex = 1;
            this.btn_addT.Text = "Добавить товар";
            this.btn_addT.UseVisualStyleBackColor = false;
            this.btn_addT.Click += new System.EventHandler(this.btn_addT_Click);
            // 
            // btn_delT
            // 
            this.btn_delT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delT.Location = new System.Drawing.Point(222, 19);
            this.btn_delT.Name = "btn_delT";
            this.btn_delT.Size = new System.Drawing.Size(189, 30);
            this.btn_delT.TabIndex = 2;
            this.btn_delT.Text = "Удалить товар";
            this.btn_delT.UseVisualStyleBackColor = false;
            this.btn_delT.Click += new System.EventHandler(this.btn_delT_Click);
            // 
            // grid_product
            // 
            this.grid_product.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_product.Location = new System.Drawing.Point(3, 3);
            this.grid_product.Name = "grid_product";
            this.grid_product.Size = new System.Drawing.Size(484, 231);
            this.grid_product.TabIndex = 0;
            this.grid_product.Text = "dataGridView1";
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sales.Controls.Add(this.grid_sell);
            this.sales.Location = new System.Drawing.Point(4, 22);
            this.sales.Name = "sales";
            this.sales.Padding = new System.Windows.Forms.Padding(3);
            this.sales.Size = new System.Drawing.Size(490, 345);
            this.sales.TabIndex = 0;
            this.sales.Text = "Заказы";
            // 
            // grid_sell
            // 
            this.grid_sell.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sell.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_sell.Location = new System.Drawing.Point(3, 3);
            this.grid_sell.Name = "grid_sell";
            this.grid_sell.Size = new System.Drawing.Size(480, 336);
            this.grid_sell.TabIndex = 0;
            this.grid_sell.Text = "dataGridView1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.grid_postav);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(490, 345);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Поставки";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(3, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 99);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление поставками";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(116, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "Редактировать данные поставки";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 30);
            this.button6.TabIndex = 1;
            this.button6.Text = "Добавить поставку";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(222, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = "Удалить поставку";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // grid_postav
            // 
            this.grid_postav.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_postav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_postav.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_postav.Location = new System.Drawing.Point(3, 3);
            this.grid_postav.Name = "grid_postav";
            this.grid_postav.Size = new System.Drawing.Size(480, 234);
            this.grid_postav.TabIndex = 5;
            this.grid_postav.Text = "dataGridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.grid_pt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(490, 345);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Поставщики";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Location = new System.Drawing.Point(7, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 99);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление поставщиками";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(116, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(198, 38);
            this.button8.TabIndex = 3;
            this.button8.Text = "Редактировать данные поставщика";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(6, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(189, 30);
            this.button9.TabIndex = 1;
            this.button9.Text = "Добавить поставщика";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button10.Location = new System.Drawing.Point(222, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(189, 30);
            this.button10.TabIndex = 2;
            this.button10.Text = "Удалить поставщика";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // grid_pt
            // 
            this.grid_pt.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_pt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pt.Location = new System.Drawing.Point(7, 4);
            this.grid_pt.Name = "grid_pt";
            this.grid_pt.Size = new System.Drawing.Size(476, 233);
            this.grid_pt.TabIndex = 0;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.report.Controls.Add(this.groupBox2);
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(490, 345);
            this.report.TabIndex = 4;
            this.report.Text = "Отчеты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 339);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btn_summEmpl);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.tx_box_s);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(302, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 202);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Отчетная группа";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "Открыть отчет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_summEmpl
            // 
            this.btn_summEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_summEmpl.Location = new System.Drawing.Point(7, 49);
            this.btn_summEmpl.Name = "btn_summEmpl";
            this.btn_summEmpl.Size = new System.Drawing.Size(119, 26);
            this.btn_summEmpl.TabIndex = 0;
            this.btn_summEmpl.Text = "Открыть отчет";
            this.btn_summEmpl.UseVisualStyleBackColor = false;
            this.btn_summEmpl.Click += new System.EventHandler(this.btn_summEmpl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Общая сумма продаж";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(28, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tx_box_s
            // 
            this.tx_box_s.Location = new System.Drawing.Point(43, 150);
            this.tx_box_s.Name = "tx_box_s";
            this.tx_box_s.Size = new System.Drawing.Size(86, 20);
            this.tx_box_s.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сумма продаж по сотрудникам:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Количество поставщиков ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "по:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "с:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(302, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(317, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 301);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Получить информацию о заказах за определенную дату:";
            // 
            // scan
            // 
            this.scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.scan.Controls.Add(this.filter);
            this.scan.Controls.Add(this.grid_poisk);
            this.scan.Location = new System.Drawing.Point(4, 22);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(490, 345);
            this.scan.TabIndex = 6;
            this.scan.Text = "Поиск";
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filter.Controls.Add(this.label2);
            this.filter.Controls.Add(this.param);
            this.filter.Controls.Add(this.box_param);
            this.filter.Controls.Add(this.btn_enter);
            this.filter.Controls.Add(this.name);
            this.filter.Controls.Add(this.box_str);
            this.filter.Controls.Add(this.label1);
            this.filter.Controls.Add(this.box_table);
            this.filter.Location = new System.Drawing.Point(0, 3);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(487, 116);
            this.filter.TabIndex = 3;
            this.filter.TabStop = false;
            this.filter.Text = "Фильтр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Условие отбора";
            // 
            // param
            // 
            this.param.Location = new System.Drawing.Point(159, 90);
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(125, 20);
            this.param.TabIndex = 5;
            // 
            // box_param
            // 
            this.box_param.FormattingEnabled = true;
            this.box_param.Items.AddRange(new object[] {
            "Like",
            "<",
            ">",
            "="});
            this.box_param.Location = new System.Drawing.Point(3, 89);
            this.box_param.Name = "box_param";
            this.box_param.Size = new System.Drawing.Size(125, 21);
            this.box_param.TabIndex = 4;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enter.Location = new System.Drawing.Point(316, 56);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(106, 30);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Применить";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(0, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Выберите таблицу";
            // 
            // box_str
            // 
            this.box_str.FormattingEnabled = true;
            this.box_str.Location = new System.Drawing.Point(159, 41);
            this.box_str.Name = "box_str";
            this.box_str.Size = new System.Drawing.Size(125, 21);
            this.box_str.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Параметр";
            // 
            // box_table
            // 
            this.box_table.FormattingEnabled = true;
            this.box_table.Items.AddRange(new object[] {
            "Клиенты",
            "Сотрудники",
            "Товар"});
            this.box_table.Location = new System.Drawing.Point(3, 41);
            this.box_table.Name = "box_table";
            this.box_table.Size = new System.Drawing.Size(125, 21);
            this.box_table.TabIndex = 1;
            this.box_table.SelectedIndexChanged += new System.EventHandler(this.box_table_SelectedIndexChanged);
            this.box_table.SelectedValueChanged += new System.EventHandler(this.box_table_SelectedValueChanged);
            // 
            // grid_poisk
            // 
            this.grid_poisk.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_poisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_poisk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_poisk.Location = new System.Drawing.Point(3, 125);
            this.grid_poisk.Name = "grid_poisk";
            this.grid_poisk.Size = new System.Drawing.Size(484, 217);
            this.grid_poisk.TabIndex = 0;
            this.grid_poisk.Text = "dataGridView1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сумма продаж каждого работника";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(2, 389);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 28);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "по товарам:";
            // 
            // FormFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(501, 417);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormFull";
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.FormFull_Load);
            this.tabControl1.ResumeLayout(false);
            this.clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).EndInit();
            this.employees.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).EndInit();
            this.product.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.sales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_postav)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pt)).EndInit();
            this.report.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.scan.ResumeLayout(false);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_poisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clients;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.TabPage sales;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.DataGridView grid_clients;
        private System.Windows.Forms.DataGridView grid_product;
        private System.Windows.Forms.Button btn_addEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editEmpl;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.DataGridView grid_sell;
        private System.Windows.Forms.TabPage scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_str;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox box_table;
        private System.Windows.Forms.DataGridView grid_poisk;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox param;
        private System.Windows.Forms.ComboBox box_param;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView grid_employees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_summEmpl;
        private System.Windows.Forms.TextBox tx_box_s;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_editT;
        private System.Windows.Forms.Button btn_addT;
        private System.Windows.Forms.Button btn_delT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView grid_postav;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView grid_pt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
    }
}
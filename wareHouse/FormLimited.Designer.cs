﻿namespace wareHouse
{
    partial class FormLimited
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
            this.grid_prod = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FL_btn_use = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FL_param = new System.Windows.Forms.TextBox();
            this.FL_box_usl = new System.Windows.Forms.ComboBox();
            this.FL_box_param = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.grid_clients = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LM_tb = new System.Windows.Forms.TextBox();
            this.LM_bx_otb = new System.Windows.Forms.ComboBox();
            this.LM_bx_param = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_12 = new System.Windows.Forms.Button();
            this.grid_nkldn = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grid_sell = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nkldn)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_prod
            // 
            this.grid_prod.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_prod.Location = new System.Drawing.Point(7, 27);
            this.grid_prod.Name = "grid_prod";
            this.grid_prod.Size = new System.Drawing.Size(280, 208);
            this.grid_prod.TabIndex = 0;
            this.grid_prod.Text = "dataGridView1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(162, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите товар:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.FL_btn_use);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FL_param);
            this.groupBox1.Controls.Add(this.FL_box_usl);
            this.groupBox1.Controls.Add(this.FL_box_param);
            this.groupBox1.Location = new System.Drawing.Point(293, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // FL_btn_use
            // 
            this.FL_btn_use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FL_btn_use.Location = new System.Drawing.Point(62, 123);
            this.FL_btn_use.Name = "FL_btn_use";
            this.FL_btn_use.Size = new System.Drawing.Size(105, 28);
            this.FL_btn_use.TabIndex = 5;
            this.FL_btn_use.Text = "Применить";
            this.FL_btn_use.UseVisualStyleBackColor = false;
            this.FL_btn_use.Click += new System.EventHandler(this.FL_btn_use_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Параметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Условие отбора";
            // 
            // FL_param
            // 
            this.FL_param.Location = new System.Drawing.Point(115, 84);
            this.FL_param.Name = "FL_param";
            this.FL_param.Size = new System.Drawing.Size(119, 20);
            this.FL_param.TabIndex = 2;
            // 
            // FL_box_usl
            // 
            this.FL_box_usl.FormattingEnabled = true;
            this.FL_box_usl.Items.AddRange(new object[] {
            "Like",
            "=",
            ">",
            "<"});
            this.FL_box_usl.Location = new System.Drawing.Point(5, 84);
            this.FL_box_usl.Name = "FL_box_usl";
            this.FL_box_usl.Size = new System.Drawing.Size(104, 21);
            this.FL_box_usl.TabIndex = 1;
            // 
            // FL_box_param
            // 
            this.FL_box_param.FormattingEnabled = true;
            this.FL_box_param.Location = new System.Drawing.Point(5, 42);
            this.FL_box_param.Name = "FL_box_param";
            this.FL_box_param.Size = new System.Drawing.Size(104, 21);
            this.FL_box_param.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.Location = new System.Drawing.Point(391, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 28);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Оформить заказ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grid_clients
            // 
            this.grid_clients.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clients.Location = new System.Drawing.Point(6, 273);
            this.grid_clients.Name = "grid_clients";
            this.grid_clients.Size = new System.Drawing.Size(280, 186);
            this.grid_clients.TabIndex = 9;
            this.grid_clients.Text = "dataGridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.LM_tb);
            this.groupBox2.Controls.Add(this.LM_bx_otb);
            this.groupBox2.Controls.Add(this.LM_bx_param);
            this.groupBox2.Location = new System.Drawing.Point(293, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 186);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Условие отбора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Параметр";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(62, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LM_tb
            // 
            this.LM_tb.Location = new System.Drawing.Point(115, 83);
            this.LM_tb.Name = "LM_tb";
            this.LM_tb.Size = new System.Drawing.Size(119, 20);
            this.LM_tb.TabIndex = 2;
            // 
            // LM_bx_otb
            // 
            this.LM_bx_otb.FormattingEnabled = true;
            this.LM_bx_otb.Items.AddRange(new object[] {
            "Like",
            ">",
            "<",
            "="});
            this.LM_bx_otb.Location = new System.Drawing.Point(5, 82);
            this.LM_bx_otb.Name = "LM_bx_otb";
            this.LM_bx_otb.Size = new System.Drawing.Size(104, 21);
            this.LM_bx_otb.TabIndex = 1;
            // 
            // LM_bx_param
            // 
            this.LM_bx_param.FormattingEnabled = true;
            this.LM_bx_param.Location = new System.Drawing.Point(6, 42);
            this.LM_bx_param.Name = "LM_bx_param";
            this.LM_bx_param.Size = new System.Drawing.Size(104, 21);
            this.LM_bx_param.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(162, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите клиента:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 534);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.grid_prod);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grid_clients);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оформление заказа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(214, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Добавить клиента";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_12);
            this.tabPage2.Controls.Add(this.grid_nkldn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Накладные";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.btn_provodka_Click);
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_12.Location = new System.Drawing.Point(186, 475);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(157, 23);
            this.btn_12.TabIndex = 2;
            this.btn_12.Text = "Провести накладные";
            this.btn_12.UseVisualStyleBackColor = false;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // grid_nkldn
            // 
            this.grid_nkldn.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_nkldn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nkldn.Location = new System.Drawing.Point(3, 6);
            this.grid_nkldn.Name = "grid_nkldn";
            this.grid_nkldn.Size = new System.Drawing.Size(547, 462);
            this.grid_nkldn.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grid_sell);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(556, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grid_sell
            // 
            this.grid_sell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sell.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grid_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sell.Location = new System.Drawing.Point(3, 3);
            this.grid_sell.Name = "grid_sell";
            this.grid_sell.Size = new System.Drawing.Size(550, 468);
            this.grid_sell.TabIndex = 12;
            // 
            // FormLimited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(587, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLimited";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.FormLimited_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_nkldn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FL_box_param;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FL_param;
        private System.Windows.Forms.ComboBox FL_box_usl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FL_btn_use;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.DataGridView grid_prod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LM_tb;
        private System.Windows.Forms.ComboBox LM_bx_otb;
        private System.Windows.Forms.ComboBox LM_bx_param;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView grid_clients;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grid_nkldn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView grid_sell;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_12;
    }
}
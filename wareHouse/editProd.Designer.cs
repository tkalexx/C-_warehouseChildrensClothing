
namespace wareHouse
{
    partial class editProd
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name_t = new System.Windows.Forms.TextBox();
            this.sal_t = new System.Windows.Forms.TextBox();
            this.cou_t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Наименование товара";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Наличие";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(12, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Location = new System.Drawing.Point(169, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // name_t
            // 
            this.name_t.Location = new System.Drawing.Point(20, 39);
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(238, 20);
            this.name_t.TabIndex = 14;
            // 
            // sal_t
            // 
            this.sal_t.Location = new System.Drawing.Point(20, 87);
            this.sal_t.Name = "sal_t";
            this.sal_t.Size = new System.Drawing.Size(238, 20);
            this.sal_t.TabIndex = 15;
            // 
            // cou_t
            // 
            this.cou_t.Location = new System.Drawing.Point(20, 133);
            this.cou_t.Name = "cou_t";
            this.cou_t.Size = new System.Drawing.Size(238, 20);
            this.cou_t.TabIndex = 16;
            // 
            // editProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(309, 222);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_t);
            this.Controls.Add(this.sal_t);
            this.Controls.Add(this.cou_t);
            this.Name = "editProd";
            this.Text = "Редактировать данные о товаре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox name_t;
        public System.Windows.Forms.TextBox sal_t;
        public System.Windows.Forms.TextBox cou_t;
    }
}
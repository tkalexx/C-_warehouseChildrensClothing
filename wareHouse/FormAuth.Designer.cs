namespace wareHouse
{
    partial class FormAuth
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
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войти в систему";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log.ForeColor = System.Drawing.SystemColors.Desktop;
            this.log.Location = new System.Drawing.Point(83, 90);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(136, 20);
            this.log.TabIndex = 0;
            this.log.UseWaitCursor = true;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pass.Location = new System.Drawing.Point(83, 116);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(136, 20);
            this.pass.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Red;
            this.Input.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Input.FlatAppearance.BorderSize = 5;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.ForeColor = System.Drawing.SystemColors.Info;
            this.Input.Location = new System.Drawing.Point(96, 142);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(111, 34);
            this.Input.TabIndex = 5;
            this.Input.Text = "Вход";
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(272, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.log);
            this.Name = "FormAuth";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
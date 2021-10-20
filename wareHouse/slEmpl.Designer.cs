
namespace wareHouse
{
    partial class slEmpl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.wareHouseDataSet = new wareHouse.wareHouseDataSet();
            this.slEmplBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slEmplTableAdapter = new wareHouse.wareHouseDataSetTableAdapters.slEmplTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slEmplBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.slEmplBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wareHouse.slEmpl.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "wareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slEmplBindingSource
            // 
            this.slEmplBindingSource.DataMember = "slEmpl";
            this.slEmplBindingSource.DataSource = this.wareHouseDataSet;
            // 
            // slEmplTableAdapter
            // 
            this.slEmplTableAdapter.ClearBeforeFill = true;
            // 
            // slEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 252);
            this.Controls.Add(this.reportViewer1);
            this.Name = "slEmpl";
            this.Text = "Отчет: сумма продаж каждого сотрудника";
            this.Load += new System.EventHandler(this.slEmpl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slEmplBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource slEmplBindingSource;
        private wareHouseDataSet wareHouseDataSet;
        private wareHouseDataSetTableAdapters.slEmplTableAdapter slEmplTableAdapter;
    }
}

namespace wareHouse
{
    partial class CountProd
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.wareHouseDataSet1 = new wareHouse.wareHouseDataSet1();
            this.CountProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountProdTableAdapter = new wareHouse.wareHouseDataSet1TableAdapters.CountProdTableAdapter();
            this.wareHouseDataSet2 = new wareHouse.wareHouseDataSet2();
            this.CountProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountProductTableAdapter = new wareHouse.wareHouseDataSet2TableAdapters.CountProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CountProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wareHouse.CountProductF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(641, 271);
            this.reportViewer1.TabIndex = 0;
            // 
            // wareHouseDataSet1
            // 
            this.wareHouseDataSet1.DataSetName = "wareHouseDataSet1";
            this.wareHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CountProdBindingSource
            // 
            this.CountProdBindingSource.DataMember = "CountProd";
            this.CountProdBindingSource.DataSource = this.wareHouseDataSet1;
            // 
            // CountProdTableAdapter
            // 
            this.CountProdTableAdapter.ClearBeforeFill = true;
            // 
            // wareHouseDataSet2
            // 
            this.wareHouseDataSet2.DataSetName = "wareHouseDataSet2";
            this.wareHouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CountProductBindingSource
            // 
            this.CountProductBindingSource.DataMember = "CountProduct";
            this.CountProductBindingSource.DataSource = this.wareHouseDataSet2;
            // 
            // CountProductTableAdapter
            // 
            this.CountProductTableAdapter.ClearBeforeFill = true;
            // 
            // CountProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 281);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CountProd";
            this.Text = "Отчет: Количество поставщиков по товарам";
            this.Load += new System.EventHandler(this.CountProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CountProdBindingSource;
        private wareHouseDataSet1 wareHouseDataSet1;
        private wareHouseDataSet1TableAdapters.CountProdTableAdapter CountProdTableAdapter;
        private System.Windows.Forms.BindingSource CountProductBindingSource;
        private wareHouseDataSet2 wareHouseDataSet2;
        private wareHouseDataSet2TableAdapters.CountProductTableAdapter CountProductTableAdapter;
    }
}
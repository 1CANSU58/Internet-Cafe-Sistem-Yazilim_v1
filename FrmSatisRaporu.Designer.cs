﻿namespace InternetCafeSistem
{
    partial class FrmSatisRaporu
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
            this.InternetCafeDataSet = new InternetCafeSistem.InternetCafeDataSet();
            this.TBLSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBLSatisTableAdapter = new InternetCafeSistem.InternetCafeDataSetTableAdapters.TBLSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBLSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InternetCafeSistem.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // InternetCafeDataSet
            // 
            this.InternetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.InternetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBLSatisBindingSource
            // 
            this.TBLSatisBindingSource.DataMember = "TBLSatis";
            this.TBLSatisBindingSource.DataSource = this.InternetCafeDataSet;
            // 
            // TBLSatisTableAdapter
            // 
            this.TBLSatisTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatisRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Raporu";
            this.Load += new System.EventHandler(this.FrmSatisRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLSatisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBLSatisBindingSource;
        private InternetCafeDataSet InternetCafeDataSet;
        private InternetCafeDataSetTableAdapters.TBLSatisTableAdapter TBLSatisTableAdapter;
    }
}
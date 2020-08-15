namespace CoffeeHomeMake
{
    partial class mgReportPerDay
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
            this.USP_ReportPerDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoffeeHomeMakeDataSet = new CoffeeHomeMake.CoffeeHomeMakeDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_PickDay = new System.Windows.Forms.DateTimePicker();
            this.btn_Report = new System.Windows.Forms.Button();
            this.rp_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_ReportPerDayTableAdapter = new CoffeeHomeMake.CoffeeHomeMakeDataSetTableAdapters.USP_ReportPerDayTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPerDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeMakeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_ReportPerDayBindingSource
            // 
            this.USP_ReportPerDayBindingSource.DataMember = "USP_ReportPerDay";
            this.USP_ReportPerDayBindingSource.DataSource = this.CoffeeHomeMakeDataSet;
            // 
            // CoffeeHomeMakeDataSet
            // 
            this.CoffeeHomeMakeDataSet.DataSetName = "CoffeeHomeMakeDataSet";
            this.CoffeeHomeMakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_PickDay
            // 
            this.dtp_PickDay.CalendarFont = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PickDay.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PickDay.Location = new System.Drawing.Point(114, 41);
            this.dtp_PickDay.Name = "dtp_PickDay";
            this.dtp_PickDay.Size = new System.Drawing.Size(385, 24);
            this.dtp_PickDay.TabIndex = 6;
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(114, 81);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(162, 62);
            this.btn_Report.TabIndex = 5;
            this.btn_Report.Text = "TẠO BÁO CÁO";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // rp_Report
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_ReportPerDayBindingSource;
            this.rp_Report.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_Report.LocalReport.ReportEmbeddedResource = "CoffeeHomeMake.Report1.rdlc";
            this.rp_Report.Location = new System.Drawing.Point(38, 204);
            this.rp_Report.Name = "rp_Report";
            this.rp_Report.Size = new System.Drawing.Size(632, 414);
            this.rp_Report.TabIndex = 8;
            // 
            // USP_ReportPerDayTableAdapter
            // 
            this.USP_ReportPerDayTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Report);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtp_PickDay);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo ";
            // 
            // mgReportPerDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(710, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rp_Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(730, 691);
            this.MinimumSize = new System.Drawing.Size(730, 691);
            this.Name = "mgReportPerDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo hằng ngày";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mgReportPerDay_FormClosing);
            this.Load += new System.EventHandler(this.mgReportPerDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPerDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeMakeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.DateTimePicker dtp_PickDay;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rp_Report;
        private System.Windows.Forms.BindingSource USP_ReportPerDayBindingSource;
        private CoffeeHomeMakeDataSet CoffeeHomeMakeDataSet;
        private CoffeeHomeMakeDataSetTableAdapters.USP_ReportPerDayTableAdapter USP_ReportPerDayTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
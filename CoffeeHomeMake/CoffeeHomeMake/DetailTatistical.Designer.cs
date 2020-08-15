namespace CoffeeHomeMake
{
    partial class DetailTatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pn_Detail = new System.Windows.Forms.Panel();
            this.btn_More = new System.Windows.Forms.Button();
            this.lv_DetailTop5 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_DoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Panel();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.chart_Product = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pn_Detail.SuspendLayout();
            this.e.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Detail
            // 
            this.pn_Detail.BackColor = System.Drawing.Color.White;
            this.pn_Detail.Controls.Add(this.btn_Exit);
            this.pn_Detail.Controls.Add(this.btn_More);
            this.pn_Detail.Controls.Add(this.lv_DetailTop5);
            this.pn_Detail.Controls.Add(this.lb_DoanhThu);
            this.pn_Detail.Controls.Add(this.label2);
            this.pn_Detail.Controls.Add(this.label1);
            this.pn_Detail.Location = new System.Drawing.Point(32, 484);
            this.pn_Detail.Name = "pn_Detail";
            this.pn_Detail.Size = new System.Drawing.Size(1437, 353);
            this.pn_Detail.TabIndex = 1;
            // 
            // btn_More
            // 
            this.btn_More.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_More.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_More.ForeColor = System.Drawing.Color.White;
            this.btn_More.Location = new System.Drawing.Point(40, 139);
            this.btn_More.Name = "btn_More";
            this.btn_More.Size = new System.Drawing.Size(243, 84);
            this.btn_More.TabIndex = 17;
            this.btn_More.Text = "XEM THÊM";
            this.btn_More.UseVisualStyleBackColor = false;
            this.btn_More.Click += new System.EventHandler(this.btn_More_Click);
            // 
            // lv_DetailTop5
            // 
            this.lv_DetailTop5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_DetailTop5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DetailTop5.FullRowSelect = true;
            this.lv_DetailTop5.Location = new System.Drawing.Point(299, 3);
            this.lv_DetailTop5.Name = "lv_DetailTop5";
            this.lv_DetailTop5.Size = new System.Drawing.Size(1155, 347);
            this.lv_DetailTop5.TabIndex = 3;
            this.lv_DetailTop5.UseCompatibleStateImageBehavior = false;
            this.lv_DetailTop5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MÓN";
            this.columnHeader1.Width = 449;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SỐ LƯỢNG BÁN";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TỔNG GIÁ TRỊ";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TỈ LỆ PHẦN TRĂM";
            this.columnHeader4.Width = 163;
            // 
            // lb_DoanhThu
            // 
            this.lb_DoanhThu.AutoSize = true;
            this.lb_DoanhThu.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoanhThu.Location = new System.Drawing.Point(36, 59);
            this.lb_DoanhThu.Name = "lb_DoanhThu";
            this.lb_DoanhThu.Size = new System.Drawing.Size(20, 24);
            this.lb_DoanhThu.TabIndex = 2;
            this.lb_DoanhThu.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TỒNG DOANH THU : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT GIÁ TRỊ TOP 10 MANG LẠI";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(40, 240);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(243, 84);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // e
            // 
            this.e.Controls.Add(this.dtp_From);
            this.e.Controls.Add(this.dtp_To);
            this.e.Controls.Add(this.chart_Product);
            this.e.Location = new System.Drawing.Point(12, 12);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(1460, 466);
            this.e.TabIndex = 0;
            // 
            // dtp_From
            // 
            this.dtp_From.Enabled = false;
            this.dtp_From.Location = new System.Drawing.Point(20, 20);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(200, 20);
            this.dtp_From.TabIndex = 1;
            // 
            // dtp_To
            // 
            this.dtp_To.Enabled = false;
            this.dtp_To.Location = new System.Drawing.Point(20, 46);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(200, 20);
            this.dtp_To.TabIndex = 2;
            // 
            // chart_Product
            // 
            this.chart_Product.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chart_Product.ChartAreas.Add(chartArea1);
            this.chart_Product.Location = new System.Drawing.Point(20, 3);
            this.chart_Product.Name = "chart_Product";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 2;
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.MarkerSize = 1;
            series1.Name = "top10";
            this.chart_Product.Series.Add(series1);
            this.chart_Product.Size = new System.Drawing.Size(1440, 456);
            this.chart_Product.TabIndex = 0;
            this.chart_Product.Text = "chart1";
            // 
            // DetailTatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.pn_Detail);
            this.Controls.Add(this.e);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "DetailTatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetailTatistical";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailTatistical_FormClosing);
            this.pn_Detail.ResumeLayout(false);
            this.pn_Detail.PerformLayout();
            this.e.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel e;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Product;
        private System.Windows.Forms.Panel pn_Detail;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label lb_DoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_DetailTop5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_More;

    }
}
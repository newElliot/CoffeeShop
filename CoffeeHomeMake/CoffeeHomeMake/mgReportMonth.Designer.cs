namespace CoffeeHomeMake
{
    partial class mgReportMonth
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DataGid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ShowReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Today = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fromday = new System.Windows.Forms.DateTimePicker();
            this.txt_AVG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TotalBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Pevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataGid)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DataGid);
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 369);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DataGid
            // 
            this.dgv_DataGid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataGid.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_DataGid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DataGid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv_DataGid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_DataGid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DataGid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DataGid.GridColor = System.Drawing.Color.OrangeRed;
            this.dgv_DataGid.Location = new System.Drawing.Point(3, 0);
            this.dgv_DataGid.Name = "dgv_DataGid";
            this.dgv_DataGid.Size = new System.Drawing.Size(856, 364);
            this.dgv_DataGid.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_ShowReport);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtp_Today);
            this.panel4.Controls.Add(this.dtp_Fromday);
            this.panel4.Location = new System.Drawing.Point(12, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 99);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(798, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ShowReport
            // 
            this.btn_ShowReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowReport.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowReport.ForeColor = System.Drawing.Color.White;
            this.btn_ShowReport.Location = new System.Drawing.Point(614, 30);
            this.btn_ShowReport.Name = "btn_ShowReport";
            this.btn_ShowReport.Size = new System.Drawing.Size(157, 60);
            this.btn_ShowReport.TabIndex = 6;
            this.btn_ShowReport.Text = "XEM";
            this.btn_ShowReport.UseVisualStyleBackColor = false;
            this.btn_ShowReport.Click += new System.EventHandler(this.btn_ShowReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // dtp_Today
            // 
            this.dtp_Today.Font = new System.Drawing.Font("Quicksand", 12F);
            this.dtp_Today.Location = new System.Drawing.Point(319, 30);
            this.dtp_Today.Name = "dtp_Today";
            this.dtp_Today.Size = new System.Drawing.Size(267, 27);
            this.dtp_Today.TabIndex = 1;
            // 
            // dtp_Fromday
            // 
            this.dtp_Fromday.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fromday.Location = new System.Drawing.Point(34, 30);
            this.dtp_Fromday.Name = "dtp_Fromday";
            this.dtp_Fromday.Size = new System.Drawing.Size(267, 27);
            this.dtp_Fromday.TabIndex = 0;
            // 
            // txt_AVG
            // 
            this.txt_AVG.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AVG.Location = new System.Drawing.Point(11, 179);
            this.txt_AVG.Name = "txt_AVG";
            this.txt_AVG.ReadOnly = true;
            this.txt_AVG.Size = new System.Drawing.Size(197, 29);
            this.txt_AVG.TabIndex = 4;
            this.txt_AVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "TRUNG BÌNH";
            // 
            // txt_TotalBill
            // 
            this.txt_TotalBill.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalBill.Location = new System.Drawing.Point(11, 116);
            this.txt_TotalBill.Name = "txt_TotalBill";
            this.txt_TotalBill.ReadOnly = true;
            this.txt_TotalBill.Size = new System.Drawing.Size(197, 29);
            this.txt_TotalBill.TabIndex = 2;
            this.txt_TotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "TỔNG HÓA ĐƠN";
            // 
            // txt_Pevenue
            // 
            this.txt_Pevenue.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pevenue.Location = new System.Drawing.Point(11, 53);
            this.txt_Pevenue.Name = "txt_Pevenue";
            this.txt_Pevenue.ReadOnly = true;
            this.txt_Pevenue.Size = new System.Drawing.Size(197, 29);
            this.txt_Pevenue.TabIndex = 2;
            this.txt_Pevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "TỔNG DOANH THU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_AVG);
            this.groupBox1.Controls.Add(this.txt_Pevenue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TotalBill);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(880, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_PageNumber);
            this.panel3.Controls.Add(this.btn_Next);
            this.panel3.Controls.Add(this.btn_Previous);
            this.panel3.Controls.Add(this.btn_Last);
            this.panel3.Controls.Add(this.btn_First);
            this.panel3.Location = new System.Drawing.Point(228, 543);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 58);
            this.panel3.TabIndex = 5;
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txt_PageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PageNumber.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PageNumber.Location = new System.Drawing.Point(190, 23);
            this.txt_PageNumber.Name = "txt_PageNumber";
            this.txt_PageNumber.Size = new System.Drawing.Size(46, 19);
            this.txt_PageNumber.TabIndex = 5;
            this.txt_PageNumber.Text = "1";
            this.txt_PageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PageNumber.TextChanged += new System.EventHandler(this.txt_PageNumber_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(242, 13);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(43, 38);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Location = new System.Drawing.Point(141, 13);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(43, 38);
            this.btn_Previous.TabIndex = 11;
            this.btn_Previous.Text = "<";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Last.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last.ForeColor = System.Drawing.Color.White;
            this.btn_Last.Location = new System.Drawing.Point(321, 12);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(105, 38);
            this.btn_Last.TabIndex = 10;
            this.btn_Last.Text = "Last";
            this.btn_Last.UseVisualStyleBackColor = false;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_First.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.ForeColor = System.Drawing.Color.White;
            this.btn_First.Location = new System.Drawing.Point(3, 13);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(105, 38);
            this.btn_First.TabIndex = 9;
            this.btn_First.Text = "First";
            this.btn_First.UseVisualStyleBackColor = false;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // mgReportMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1159, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "mgReportMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THỐNG KÊ DOANH THU";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataGid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DataGid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ShowReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Today;
        private System.Windows.Forms.DateTimePicker dtp_Fromday;
        private System.Windows.Forms.TextBox txt_AVG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TotalBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Pevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_PageNumber;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_First;
    }
}
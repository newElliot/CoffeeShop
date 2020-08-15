namespace CoffeeHomeMake
{
    partial class ListFiredStaff
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
            this.lv_Fired = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_Fired
            // 
            this.lv_Fired.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_Fired.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Fired.FullRowSelect = true;
            this.lv_Fired.Location = new System.Drawing.Point(12, 12);
            this.lv_Fired.Name = "lv_Fired";
            this.lv_Fired.Size = new System.Drawing.Size(1060, 637);
            this.lv_Fired.TabIndex = 0;
            this.lv_Fired.UseCompatibleStateImageBehavior = false;
            this.lv_Fired.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Địa chỉ";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CMND";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày vào làm";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày nghỉ việc";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Làm việc tại";
            this.columnHeader6.Width = 197;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chức vụ";
            this.columnHeader7.Width = 116;
            // 
            // ListFiredStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.lv_Fired);
            this.Name = "ListFiredStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH SÁCH NHÂN VIÊN ĐÃ NGHỈ VIỆC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Fired;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
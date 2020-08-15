namespace CoffeeHomeMake
{
    partial class mgSupplier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_List = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Group);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lv_List
            // 
            this.lv_List.AllowDrop = true;
            this.lv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_List.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_List.FullRowSelect = true;
            this.lv_List.Location = new System.Drawing.Point(12, 248);
            this.lv_List.Name = "lv_List";
            this.lv_List.Size = new System.Drawing.Size(840, 319);
            this.lv_List.TabIndex = 1;
            this.lv_List.UseCompatibleStateImageBehavior = false;
            this.lv_List.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(629, 163);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(188, 60);
            this.btn_Exit.TabIndex = 39;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(435, 163);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(188, 60);
            this.btn_Update.TabIndex = 38;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detail.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Location = new System.Drawing.Point(241, 163);
            this.btn_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(188, 60);
            this.btn_Detail.TabIndex = 37;
            this.btn_Detail.Text = "CHI TIẾT";
            this.btn_Detail.UseVisualStyleBackColor = false;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(47, 163);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(188, 60);
            this.btn_Add.TabIndex = 36;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NCC";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên NCC";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 266;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thuộc nhóm";
            this.columnHeader5.Width = 223;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(171, 25);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(236, 26);
            this.txt_Name.TabIndex = 12;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(171, 77);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(236, 26);
            this.txt_address.TabIndex = 13;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(537, 76);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(236, 26);
            this.txt_Phone.TabIndex = 14;
            // 
            // cbb_Group
            // 
            this.cbb_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Group.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(537, 28);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(236, 27);
            this.cbb_Group.TabIndex = 15;
            // 
            // mgSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 592);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_List);
            this.Controls.Add(this.groupBox1);
            this.Name = "mgSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhà cung cấp nguyên vật liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_List;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cbb_Group;
    }
}
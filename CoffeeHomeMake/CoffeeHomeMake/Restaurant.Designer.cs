namespace CoffeeHomeMake
{
    partial class Restaurant
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
            this.flp_Category = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_disCount = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.txt_IDPersonnel = new System.Windows.Forms.TextBox();
            this.txt_StaffName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_ToTable = new System.Windows.Forms.ComboBox();
            this.cbb_FromTable = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Combine = new System.Windows.Forms.Button();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.flp_DetailCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.TimeSystem = new System.Windows.Forms.Timer(this.components);
            this.lb_TenBan = new System.Windows.Forms.Label();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_SoBill = new System.Windows.Forms.Label();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Return = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_Category
            // 
            this.flp_Category.AutoScroll = true;
            this.flp_Category.BackColor = System.Drawing.Color.Transparent;
            this.flp_Category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Category.Location = new System.Drawing.Point(9, 272);
            this.flp_Category.Name = "flp_Category";
            this.flp_Category.Size = new System.Drawing.Size(200, 573);
            this.flp_Category.TabIndex = 2;
            // 
            // flp_Table
            // 
            this.flp_Table.AutoScroll = true;
            this.flp_Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flp_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flp_Table.Location = new System.Drawing.Point(9, 55);
            this.flp_Table.Name = "flp_Table";
            this.flp_Table.Size = new System.Drawing.Size(1254, 192);
            this.flp_Table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẠN ĐANG CHỌN BÀN SỐ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_Product);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.btn_CheckOut);
            this.panel5.Controls.Add(this.txt_IDPersonnel);
            this.panel5.Controls.Add(this.txt_StaffName);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cbb_ToTable);
            this.panel5.Controls.Add(this.cbb_FromTable);
            this.panel5.Controls.Add(this.btn_Delete);
            this.panel5.Controls.Add(this.btn_Combine);
            this.panel5.Controls.Add(this.btn_SwitchTable);
            this.panel5.Location = new System.Drawing.Point(1107, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 573);
            this.panel5.TabIndex = 4;
            // 
            // txt_Product
            // 
            this.txt_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txt_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Product.Enabled = false;
            this.txt_Product.Font = new System.Drawing.Font("Sitka Heading", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product.Location = new System.Drawing.Point(234, 378);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.ReadOnly = true;
            this.txt_Product.Size = new System.Drawing.Size(18, 14);
            this.txt_Product.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_disCount);
            this.panel1.Controls.Add(this.btn_Plus);
            this.panel1.Controls.Add(this.btn_Minus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 100);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "%";
            // 
            // lb_disCount
            // 
            this.lb_disCount.AutoSize = true;
            this.lb_disCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_disCount.ForeColor = System.Drawing.Color.White;
            this.lb_disCount.Location = new System.Drawing.Point(80, 45);
            this.lb_disCount.Name = "lb_disCount";
            this.lb_disCount.Size = new System.Drawing.Size(18, 20);
            this.lb_disCount.TabIndex = 18;
            this.lb_disCount.Text = "0";
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackgroundImage = global::CoffeeHomeMake.Properties.Resources.cong;
            this.btn_Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Plus.Location = new System.Drawing.Point(133, 33);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(42, 38);
            this.btn_Plus.TabIndex = 19;
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackgroundImage = global::CoffeeHomeMake.Properties.Resources.tru;
            this.btn_Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minus.Location = new System.Drawing.Point(28, 33);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(42, 38);
            this.btn_Minus.TabIndex = 17;
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giảm giá";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.Location = new System.Drawing.Point(213, 438);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(147, 100);
            this.btn_CheckOut.TabIndex = 15;
            this.btn_CheckOut.Text = "THANH TOÁN";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // txt_IDPersonnel
            // 
            this.txt_IDPersonnel.Enabled = false;
            this.txt_IDPersonnel.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.txt_IDPersonnel.Location = new System.Drawing.Point(-1, 34);
            this.txt_IDPersonnel.Name = "txt_IDPersonnel";
            this.txt_IDPersonnel.ReadOnly = true;
            this.txt_IDPersonnel.Size = new System.Drawing.Size(45, 28);
            this.txt_IDPersonnel.TabIndex = 14;
            // 
            // txt_StaffName
            // 
            this.txt_StaffName.Enabled = false;
            this.txt_StaffName.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StaffName.Location = new System.Drawing.Point(43, 34);
            this.txt_StaffName.Name = "txt_StaffName";
            this.txt_StaffName.ReadOnly = true;
            this.txt_StaffName.Size = new System.Drawing.Size(322, 28);
            this.txt_StaffName.TabIndex = 13;
            this.txt_StaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhân viên kiêm thu ngân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đến bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ bàn";
            // 
            // cbb_ToTable
            // 
            this.cbb_ToTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbb_ToTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ToTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_ToTable.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbb_ToTable.ForeColor = System.Drawing.Color.White;
            this.cbb_ToTable.FormattingEnabled = true;
            this.cbb_ToTable.Location = new System.Drawing.Point(204, 101);
            this.cbb_ToTable.Name = "cbb_ToTable";
            this.cbb_ToTable.Size = new System.Drawing.Size(156, 36);
            this.cbb_ToTable.TabIndex = 10;
            // 
            // cbb_FromTable
            // 
            this.cbb_FromTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbb_FromTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_FromTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_FromTable.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_FromTable.ForeColor = System.Drawing.Color.White;
            this.cbb_FromTable.FormattingEnabled = true;
            this.cbb_FromTable.Location = new System.Drawing.Point(3, 101);
            this.cbb_FromTable.Name = "cbb_FromTable";
            this.cbb_FromTable.Size = new System.Drawing.Size(156, 36);
            this.cbb_FromTable.TabIndex = 9;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(3, 343);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(357, 89);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "XÓA MÓN";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Combine
            // 
            this.btn_Combine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Combine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Combine.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Combine.ForeColor = System.Drawing.Color.White;
            this.btn_Combine.Location = new System.Drawing.Point(3, 249);
            this.btn_Combine.Name = "btn_Combine";
            this.btn_Combine.Size = new System.Drawing.Size(357, 89);
            this.btn_Combine.TabIndex = 7;
            this.btn_Combine.Text = "GỘP BÀN";
            this.btn_Combine.UseVisualStyleBackColor = false;
            this.btn_Combine.Click += new System.EventHandler(this.btn_Combine_Click);
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_SwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SwitchTable.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchTable.ForeColor = System.Drawing.Color.White;
            this.btn_SwitchTable.Location = new System.Drawing.Point(3, 154);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(357, 89);
            this.btn_SwitchTable.TabIndex = 6;
            this.btn_SwitchTable.Text = "CHUYỂN BÀN";
            this.btn_SwitchTable.UseVisualStyleBackColor = false;
            this.btn_SwitchTable.Click += new System.EventHandler(this.btn_SwitchTable_Click);
            // 
            // flp_DetailCategory
            // 
            this.flp_DetailCategory.AutoScroll = true;
            this.flp_DetailCategory.BackColor = System.Drawing.Color.Transparent;
            this.flp_DetailCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_DetailCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flp_DetailCategory.Location = new System.Drawing.Point(215, 272);
            this.flp_DetailCategory.Name = "flp_DetailCategory";
            this.flp_DetailCategory.Size = new System.Drawing.Size(391, 573);
            this.flp_DetailCategory.TabIndex = 0;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.Location = new System.Drawing.Point(1287, 182);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(83, 38);
            this.lb_Time.TabIndex = 7;
            this.lb_Time.Text = "Time";
            // 
            // TimeSystem
            // 
            this.TimeSystem.Tick += new System.EventHandler(this.TimeSystem_Tick);
            // 
            // lb_TenBan
            // 
            this.lb_TenBan.AutoSize = true;
            this.lb_TenBan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBan.ForeColor = System.Drawing.Color.White;
            this.lb_TenBan.Location = new System.Drawing.Point(215, 30);
            this.lb_TenBan.Name = "lb_TenBan";
            this.lb_TenBan.Size = new System.Drawing.Size(18, 22);
            this.lb_TenBan.TabIndex = 8;
            this.lb_TenBan.Text = "#";
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPrice.ForeColor = System.Drawing.Color.White;
            this.lb_totalPrice.Location = new System.Drawing.Point(314, -2);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(23, 28);
            this.lb_totalPrice.TabIndex = 21;
            this.lb_totalPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Thành tiền :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_count);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_totalPrice);
            this.panel2.Location = new System.Drawing.Point(612, 817);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 28);
            this.panel2.TabIndex = 23;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.ForeColor = System.Drawing.Color.White;
            this.lb_count.Location = new System.Drawing.Point(79, 0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(18, 23);
            this.lb_count.TabIndex = 24;
            this.lb_count.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số lượng : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(612, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "HÓA ĐƠN BÀN SỐ ";
            // 
            // lb_SoBill
            // 
            this.lb_SoBill.AutoSize = true;
            this.lb_SoBill.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoBill.ForeColor = System.Drawing.Color.White;
            this.lb_SoBill.Location = new System.Drawing.Point(760, 250);
            this.lb_SoBill.Name = "lb_SoBill";
            this.lb_SoBill.Size = new System.Drawing.Size(18, 22);
            this.lb_SoBill.TabIndex = 26;
            this.lb_SoBill.Text = "#";
            // 
            // lv_Bill
            // 
            this.lv_Bill.BackColor = System.Drawing.Color.White;
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_Bill.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Bill.FullRowSelect = true;
            this.lv_Bill.Location = new System.Drawing.Point(612, 272);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(493, 539);
            this.lv_Bill.TabIndex = 27;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            this.lv_Bill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Bill_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MÃ MÓN";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MÓN";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐƠN GIÁ";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SL";
            this.columnHeader4.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TỔNG";
            this.columnHeader5.Width = 124;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Palatino Linotype", 21.75F);
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Location = new System.Drawing.Point(1283, 64);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(185, 75);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.Text = "THOÁT";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // Restaurant
            // 
            this.AcceptButton = this.btn_CheckOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CancelButton = this.btn_Return;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.flp_Table);
            this.Controls.Add(this.lv_Bill);
            this.Controls.Add(this.lb_SoBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_TenBan);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.flp_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_DetailCategory);
            this.Controls.Add(this.panel5);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "Restaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Restaurant_FormClosing);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StaffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_ToTable;
        private System.Windows.Forms.ComboBox cbb_FromTable;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Combine;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.FlowLayoutPanel flp_DetailCategory;
        private System.Windows.Forms.FlowLayoutPanel flp_Table;
        private System.Windows.Forms.FlowLayoutPanel flp_Category;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Timer TimeSystem;
        private System.Windows.Forms.TextBox txt_IDPersonnel;
        private System.Windows.Forms.Label lb_TenBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_disCount;
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_SoBill;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
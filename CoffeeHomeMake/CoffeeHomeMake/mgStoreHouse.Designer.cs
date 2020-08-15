namespace CoffeeHomeMake
{
    partial class mgStoreHouse
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
            this.lv_DataMaterial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.num_weight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cbb_LocNCC = new System.Windows.Forms.ComboBox();
            this.btn_inSupplier = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_DataMaterial
            // 
            this.lv_DataMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_DataMaterial.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DataMaterial.FullRowSelect = true;
            this.lv_DataMaterial.Location = new System.Drawing.Point(71, 431);
            this.lv_DataMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_DataMaterial.Name = "lv_DataMaterial";
            this.lv_DataMaterial.Size = new System.Drawing.Size(1344, 523);
            this.lv_DataMaterial.TabIndex = 0;
            this.lv_DataMaterial.UseCompatibleStateImageBehavior = false;
            this.lv_DataMaterial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên ";
            this.columnHeader2.Width = 403;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn vị tính";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trọng lượng (kg)";
            this.columnHeader4.Width = 161;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 159;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nhà cung cấp";
            this.columnHeader6.Width = 366;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(888, 370);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN NGUYÊN LIỆU (Đã nhập)";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Exit);
            this.panel4.Controls.Add(this.num_weight);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btn_inSupplier);
            this.panel4.Controls.Add(this.btn_Update);
            this.panel4.Controls.Add(this.btn_Detail);
            this.panel4.Controls.Add(this.btn_Add);
            this.panel4.Controls.Add(this.txt_Price);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbb_NCC);
            this.panel4.Controls.Add(this.txt_Unit);
            this.panel4.Controls.Add(this.txt_Name);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(6, 26);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 337);
            this.panel4.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(482, 228);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(188, 60);
            this.btn_Exit.TabIndex = 35;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // num_weight
            // 
            this.num_weight.Location = new System.Drawing.Point(150, 134);
            this.num_weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_weight.Name = "num_weight";
            this.num_weight.Size = new System.Drawing.Size(120, 26);
            this.num_weight.TabIndex = 34;
            this.num_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Sort);
            this.groupBox1.Controls.Add(this.cbb_LocNCC);
            this.groupBox1.Location = new System.Drawing.Point(676, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(200, 170);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỌC THEO NCC";
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(121)))), ((int)(((byte)(66)))));
            this.btn_Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Font = new System.Drawing.Font("Quicksand", 14.25F);
            this.btn_Sort.ForeColor = System.Drawing.Color.White;
            this.btn_Sort.Location = new System.Drawing.Point(6, 84);
            this.btn_Sort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(188, 55);
            this.btn_Sort.TabIndex = 35;
            this.btn_Sort.Text = "LỌC";
            this.btn_Sort.UseVisualStyleBackColor = false;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // cbb_LocNCC
            // 
            this.cbb_LocNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LocNCC.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LocNCC.FormattingEnabled = true;
            this.cbb_LocNCC.Location = new System.Drawing.Point(6, 31);
            this.cbb_LocNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_LocNCC.Name = "cbb_LocNCC";
            this.cbb_LocNCC.Size = new System.Drawing.Size(188, 31);
            this.cbb_LocNCC.TabIndex = 34;
            // 
            // btn_inSupplier
            // 
            this.btn_inSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_inSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inSupplier.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inSupplier.ForeColor = System.Drawing.Color.White;
            this.btn_inSupplier.Location = new System.Drawing.Point(150, 283);
            this.btn_inSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_inSupplier.Name = "btn_inSupplier";
            this.btn_inSupplier.Size = new System.Drawing.Size(304, 38);
            this.btn_inSupplier.TabIndex = 32;
            this.btn_inSupplier.Text = "Quản lý nhà cung cấp";
            this.btn_inSupplier.UseVisualStyleBackColor = false;
            this.btn_inSupplier.Click += new System.EventHandler(this.btn_inSupplier_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(482, 160);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(188, 60);
            this.btn_Update.TabIndex = 31;
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
            this.btn_Detail.Location = new System.Drawing.Point(482, 92);
            this.btn_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(188, 60);
            this.btn_Detail.TabIndex = 30;
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
            this.btn_Add.Location = new System.Drawing.Point(482, 24);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(188, 60);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(150, 186);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(304, 26);
            this.txt_Price.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Trọng lượng (kg)";
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NCC.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(150, 244);
            this.cbb_NCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(304, 31);
            this.cbb_NCC.TabIndex = 16;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit.Location = new System.Drawing.Point(150, 78);
            this.txt_Unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(304, 26);
            this.txt_Unit.TabIndex = 12;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(150, 25);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(304, 26);
            this.txt_Name.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nguyên vật liệu";
            // 
            // mgStoreHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 999);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_DataMaterial);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1500, 1099);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "mgStoreHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nguyên vật liệu";
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_DataMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_inSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_LocNCC;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.NumericUpDown num_weight;
        private System.Windows.Forms.Button btn_Exit;
    }
}
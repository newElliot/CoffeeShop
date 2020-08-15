namespace CoffeeHomeMake
{
    partial class mgProduct
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
            this.dgv_DataGid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Watch = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataGid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DataGid
            // 
            this.dgv_DataGid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataGid.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DataGid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DataGid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_DataGid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataGid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataGid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DataGid.GridColor = System.Drawing.Color.Tomato;
            this.dgv_DataGid.Location = new System.Drawing.Point(43, 312);
            this.dgv_DataGid.Name = "dgv_DataGid";
            this.dgv_DataGid.ReadOnly = true;
            this.dgv_DataGid.Size = new System.Drawing.Size(1001, 369);
            this.dgv_DataGid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbb_Category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(159, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 110);
            this.panel1.TabIndex = 1;
            // 
            // cbb_Category
            // 
            this.cbb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Category.Font = new System.Drawing.Font("Quicksand", 12F);
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(381, 52);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(253, 32);
            this.cbb_Category.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món ";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Quicksand", 12F);
            this.txt_Price.Location = new System.Drawing.Point(94, 52);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(184, 27);
            this.txt_Price.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Quicksand", 12F);
            this.txt_Name.Location = new System.Drawing.Point(381, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(253, 27);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Quicksand", 12F);
            this.txt_ID.Location = new System.Drawing.Point(94, 6);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(184, 27);
            this.txt_ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F);
            this.label4.Location = new System.Drawing.Point(303, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F);
            this.label3.Location = new System.Drawing.Point(303, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F);
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Watch);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Location = new System.Drawing.Point(43, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 119);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbb_Sort);
            this.groupBox3.Controls.Add(this.btn_Sort);
            this.groupBox3.Font = new System.Drawing.Font("Quicksand", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(798, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Sort.Font = new System.Drawing.Font("Quicksand", 12F);
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(13, 19);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(181, 32);
            this.cbb_Sort.TabIndex = 8;
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(71)))));
            this.btn_Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Sort.ForeColor = System.Drawing.Color.White;
            this.btn_Sort.Location = new System.Drawing.Point(13, 55);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(168, 49);
            this.btn_Sort.TabIndex = 10;
            this.btn_Sort.Text = "LỌC";
            this.btn_Sort.UseVisualStyleBackColor = false;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Find);
            this.groupBox2.Controls.Add(this.btn_Find);
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(590, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 110);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(8, 19);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(189, 29);
            this.txt_Find.TabIndex = 8;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(29, 54);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(168, 49);
            this.btn_Find.TabIndex = 9;
            this.btn_Find.Text = "TÌM";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(121)))), ((int)(((byte)(66)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(394, 61);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(168, 49);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "XÓA";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(197, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(168, 49);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "LƯU";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(197, 61);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(168, 49);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_Update.Location = new System.Drawing.Point(394, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(168, 49);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "CHI TIẾT";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Watch
            // 
            this.btn_Watch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Watch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Watch.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Watch.ForeColor = System.Drawing.Color.White;
            this.btn_Watch.Location = new System.Drawing.Point(0, 3);
            this.btn_Watch.Name = "btn_Watch";
            this.btn_Watch.Size = new System.Drawing.Size(168, 49);
            this.btn_Watch.TabIndex = 9;
            this.btn_Watch.Text = "XEM";
            this.btn_Watch.UseVisualStyleBackColor = false;
            this.btn_Watch.Click += new System.EventHandler(this.btn_Watch_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(0, 60);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(168, 49);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_PageNumber);
            this.panel3.Controls.Add(this.btn_Next);
            this.panel3.Controls.Add(this.btn_Previous);
            this.panel3.Controls.Add(this.btn_Last);
            this.panel3.Controls.Add(this.btn_First);
            this.panel3.Location = new System.Drawing.Point(320, 687);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 58);
            this.panel3.TabIndex = 4;
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
            // txt_PageNumber
            // 
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
            // mgProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 757);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_DataGid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "mgProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mgProduct_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataGid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DataGid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button btn_Watch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.TextBox txt_PageNumber;
    }
}
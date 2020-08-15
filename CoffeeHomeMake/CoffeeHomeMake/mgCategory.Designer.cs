namespace CoffeeHomeMake
{
    partial class mgCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Fix = new System.Windows.Forms.Button();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.TimeSystem = new System.Windows.Forms.Timer(this.components);
            this.lb_Time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN DANH MỤC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(67, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 33);
            this.panel1.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(162, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(256, 31);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(6, 25);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 44);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Fix
            // 
            this.btn_Fix.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Fix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fix.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Fix.ForeColor = System.Drawing.Color.White;
            this.btn_Fix.Location = new System.Drawing.Point(6, 141);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(141, 44);
            this.btn_Fix.TabIndex = 4;
            this.btn_Fix.Text = "SỬA";
            this.btn_Fix.UseVisualStyleBackColor = false;
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // dgv_Category
            // 
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.GridColor = System.Drawing.Color.Chocolate;
            this.dgv_Category.Location = new System.Drawing.Point(67, 114);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            this.dgv_Category.Size = new System.Drawing.Size(421, 318);
            this.dgv_Category.TabIndex = 5;
            this.dgv_Category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Category_CellMouseClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(6, 201);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(141, 44);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(6, 80);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 44);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "LƯU";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // TimeSystem
            // 
            this.TimeSystem.Tick += new System.EventHandler(this.TimeSystem_Tick);
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.Color.Transparent;
            this.lb_Time.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.Black;
            this.lb_Time.Location = new System.Drawing.Point(450, 28);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(60, 28);
            this.lb_Time.TabIndex = 10;
            this.lb_Time.Text = "TIME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(105)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(654, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 357);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 165);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 54);
            this.label4.TabIndex = 1;
            this.label4.Text = "- Nhấp vào \"THÊM\"  để bắt đầu thêm mới \r\n1 Category  sau đó nhấn \"LƯU\" để lưu dữ " +
    "\r\nliệu vừa thêm.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 54);
            this.label5.TabIndex = 2;
            this.label5.Text = "- Nhấp vào \"SỬA\" để bắt đầu sửa tên \r\n1 Category  sau đó nhấn \"LƯU\" để cập \r\nnhật" +
    " dữ liệu.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hướng dẫn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeHomeMake.Properties.Resources.cate;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 151);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Fix);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(495, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 257);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // mgCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "mgCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ DANH MỤC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mgCategory_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Fix;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Timer TimeSystem;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
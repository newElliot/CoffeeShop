namespace CoffeeHomeMake
{
    partial class mgAccount
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
            this.cbb_Staff = new System.Windows.Forms.ComboBox();
            this.txt_DisPlayName = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Staff);
            this.groupBox1.Controls.Add(this.txt_DisPlayName);
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản Cá Nhân";
            // 
            // cbb_Staff
            // 
            this.cbb_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Staff.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Staff.FormattingEnabled = true;
            this.cbb_Staff.Location = new System.Drawing.Point(23, 308);
            this.cbb_Staff.Name = "cbb_Staff";
            this.cbb_Staff.Size = new System.Drawing.Size(311, 31);
            this.cbb_Staff.TabIndex = 18;
            // 
            // txt_DisPlayName
            // 
            this.txt_DisPlayName.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisPlayName.Location = new System.Drawing.Point(24, 230);
            this.txt_DisPlayName.Name = "txt_DisPlayName";
            this.txt_DisPlayName.Size = new System.Drawing.Size(304, 26);
            this.txt_DisPlayName.TabIndex = 14;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(24, 147);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(304, 26);
            this.txt_Pass.TabIndex = 13;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(24, 68);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(304, 26);
            this.txt_UserName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hiển thị :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName :";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(12, 524);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(222, 67);
            this.btn_Create.TabIndex = 20;
            this.btn_Create.Text = "Tạo tài khoản";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(240, 524);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(222, 67);
            this.btn_Exit.TabIndex = 21;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // mgAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 643);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.groupBox1);
            this.Name = "mgAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản cá nhân";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_DisPlayName;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.ComboBox cbb_Staff;
    }
}
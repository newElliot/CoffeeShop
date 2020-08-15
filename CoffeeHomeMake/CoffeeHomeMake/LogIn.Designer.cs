namespace CoffeeHomeMake
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(3, 63);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(286, 31);
            this.txt_userName.TabIndex = 1;
            this.txt_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.Location = new System.Drawing.Point(3, 125);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(286, 31);
            this.txt_PassWord.TabIndex = 2;
            this.txt_PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_LogIn.ForeColor = System.Drawing.Color.White;
            this.btn_LogIn.Location = new System.Drawing.Point(3, 220);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(286, 64);
            this.btn_LogIn.TabIndex = 3;
            this.btn_LogIn.Text = "ĐĂNG NHẬP";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Controls.Add(this.btn_LogIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_PassWord);
            this.panel1.Location = new System.Drawing.Point(133, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 368);
            this.panel1.TabIndex = 6;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(3, 284);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(286, 64);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khách vào cái bụng đói . Ra về với cái ví rỗng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "All rights reserved || Design by Phạm Minh Tài";
            // 
            // LogIn
            // 
            this.AcceptButton = this.btn_LogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeHomeMake.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 755);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(550, 755);
            this.MinimumSize = new System.Drawing.Size(550, 755);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exit;
    }
}
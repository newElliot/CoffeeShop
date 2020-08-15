namespace CoffeeHomeMake
{
    partial class ProlemProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_Prolem = new System.Windows.Forms.ListView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.lv_Prolem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 678);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "#";
            // 
            // lv_Prolem
            // 
            this.lv_Prolem.AllowDrop = true;
            this.lv_Prolem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Prolem.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Prolem.FullRowSelect = true;
            this.lv_Prolem.Location = new System.Drawing.Point(3, 76);
            this.lv_Prolem.Name = "lv_Prolem";
            this.lv_Prolem.Size = new System.Drawing.Size(737, 579);
            this.lv_Prolem.TabIndex = 1;
            this.lv_Prolem.UseCompatibleStateImageBehavior = false;
            this.lv_Prolem.View = System.Windows.Forms.View.Details;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(746, 76);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 84);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MÓN";
            this.columnHeader1.Width = 285;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "GIÁ";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐÃ BÁN";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TRỊ GIÁ";
            this.columnHeader4.Width = 212;
            // 
            // ProlemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 695);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 734);
            this.MinimumSize = new System.Drawing.Size(1000, 734);
            this.Name = "ProlemProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TOP NHỮNG MÓN CẦN XEM XÉT LẠI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProlemProduct_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_Prolem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
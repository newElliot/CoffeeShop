namespace CoffeeHomeMake
{
    partial class BillCheckOut
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_PrintAndUpdate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_Count = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_realPay = new System.Windows.Forms.Label();
            this.lb_MoneyDiscount = new System.Windows.Forms.Label();
            this.lb_disCount = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_Cashier = new System.Windows.Forms.Label();
            this.lb_dateCheckOut = new System.Windows.Forms.Label();
            this.lb_IDBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 156);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 90);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hưng Long, Bình Chánh,\r\nThành phố Hồ Chí Minh, Việt Nam, \r\nChâu Á, Trái đất, hành" +
    " tinh thứ 3, \r\nhệ mặt trời\r\nthiên hà số 7";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coffee Home Make";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_Bill);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_PrintAndUpdate);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(6, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 607);
            this.panel2.TabIndex = 10;
            // 
            // lv_Bill
            // 
            this.lv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Bill.FullRowSelect = true;
            this.lv_Bill.Location = new System.Drawing.Point(0, 130);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(306, 351);
            this.lv_Bill.TabIndex = 21;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SP";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.Width = 33;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng";
            this.columnHeader4.Width = 122;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(12, 549);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 55);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_PrintAndUpdate
            // 
            this.btn_PrintAndUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintAndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintAndUpdate.Location = new System.Drawing.Point(12, 487);
            this.btn_PrintAndUpdate.Name = "btn_PrintAndUpdate";
            this.btn_PrintAndUpdate.Size = new System.Drawing.Size(85, 55);
            this.btn_PrintAndUpdate.TabIndex = 17;
            this.btn_PrintAndUpdate.Text = "In";
            this.btn_PrintAndUpdate.UseVisualStyleBackColor = true;
            this.btn_PrintAndUpdate.Click += new System.EventHandler(this.btn_PrintAndUpdate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.lb_Count);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.lb_realPay);
            this.panel5.Controls.Add(this.lb_MoneyDiscount);
            this.panel5.Controls.Add(this.lb_disCount);
            this.panel5.Controls.Add(this.lb_Total);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(103, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 117);
            this.panel5.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "%";
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(82, 33);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(14, 13);
            this.lb_Count.TabIndex = 21;
            this.lb_Count.Text = "#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Số lượng :";
            // 
            // lb_realPay
            // 
            this.lb_realPay.AutoSize = true;
            this.lb_realPay.Location = new System.Drawing.Point(82, 100);
            this.lb_realPay.Name = "lb_realPay";
            this.lb_realPay.Size = new System.Drawing.Size(14, 13);
            this.lb_realPay.TabIndex = 19;
            this.lb_realPay.Text = "#";
            // 
            // lb_MoneyDiscount
            // 
            this.lb_MoneyDiscount.AutoSize = true;
            this.lb_MoneyDiscount.Location = new System.Drawing.Point(82, 77);
            this.lb_MoneyDiscount.Name = "lb_MoneyDiscount";
            this.lb_MoneyDiscount.Size = new System.Drawing.Size(14, 13);
            this.lb_MoneyDiscount.TabIndex = 18;
            this.lb_MoneyDiscount.Text = "#";
            // 
            // lb_disCount
            // 
            this.lb_disCount.AutoSize = true;
            this.lb_disCount.Location = new System.Drawing.Point(82, 55);
            this.lb_disCount.Name = "lb_disCount";
            this.lb_disCount.Size = new System.Drawing.Size(14, 13);
            this.lb_disCount.TabIndex = 17;
            this.lb_disCount.Text = "#";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(82, 10);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(14, 13);
            this.lb_Total.TabIndex = 16;
            this.lb_Total.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Thanh toán :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tiển giảm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giảm giá  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(147, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 19;
            this.label14.Text = "Thành tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "SL";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_Cashier);
            this.panel4.Controls.Add(this.lb_dateCheckOut);
            this.panel4.Controls.Add(this.lb_IDBill);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 99);
            this.panel4.TabIndex = 10;
            // 
            // lb_Cashier
            // 
            this.lb_Cashier.AutoSize = true;
            this.lb_Cashier.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cashier.Location = new System.Drawing.Point(76, 65);
            this.lb_Cashier.Name = "lb_Cashier";
            this.lb_Cashier.Size = new System.Drawing.Size(18, 22);
            this.lb_Cashier.TabIndex = 11;
            this.lb_Cashier.Text = "#";
            // 
            // lb_dateCheckOut
            // 
            this.lb_dateCheckOut.AutoSize = true;
            this.lb_dateCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dateCheckOut.Location = new System.Drawing.Point(76, 33);
            this.lb_dateCheckOut.Name = "lb_dateCheckOut";
            this.lb_dateCheckOut.Size = new System.Drawing.Size(18, 22);
            this.lb_dateCheckOut.TabIndex = 12;
            this.lb_dateCheckOut.Text = "#";
            // 
            // lb_IDBill
            // 
            this.lb_IDBill.AutoSize = true;
            this.lb_IDBill.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDBill.Location = new System.Drawing.Point(76, 4);
            this.lb_IDBill.Name = "lb_IDBill";
            this.lb_IDBill.Size = new System.Drawing.Size(18, 22);
            this.lb_IDBill.TabIndex = 11;
            this.lb_IDBill.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thu ngân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(6, 790);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 55);
            this.panel3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chúng tôi chỉ xuất hóa đơn 1 lần duy nhất và không hỗ trợ\r\nđổi trả hàng. Quý khác" +
    "h vui lòng kiểm tra hàng hóa kỹ trước\r\nkhi thanh toán. Xin chân thành cảm ơn !";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BillCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 846);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(335, 885);
            this.MinimumSize = new System.Drawing.Size(335, 885);
            this.Name = "BillCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xuất hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_Cashier;
        private System.Windows.Forms.Label lb_dateCheckOut;
        private System.Windows.Forms.Label lb_IDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_realPay;
        private System.Windows.Forms.Label lb_MoneyDiscount;
        private System.Windows.Forms.Label lb_disCount;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_PrintAndUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
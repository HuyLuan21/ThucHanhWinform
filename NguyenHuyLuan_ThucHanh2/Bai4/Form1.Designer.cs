﻿namespace Bai4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentListlv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UpdateItemBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StudentClasscbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Studentdtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StudentAddresstxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StudentFullNametxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentCodetxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentListlv);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(67, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 679);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // StudentListlv
            // 
            this.StudentListlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.StudentListlv.FullRowSelect = true;
            this.StudentListlv.HideSelection = false;
            this.StudentListlv.Location = new System.Drawing.Point(6, 391);
            this.StudentListlv.Name = "StudentListlv";
            this.StudentListlv.Size = new System.Drawing.Size(963, 282);
            this.StudentListlv.SmallImageList = this.imageList1;
            this.StudentListlv.TabIndex = 3;
            this.StudentListlv.UseCompatibleStateImageBehavior = false;
            this.StudentListlv.View = System.Windows.Forms.View.Details;
            this.StudentListlv.SelectedIndexChanged += new System.EventHandler(this.StudentListlv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 253;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 244;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            this.columnHeader5.Width = 107;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "favicon.ico");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ExitBtn);
            this.panel7.Controls.Add(this.UpdateItemBtn);
            this.panel7.Controls.Add(this.DeleteItemBtn);
            this.panel7.Controls.Add(this.addItemBtn);
            this.panel7.Location = new System.Drawing.Point(555, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 327);
            this.panel7.TabIndex = 2;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(16, 202);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(147, 43);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UpdateItemBtn
            // 
            this.UpdateItemBtn.Location = new System.Drawing.Point(16, 78);
            this.UpdateItemBtn.Name = "UpdateItemBtn";
            this.UpdateItemBtn.Size = new System.Drawing.Size(147, 43);
            this.UpdateItemBtn.TabIndex = 2;
            this.UpdateItemBtn.Text = "Cập nhật item";
            this.UpdateItemBtn.UseVisualStyleBackColor = true;
            this.UpdateItemBtn.Click += new System.EventHandler(this.UpdateItemBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Location = new System.Drawing.Point(16, 140);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(147, 43);
            this.DeleteItemBtn.TabIndex = 1;
            this.DeleteItemBtn.Text = "Xóa item";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(16, 15);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(147, 43);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "Thêm mới ";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(74, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 327);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StudentClasscbb);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(460, 43);
            this.panel6.TabIndex = 3;
            // 
            // StudentClasscbb
            // 
            this.StudentClasscbb.FormattingEnabled = true;
            this.StudentClasscbb.Location = new System.Drawing.Point(117, 6);
            this.StudentClasscbb.Name = "StudentClasscbb";
            this.StudentClasscbb.Size = new System.Drawing.Size(340, 33);
            this.StudentClasscbb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Studentdtp);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 202);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 43);
            this.panel5.TabIndex = 2;
            // 
            // Studentdtp
            // 
            this.Studentdtp.Location = new System.Drawing.Point(118, 9);
            this.Studentdtp.Name = "Studentdtp";
            this.Studentdtp.Size = new System.Drawing.Size(339, 30);
            this.Studentdtp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.StudentAddresstxb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 43);
            this.panel4.TabIndex = 2;
            // 
            // StudentAddresstxb
            // 
            this.StudentAddresstxb.Location = new System.Drawing.Point(117, 6);
            this.StudentAddresstxb.Name = "StudentAddresstxb";
            this.StudentAddresstxb.Size = new System.Drawing.Size(340, 30);
            this.StudentAddresstxb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.StudentFullNametxb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 43);
            this.panel3.TabIndex = 2;
            // 
            // StudentFullNametxb
            // 
            this.StudentFullNametxb.Location = new System.Drawing.Point(117, 6);
            this.StudentFullNametxb.Name = "StudentFullNametxb";
            this.StudentFullNametxb.Size = new System.Drawing.Size(340, 30);
            this.StudentFullNametxb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudentCodetxb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 43);
            this.panel1.TabIndex = 0;
            // 
            // StudentCodetxb
            // 
            this.StudentCodetxb.Location = new System.Drawing.Point(117, 6);
            this.StudentCodetxb.Name = "StudentCodetxb";
            this.StudentCodetxb.Size = new System.Drawing.Size(340, 30);
            this.StudentCodetxb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 779);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox StudentAddresstxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox StudentFullNametxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentCodetxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UpdateItemBtn;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DateTimePicker Studentdtp;
        private System.Windows.Forms.ListView StudentListlv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox StudentClasscbb;
    }
}


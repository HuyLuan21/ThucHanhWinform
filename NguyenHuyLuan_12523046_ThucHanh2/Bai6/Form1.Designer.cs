﻿namespace Bai6
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
            this.KhoaTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.Findtxb = new System.Windows.Forms.TextBox();
            this.Findbtn = new System.Windows.Forms.Button();
            this.StudentLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // KhoaTreeView
            // 
            this.KhoaTreeView.Location = new System.Drawing.Point(12, 97);
            this.KhoaTreeView.Name = "KhoaTreeView";
            this.KhoaTreeView.Size = new System.Drawing.Size(456, 594);
            this.KhoaTreeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // Findtxb
            // 
            this.Findtxb.Location = new System.Drawing.Point(582, 33);
            this.Findtxb.Name = "Findtxb";
            this.Findtxb.Size = new System.Drawing.Size(216, 30);
            this.Findtxb.TabIndex = 2;
            // 
            // Findbtn
            // 
            this.Findbtn.Location = new System.Drawing.Point(804, 30);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 37);
            this.Findbtn.TabIndex = 3;
            this.Findbtn.Text = "Tìm";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // StudentLV
            // 
            this.StudentLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.StudentLV.GridLines = true;
            this.StudentLV.HideSelection = false;
            this.StudentLV.Location = new System.Drawing.Point(490, 97);
            this.StudentLV.Name = "StudentLV";
            this.StudentLV.Size = new System.Drawing.Size(389, 594);
            this.StudentLV.TabIndex = 4;
            this.StudentLV.UseCompatibleStateImageBehavior = false;
            this.StudentLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 191;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lớp";
            this.columnHeader2.Width = 191;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 703);
            this.Controls.Add(this.StudentLV);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.Findtxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KhoaTreeView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView KhoaTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Findtxb;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.ListView StudentLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

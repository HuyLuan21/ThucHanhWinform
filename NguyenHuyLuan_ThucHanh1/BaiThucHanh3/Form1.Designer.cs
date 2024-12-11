namespace BaiThucHanh3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HistoriesCbb = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.QuantityEvenBtn = new System.Windows.Forms.Button();
            this.QuantityPrimeBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HistoriesCbb);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.txbInput);
            this.groupBox1.Location = new System.Drawing.Point(69, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // HistoriesCbb
            // 
            this.HistoriesCbb.FormattingEnabled = true;
            this.HistoriesCbb.Location = new System.Drawing.Point(8, 103);
            this.HistoriesCbb.Name = "HistoriesCbb";
            this.HistoriesCbb.Size = new System.Drawing.Size(372, 30);
            this.HistoriesCbb.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(267, 35);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(113, 47);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Cập nhật";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(6, 44);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(255, 30);
            this.txbInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBox);
            this.groupBox2.Location = new System.Drawing.Point(488, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 22;
            this.ListBox.Location = new System.Drawing.Point(15, 29);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(360, 158);
            this.ListBox.TabIndex = 0;
            // 
            // TotalBtn
            // 
            this.TotalBtn.Location = new System.Drawing.Point(488, 292);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(397, 47);
            this.TotalBtn.TabIndex = 2;
            this.TotalBtn.Text = "Tổng các ước số";
            this.TotalBtn.UseVisualStyleBackColor = true;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // QuantityEvenBtn
            // 
            this.QuantityEvenBtn.Location = new System.Drawing.Point(488, 352);
            this.QuantityEvenBtn.Name = "QuantityEvenBtn";
            this.QuantityEvenBtn.Size = new System.Drawing.Size(397, 47);
            this.QuantityEvenBtn.TabIndex = 3;
            this.QuantityEvenBtn.Text = "Số lượng các ước số chẵn";
            this.QuantityEvenBtn.UseVisualStyleBackColor = true;
            this.QuantityEvenBtn.Click += new System.EventHandler(this.QuantityEvenBtn_Click);
            // 
            // QuantityPrimeBtn
            // 
            this.QuantityPrimeBtn.Location = new System.Drawing.Point(488, 414);
            this.QuantityPrimeBtn.Name = "QuantityPrimeBtn";
            this.QuantityPrimeBtn.Size = new System.Drawing.Size(397, 47);
            this.QuantityPrimeBtn.TabIndex = 4;
            this.QuantityPrimeBtn.Text = "Số lượng các ước số nguyên tố";
            this.QuantityPrimeBtn.UseVisualStyleBackColor = true;
            this.QuantityPrimeBtn.Click += new System.EventHandler(this.QuantityPrimeBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(335, 414);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(131, 47);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Xóa";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.QuantityPrimeBtn);
            this.Controls.Add(this.QuantityEvenBtn);
            this.Controls.Add(this.TotalBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Combobox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Button QuantityEvenBtn;
        private System.Windows.Forms.Button QuantityPrimeBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox HistoriesCbb;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox txbInput;
    }
}


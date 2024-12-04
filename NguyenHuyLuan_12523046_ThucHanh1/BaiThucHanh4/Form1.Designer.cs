namespace BaiThucHanh4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstNumtxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastNumtxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChiaRadiobtn = new System.Windows.Forms.RadioButton();
            this.NhanRadiobtn = new System.Windows.Forms.RadioButton();
            this.TruRadiobtn = new System.Windows.Forms.RadioButton();
            this.CongRadiobtn = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Resulttxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstNumtxb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(253, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 62);
            this.panel1.TabIndex = 0;
            // 
            // FirstNumtxb
            // 
            this.FirstNumtxb.Location = new System.Drawing.Point(112, 18);
            this.FirstNumtxb.Name = "FirstNumtxb";
            this.FirstNumtxb.Size = new System.Drawing.Size(456, 30);
            this.FirstNumtxb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LastNumtxb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(253, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 62);
            this.panel2.TabIndex = 2;
            // 
            // LastNumtxb
            // 
            this.LastNumtxb.Location = new System.Drawing.Point(112, 18);
            this.LastNumtxb.Name = "LastNumtxb";
            this.LastNumtxb.Size = new System.Drawing.Size(456, 30);
            this.LastNumtxb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChiaRadiobtn);
            this.groupBox1.Controls.Add(this.NhanRadiobtn);
            this.groupBox1.Controls.Add(this.TruRadiobtn);
            this.groupBox1.Controls.Add(this.CongRadiobtn);
            this.groupBox1.Location = new System.Drawing.Point(253, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // ChiaRadiobtn
            // 
            this.ChiaRadiobtn.AutoSize = true;
            this.ChiaRadiobtn.Location = new System.Drawing.Point(473, 40);
            this.ChiaRadiobtn.Name = "ChiaRadiobtn";
            this.ChiaRadiobtn.Size = new System.Drawing.Size(68, 26);
            this.ChiaRadiobtn.TabIndex = 3;
            this.ChiaRadiobtn.Text = "Chia";
            this.ChiaRadiobtn.UseVisualStyleBackColor = true;
            // 
            // NhanRadiobtn
            // 
            this.NhanRadiobtn.AutoSize = true;
            this.NhanRadiobtn.Location = new System.Drawing.Point(295, 40);
            this.NhanRadiobtn.Name = "NhanRadiobtn";
            this.NhanRadiobtn.Size = new System.Drawing.Size(72, 26);
            this.NhanRadiobtn.TabIndex = 2;
            this.NhanRadiobtn.Text = "Nhân";
            this.NhanRadiobtn.UseVisualStyleBackColor = true;
            // 
            // TruRadiobtn
            // 
            this.TruRadiobtn.AutoSize = true;
            this.TruRadiobtn.Location = new System.Drawing.Point(157, 40);
            this.TruRadiobtn.Name = "TruRadiobtn";
            this.TruRadiobtn.Size = new System.Drawing.Size(60, 26);
            this.TruRadiobtn.TabIndex = 1;
            this.TruRadiobtn.Text = "Trừ";
            this.TruRadiobtn.UseVisualStyleBackColor = true;
            // 
            // CongRadiobtn
            // 
            this.CongRadiobtn.AutoSize = true;
            this.CongRadiobtn.Location = new System.Drawing.Point(21, 40);
            this.CongRadiobtn.Name = "CongRadiobtn";
            this.CongRadiobtn.Size = new System.Drawing.Size(77, 26);
            this.CongRadiobtn.TabIndex = 0;
            this.CongRadiobtn.Text = "Cộng ";
            this.CongRadiobtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Resulttxb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(253, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 62);
            this.panel3.TabIndex = 2;
            // 
            // Resulttxb
            // 
            this.Resulttxb.Location = new System.Drawing.Point(112, 18);
            this.Resulttxb.Name = "Resulttxb";
            this.Resulttxb.Size = new System.Drawing.Size(456, 30);
            this.Resulttxb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FirstNumtxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LastNumtxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CongRadiobtn;
        private System.Windows.Forms.RadioButton ChiaRadiobtn;
        private System.Windows.Forms.RadioButton NhanRadiobtn;
        private System.Windows.Forms.RadioButton TruRadiobtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Resulttxb;
        private System.Windows.Forms.Label label3;
    }
}


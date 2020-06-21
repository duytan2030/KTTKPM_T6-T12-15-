namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtMaDoiBong = new System.Windows.Forms.TextBox();
            this.txtTenDoiBong = new System.Windows.Forms.TextBox();
            this.btnThemDoiBong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaDoiBong
            // 
            this.txtMaDoiBong.Location = new System.Drawing.Point(110, 32);
            this.txtMaDoiBong.Name = "txtMaDoiBong";
            this.txtMaDoiBong.Size = new System.Drawing.Size(208, 20);
            this.txtMaDoiBong.TabIndex = 0;
            // 
            // txtTenDoiBong
            // 
            this.txtTenDoiBong.Location = new System.Drawing.Point(110, 75);
            this.txtTenDoiBong.Name = "txtTenDoiBong";
            this.txtTenDoiBong.Size = new System.Drawing.Size(208, 20);
            this.txtTenDoiBong.TabIndex = 0;
            // 
            // btnThemDoiBong
            // 
            this.btnThemDoiBong.Location = new System.Drawing.Point(110, 132);
            this.btnThemDoiBong.Name = "btnThemDoiBong";
            this.btnThemDoiBong.Size = new System.Drawing.Size(75, 23);
            this.btnThemDoiBong.TabIndex = 1;
            this.btnThemDoiBong.Text = "Them";
            this.btnThemDoiBong.UseVisualStyleBackColor = true;
            this.btnThemDoiBong.Click += new System.EventHandler(this.btnThemDoiBong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(243, 132);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ma Doi Bong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Doi Bong";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemDoiBong);
            this.Controls.Add(this.txtTenDoiBong);
            this.Controls.Add(this.txtMaDoiBong);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDoiBong;
        private System.Windows.Forms.TextBox txtTenDoiBong;
        private System.Windows.Forms.Button btnThemDoiBong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
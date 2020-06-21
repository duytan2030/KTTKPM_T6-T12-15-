namespace WindowsFormsApp1
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
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemDoi = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThemCauThu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCauThuID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenCauThu = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDoiBong1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTeam
            // 
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(313, 14);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(157, 21);
            this.cboTeam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hien thi theo du lieu ten doi bong";
            // 
            // btnThemDoi
            // 
            this.btnThemDoi.Location = new System.Drawing.Point(488, 14);
            this.btnThemDoi.Name = "btnThemDoi";
            this.btnThemDoi.Size = new System.Drawing.Size(31, 23);
            this.btnThemDoi.TabIndex = 2;
            this.btnThemDoi.Text = "+";
            this.btnThemDoi.UseVisualStyleBackColor = true;
            this.btnThemDoi.Click += new System.EventHandler(this.btnThemDoi_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(525, 14);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(132, 23);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hien Thi Cau Thu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThemCauThu
            // 
            this.btnThemCauThu.Location = new System.Drawing.Point(252, 298);
            this.btnThemCauThu.Name = "btnThemCauThu";
            this.btnThemCauThu.Size = new System.Drawing.Size(75, 23);
            this.btnThemCauThu.TabIndex = 2;
            this.btnThemCauThu.Text = "Them";
            this.btnThemCauThu.UseVisualStyleBackColor = true;
            this.btnThemCauThu.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(359, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(459, 298);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cap Nhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(564, 298);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtCauThuID
            // 
            this.txtCauThuID.Location = new System.Drawing.Point(90, 222);
            this.txtCauThuID.Name = "txtCauThuID";
            this.txtCauThuID.Size = new System.Drawing.Size(224, 20);
            this.txtCauThuID.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 261);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTenCauThu
            // 
            this.txtTenCauThu.Location = new System.Drawing.Point(407, 222);
            this.txtTenCauThu.Name = "txtTenCauThu";
            this.txtTenCauThu.Size = new System.Drawing.Size(250, 20);
            this.txtTenCauThu.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(407, 261);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(250, 20);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ma Cau Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ma doi bong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "So dien thoai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ten Cau Thu";
            // 
            // cboDoiBong1
            // 
            this.cboDoiBong1.FormattingEnabled = true;
            this.cboDoiBong1.Location = new System.Drawing.Point(91, 298);
            this.cboDoiBong1.Name = "cboDoiBong1";
            this.cboDoiBong1.Size = new System.Drawing.Size(155, 21);
            this.cboDoiBong1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 338);
            this.Controls.Add(this.cboDoiBong1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenCauThu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCauThuID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemCauThu);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThemDoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemDoi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThemCauThu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCauThuID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenCauThu;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDoiBong1;
    }
}


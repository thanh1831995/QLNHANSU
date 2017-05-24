namespace WinFrom_QuanLyNhanSu
{
    partial class frmFind
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
            this.txt_khoatk = new System.Windows.Forms.TextBox();
            this.ccb_phongban = new System.Windows.Forms.ComboBox();
            this.rbt_ma = new System.Windows.Forms.RadioButton();
            this.rbt_ten = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập khóa tìm kiếm:";
            // 
            // txt_khoatk
            // 
            this.txt_khoatk.Location = new System.Drawing.Point(379, 59);
            this.txt_khoatk.Name = "txt_khoatk";
            this.txt_khoatk.Size = new System.Drawing.Size(177, 20);
            this.txt_khoatk.TabIndex = 2;
            // 
            // ccb_phongban
            // 
            this.ccb_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_phongban.FormattingEnabled = true;
            this.ccb_phongban.Location = new System.Drawing.Point(111, 59);
            this.ccb_phongban.Name = "ccb_phongban";
            this.ccb_phongban.Size = new System.Drawing.Size(132, 21);
            this.ccb_phongban.TabIndex = 3;
            // 
            // rbt_ma
            // 
            this.rbt_ma.AutoSize = true;
            this.rbt_ma.Location = new System.Drawing.Point(582, 86);
            this.rbt_ma.Name = "rbt_ma";
            this.rbt_ma.Size = new System.Drawing.Size(40, 17);
            this.rbt_ma.TabIndex = 4;
            this.rbt_ma.TabStop = true;
            this.rbt_ma.Text = "Mã";
            this.rbt_ma.UseVisualStyleBackColor = true;
            // 
            // rbt_ten
            // 
            this.rbt_ten.AutoSize = true;
            this.rbt_ten.Location = new System.Drawing.Point(638, 86);
            this.rbt_ten.Name = "rbt_ten";
            this.rbt_ten.Size = new System.Drawing.Size(44, 17);
            this.rbt_ten.TabIndex = 5;
            this.rbt_ten.TabStop = true;
            this.rbt_ten.Text = "Tên";
            this.rbt_ten.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm kiếm theo :";
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(111, 86);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(132, 17);
            this.cb_all.TabIndex = 7;
            this.cb_all.Text = "Tất cả các phòng ban";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(787, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________________________" +
    "_________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(266, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập yêu cầu tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(296, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kết quả tìm kiếm";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(17, 192);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.ReadOnly = true;
            this.dgv_nhanvien.Size = new System.Drawing.Size(780, 270);
            this.dgv_nhanvien.TabIndex = 11;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Find.Location = new System.Drawing.Point(706, 53);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 32);
            this.btn_Find.TabIndex = 12;
            this.btn_Find.Text = "Tìm";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(706, 468);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 503);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_ten);
            this.Controls.Add(this.rbt_ma);
            this.Controls.Add(this.ccb_phongban);
            this.Controls.Add(this.txt_khoatk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFind";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_khoatk;
        private System.Windows.Forms.ComboBox ccb_phongban;
        private System.Windows.Forms.RadioButton rbt_ma;
        private System.Windows.Forms.RadioButton rbt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_thoat;
    }
}
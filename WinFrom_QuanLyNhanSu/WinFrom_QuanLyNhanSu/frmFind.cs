using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrom_QuanLyNhanSu.Class;

namespace WinFrom_QuanLyNhanSu
{
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();
            cb_all.Checked = true;
            Load_cbb();
            rbt_ten.Checked = true;
            initGrid();
        }
        protected void initGrid()
        {
            dgv_nhanvien.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaNhanVien";
            cl.HeaderText = "MÃ";
            cl.Width = 90;
            dgv_nhanvien.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenNhanVien";
            cl.HeaderText = "HỌ VÀ TÊN";
            cl.Width = 160;
            dgv_nhanvien.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgaySinh";
            cl.HeaderText = "NGÀY SINH";
            cl.Width = 100;
            dgv_nhanvien.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Luong";
            cl.HeaderText = "LƯƠNG";
            cl.Width = 100;
            dgv_nhanvien.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "QueQuan";
            cl.HeaderText = "QUÊ QUÁN";
            cl.Width = 180;
            dgv_nhanvien.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaPhong";
            cl.HeaderText = "MÃ PHÒNG BAN";
            cl.Width = 120;
            dgv_nhanvien.Columns.Add(cl);
        }
        public void Load_cbb()
        {
            int kt = new phongban_b().Load_DropDowList(ccb_phongban);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                this.Close();
            }
        }
        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_all.Checked == true) ccb_phongban.Enabled = false;
            else ccb_phongban.Enabled = true;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string phongban;
            bool check = false;
            if (cb_all.Checked == true) phongban = null;
            else phongban = ccb_phongban.SelectedValue.ToString();
            if (rbt_ma.Checked == true) check = true;
            int kt = new nhanvien_b().select(dgv_nhanvien, phongban, txt_khoatk.Text, check);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                return;
            }
            if (kt == -2)
            {
                MessageBox.Show("Lỗi tìm kiếm !");
                return;
            }
        }
    }
}

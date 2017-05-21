using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom_QuanLyNhanSu
{
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            con = new SqlConnection("server = 8470P-PC\\CNTTSQL;database = QLNhanSu;integrated security = SSPI");
        }
        SqlConnection con;
        string CurrID;
        void Hienthi()
        {
            con.Open();
            string str = string.Format("select nv.MaNhanVien as[Id],nv.TenNhanVien as[HoTen],nv.NgaySinh as [NgaySinh],nv.QueQuan as[QueQuan],nv.luong as[Luong],nv.MaPhong as[MaPhong] from NhanVien nv");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvlstNV.DataSource = dt;
            con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void dgvlstNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvlstNV.CurrentRow.Cells[0].Value.ToString();
            CurrID = txtID.Text;
            txtHoTen.Text = dgvlstNV.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = ((DateTime)dgvlstNV.CurrentRow.Cells[2].Value).ToString("MM/dd/yyyy");
            txtQueQuan.Text = dgvlstNV.CurrentRow.Cells[3].Value.ToString();
            txtLuong.Text = dgvlstNV.CurrentRow.Cells[4].Value.ToString();
            txtMaPhong.Text = dgvlstNV.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}

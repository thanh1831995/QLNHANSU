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
            con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        SqlConnection con;
      
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand add = new SqlCommand("themnv", con);
            add.Parameters.Add(new SqlParameter("@MaNhanVien", txtID.Text));
            add.Parameters.Add(new SqlParameter("@TenNhanVien", txtHoTen.Text));
            add.Parameters.Add(new SqlParameter("@NgaySinh", dtpNgaySinh.Value));
            add.Parameters.Add(new SqlParameter("@Luong", txtLuong.Text));
            add.Parameters.Add(new SqlParameter("@QueQuan", txtLuong.Text));
            add.Parameters.Add(new SqlParameter("@MaPhong", txtMaPhong.Text));
            add.CommandType = CommandType.StoredProcedure;
            try
            {

                add.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Nhập lỗi ");

            }

            con.Close();
            Hienthi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom_QuanLyNhanSu.Class
{
    class nhanvien_b
    {
        public int select(DataGridView dgv, string phongban, string khoa, bool check)
        {
            string sql = null;
            if (phongban==null)
            {
                if (check == true)
                {
                    sql = "SELECT *  FROM [dbo].[NhanVien] WHERE MaNhanVien like '%'+@khoa+'%'";
                }
                else sql = "SELECT *  FROM [dbo].[NhanVien] WHERE TenNhanVien like '%'+@khoa+'%'";
            }
            else
            {
                if (check == true)
                {
                    sql = "SELECT *  FROM [dbo].[NhanVien] WHERE MaPhong = @phongban AND MaNhanVien like '%'+@khoa+'%' ";
                }
                else sql = "SELECT *  FROM [dbo].[NhanVien] WHERE MaPhong = @phongban AND TenNhanVien like '%'+@khoa+'%' ";
            }
            SqlConnection conn = Connection.Conn();
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.Add("@khoa", SqlDbType.NVarChar).SqlValue = khoa;
            if (!string.IsNullOrEmpty(phongban)) cm.Parameters.Add("@phongban", SqlDbType.NVarChar).SqlValue = phongban;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            conn.Close();
            try
            {
                da.Fill(ds, "NhanVien");
            }
            catch
            {
                return -2;
            }
            dgv.DataSource = ds.Tables["NhanVien"].DefaultView;
            dgv.Refresh();
            return 1;
        }
    }
}

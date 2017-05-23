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
    class phongban_b
    {
        public int Load_DropDowList(ComboBox cbb)
        {
            SqlConnection conn = Connection.Conn();
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlDataAdapter da = new SqlDataAdapter("Select * from PhongBan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbb.DataSource = dt;
            cbb.DisplayMember = "TenPhong";
            cbb.ValueMember = "MaPhong";
            return 1;
        }
    }
}

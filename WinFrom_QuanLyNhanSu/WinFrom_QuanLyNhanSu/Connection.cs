﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrom_QuanLyNhanSu
{
    class Connection
    {
        public static SqlConnection Conn()
        {
            string connString = @"Data Source=SUPER\SQLEXPRESS ;Initial Catalog=TTN_quanlynhansu ;Persist Security Info=True; User ID=detai6 ;Password=detai6 ";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}

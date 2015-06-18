using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net
{
    public class ENVNconnector
    {
        public List<string> getListTenChuDe()
        {
            string connStr = "Data Source=.\\SQLSERVER2K12;Initial Catalog=ENVN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            string sqlQuery = "select * from thematic"; // sql query

            List<string> danhSachTenChuDe = new List<string>(); // list lưu danh sách tên chuyên đề

            if (conn != null) // nếu biến conn != null     -> kết nối csdl thành công
            {
                Console.Write("Ket noi CSDL ok");
                conn.Open();
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) // chỉ đọc khi reader còn có dữ liệu
                {
                    string thematicName = reader["ThematicName"].ToString();
                    danhSachTenChuDe.Add(thematicName);
                }
            }
            else
            {
                Console.Write("\nKet noi CSDL that bai, xem lai connection string ");
            }
            return danhSachTenChuDe;
        }
    }
}

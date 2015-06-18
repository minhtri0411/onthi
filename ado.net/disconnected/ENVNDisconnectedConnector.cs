using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net.disconnected
{
    public class ENVNDisconnectedConnector
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
                DataSet ds = new DataSet(); // 1 data set có thể chứa nhiều data table
                SqlDataAdapter sda = new SqlDataAdapter(command); // dùng SQL DATA ADAPTER để lấy dữ liệu   -> DISCONNECTED
                conn.Close();
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        string thematicName = dr["ThematicName"].ToString();
                        danhSachTenChuDe.Add(thematicName);
                    }
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

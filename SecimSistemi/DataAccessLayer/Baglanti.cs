using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection Conn=new SqlConnection("Data Source=FatihBuzac\\SQLEXPRESS;Initial Catalog=DbSecim;Integrated Security=True");
    }
}

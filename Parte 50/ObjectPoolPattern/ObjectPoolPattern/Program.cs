using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ObjectPoolPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=true; Pooling=false;";
            var pool = new SqlConnectionPool(constr);
            var con = pool.checkOut();
            var SQL = "select * from Products";
            var cmd = new SqlCommand(SQL, con);
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[1].ToString());
            }
            dr.Close();
            pool.checkIn(con);
            Console.ReadLine();
        }
    }
}

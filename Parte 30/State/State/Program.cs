using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection(new ConnectionOpened());
            con.Open();
            con.Close();
            Console.ReadLine();
        }
    }
}

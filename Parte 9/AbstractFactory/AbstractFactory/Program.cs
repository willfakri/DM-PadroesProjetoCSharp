using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = new SQLConnection();
            con.Open();
            var cmd = new SQLCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}

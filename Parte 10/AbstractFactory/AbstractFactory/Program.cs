using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            //new [NomeDaFabrica] -> poderia vir de um arquivo de configuração
            DBFactory db = new OracleFactory();
            var con = db.createConnection();            
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollywood
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailSender = new EmailSender();
            emailSender.SendEmail(new EmailConstructor(), "Olá Mundo", "Olá Mundo - Teste email");
            Console.ReadLine();
        }
    }
}

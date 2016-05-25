using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá Mundo");
            var factory = OlaMundoSingleton.getInstance().getFactory();
            var sub = factory.createSubject();
            sub.attach(factory.createObserver());
            var cmd = factory.createCommand(sub);
            cmd.execute();
        }
    }
}

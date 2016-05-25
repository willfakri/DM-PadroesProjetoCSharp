using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Context
            var ctx = new Context();

            // Normalmente utilizado com uma árvore
            var list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpretação das expressões da árvore
            // usando o padrão Interpreter
            foreach(AbstractExpression exp in list)            
                exp.Interpret(ctx);
            // pausa
            Console.ReadLine();
        }
    }
}

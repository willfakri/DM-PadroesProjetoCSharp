using System;

namespace Interpreter
{
    // "Context"
    public class Context
    {

    }

    // "Abstract Expression"
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    // "Terminal Expression"
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Chamado método TerminalExpression.Interpret()");
        }
    }

    // "Nonterminal Expression"
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Chamado método NonterminalExpression.Interpret()");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var shapes = new List<IShape>
        {
            new Circle(),
            new Square(),
        };

            var visitor = new DrawVisitor();

            foreach (var shape in shapes)
            {
                shape.Accept(visitor);
            }
        }
    }

}

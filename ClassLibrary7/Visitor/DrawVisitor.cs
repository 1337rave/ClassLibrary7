using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Visitor
{
    public class DrawVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("Малюємо коло...");
        }

        public void VisitSquare(Square square)
        {
            Console.WriteLine("Малюємо квадрат...");
        }
    }

}
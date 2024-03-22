using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Console.WriteLine("The identical client code can function with various subclasses.:");
            AbstractClass abstractClass = new ConcreteClass();
            abstractClass.TemplateMethod();
        }
    }
}

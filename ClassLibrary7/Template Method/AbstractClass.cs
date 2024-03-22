using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Template_Method
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass declares: The majority of tasks are being carried out by me.");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass mentions: However, I allow subclasses to modify certain operations.");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass states: Nonetheless, I am still responsible for the majority of the tasks.");
        }

        protected abstract void RequiredOperations1();
        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}

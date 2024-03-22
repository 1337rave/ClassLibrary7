using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Visitor
{
    public class Circle : IShape
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7.Visitor
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Visitor
{
    public interface IVisitable
    {
        double Aceptar(IVisitor visitor);
    }
}

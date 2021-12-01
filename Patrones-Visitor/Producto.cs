using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Visitor
{
    public abstract class Producto : IVisitable
    {
        public double Precio { get; set; }

        public  abstract double Aceptar(IVisitor visitor);
    }
}

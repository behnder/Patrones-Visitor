using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Visitor
{
    public interface IVisitor 
    {
        public double Visitar(ProductoClase1 productoClase1);
        public double Visitar(ProductoClase2 productoClase2);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Visitor
{
    public class ProductoClase2 : Producto
    {
        public override double Aceptar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}

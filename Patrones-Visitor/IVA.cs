using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Visitor
{
    public class IVA : IVisitor
    {

        private double impuestoClase1 = 1.12d;
        private double impuestoClase2 = 1.105d;


        public double Visitar(ProductoClase1 productoClase1)
        {
            return Math.Round(productoClase1.Precio * impuestoClase1, 2);
        }
        public double Visitar(ProductoClase2 productoClase2)
        {
            return Math.Round(productoClase2.Precio * impuestoClase2, 2); 
        }
    }
}

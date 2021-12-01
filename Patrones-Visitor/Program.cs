using System;

namespace Patrones_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new ProductoClase1();
            producto.Precio = 51;
            producto.Precio = producto.Aceptar(new IVA());
            Console.WriteLine($"precio con iva: {producto.Precio}");

            Console.WriteLine("==========");
            Producto producto2 = new ProductoClase2();
            producto2.Precio = 45;
            producto2.Precio = producto2.Aceptar(new IVA());
            Console.WriteLine($"precio con iva: {producto2.Precio}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Carrito
    {

        private List<Producto> productosEnCarrito;

        public Carrito()
        {
            productosEnCarrito = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productosEnCarrito.Add(producto);
        }

        public int PrecioTotal()
        {
            int precioTotal = 0;
            foreach (var producto in productosEnCarrito)
            {
                precioTotal += producto.getPrecio();
            }
            return precioTotal;
        }


        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del Carrito de Compras:");
            foreach (var producto in productosEnCarrito)
            {
                Console.WriteLine(producto.getCaracteristicas());
            }
            Console.WriteLine("Precio Total: " + PrecioTotal());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public virtual string ObtenerCaracteristicas()
        {
            return "Nombre: " + Nombre + ", Precio: " + Precio;
        }

    }
}

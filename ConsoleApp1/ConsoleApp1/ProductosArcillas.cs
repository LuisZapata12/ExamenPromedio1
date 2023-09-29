using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProductosArcillas: Producto
    {
        private string nombre;
        private String tamaño;
        private String material;
        private String color;
        private int precio;
        public ProductosArcillas(String nombre, String tamaño, String material, String color, int precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.material = material;
            this.color = color;
            this.precio = precio;

        }
        public String getCaracteristicas()
        {
            return "Producto de tela: " + nombre + ", Tamaño: " + tamaño + ", Material: " + material + ", Color: " + color;
        }
        public int getPrecio()
        {
            return precio;
        }


    }
}

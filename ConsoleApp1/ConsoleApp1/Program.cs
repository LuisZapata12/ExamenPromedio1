using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Carrito carrito = new Carrito();


            List<Producto> listaProductos = new List<Producto>
        {
            new ProductosTela("Camisa de tela", "M", "Algodón", "Azul", 20),
            new ProductosArcillas("Jarrón de arcilla", "Grande", "Terracota", "Rojo", 30)
        };

            while (true)
            {
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Añadir un producto al carrito");
                Console.WriteLine("2. Ver el contenido del carrito");
                Console.WriteLine("3. Finalizar la compra");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("Lista de productos disponibles:");
                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {listaProductos[i].getCaracteristicas()}");
                    }

                    Console.WriteLine("Selecciona un producto por su número:");
                    int seleccion = int.Parse(Console.ReadLine()) - 1;

                    if (seleccion >= 0 && seleccion < listaProductos.Count)
                    {
                        Producto productoSeleccionado = listaProductos[seleccion];
                        Console.WriteLine("Características del producto:");
                        Console.WriteLine(productoSeleccionado.getCaracteristicas());
                        Console.WriteLine("Precio: " + productoSeleccionado.getPrecio());

                        Console.WriteLine("¿Quieres añadir este producto al carrito? (S/N)");
                        string respuesta = Console.ReadLine().ToUpper();
                        if (respuesta == "S")
                        {
                            carrito.AgregarProducto(productoSeleccionado);
                            Console.WriteLine("Producto añadido al carrito.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Selección inválida.");
                    }
                }
                else if (opcion == "2")
                {
                    carrito.MostrarContenido();
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Compra finalizada. Resumen de la compra:");
                    carrito.MostrarContenido();
                    Console.WriteLine("¿Quieres crear un nuevo carrito de compras? (S/N)");
                    string respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "S")
                    {
                        carrito = new Carrito();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (opcion == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                }
            }

            Console.WriteLine("Gracias por utilizar el sistema de compras. ¡Hasta luego!");
        }
    }
}

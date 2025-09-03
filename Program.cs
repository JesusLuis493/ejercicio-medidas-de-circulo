using System;

namespace Ejemplocirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio = 0;
            Console.WriteLine("[Programa que muestre la clase circulo]");
            NuevaClass circulo2 = new NuevaClass(radio);
            //set
            
            Console.WriteLine("[Dame un radio]");
            circulo2.radio = double.Parse(Console.ReadLine());
            //contructor de parametros
            
            
            //double perimetro = 2 * 3.1416 * circulo2.radio;
            //area
            
            //cambiar radio
            
            int opc = 0;
            do
            {
                Console.WriteLine("[Menu de opciones]");
                Console.WriteLine("1. [Cambiar radio]");
                Console.WriteLine("2. [Mostrar perimetro]");
                Console.WriteLine("3. [Mostrar area]");
                Console.WriteLine("4. [mostrar radio]");
                Console.WriteLine("5. [Salir]");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Cambiando el radio del circulo2");
                        double nuevoRadio = double.Parse(Console.ReadLine());
                        circulo2.cambiarRadio(nuevoRadio);
                        Console.WriteLine("El nuevo radio del circulo2 es: " + circulo2.radio);

                        break;
                    case 2:
                        double perimetro = circulo2.perimetro();
                        Console.WriteLine("El perimetro del circulo2 es: " + perimetro);
                        break;
                    case 3:
                       double area = circulo2.area();
                        Console.WriteLine("El area del circulo2 es: " + area);
                        break;
                    case 4:
                        Console.WriteLine("El radio del circulo2 es: " + circulo2.radio);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opc!= 5);
        }
    }
}
//para depurar el proyecto usar comando:
// "> .NET: Generate Assets for Build and Debug"
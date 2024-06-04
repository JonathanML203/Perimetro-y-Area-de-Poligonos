using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimetroPoligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué deseas calcular?");
            Console.WriteLine("1. Perímetro");
            Console.WriteLine("2. Área");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularPerimetro();
                    break;
                case 2:
                    CalcularArea();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void CalcularPerimetro()
        {
            Console.Write("Introduce el número de lados del polígono regular: ");
            int numLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la longitud de un lado del polígono regular: ");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            double perimetro = numLados * longitudLado;
            Console.WriteLine($"El perímetro del polígono regular es {perimetro}");
        }

        static void CalcularArea()
        {
            Console.Write("Introduce el número de lados del polígono regular: ");
            int numLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la longitud de un lado del polígono regular: ");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el apotema (distancia del centro al lado) del polígono regular: ");
            double apotema = Convert.ToDouble(Console.ReadLine());

            double perimetro = numLados * longitudLado;
            double area = (perimetro * apotema) / 2;
            Console.WriteLine($"El área del polígono regular es {area}");
        }
    }
}

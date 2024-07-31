using manipular_texto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manupular_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("""
            Convertir a:
            1.- Matusculas
            2.- Minusculas
            3.- Capitalizar texto
            4.- Salir del programa
            """);
            string input = Console.ReadLine();
            int option;
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out option))
            {
                Console.WriteLine("Error, ingresaseste un valor no numerico");
            }
            else
            {
                option = int.Parse(input);
                Opcion_a_convertir(option);
            }

        }
        public static void Opcion_a_convertir(int option)
        {
            try
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Escribe");
                        string texto1 = Upper.Uppercase(Console.ReadLine());
                        Console.WriteLine(texto1);
                        break;

                    case 2:
                        Console.WriteLine("Escribe");
                        string texto2 = Lower.LowerCase(Console.ReadLine());
                        Console.WriteLine(texto2);
                        break;
                    case 3:
                        Console.WriteLine("Escribe");
                        string texto3 = Capitalizar.Capitalizar_texto(Console.ReadLine());
                        Console.WriteLine(texto3);
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor correcto");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }

        }
    }
}

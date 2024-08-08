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
            4.- Convertir a binaryo
            5.- Convertir binario a texto
            6.- Salir del programa
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
                Opcion_a_convertir.Opcion(option);
            }          
        }
    }
}

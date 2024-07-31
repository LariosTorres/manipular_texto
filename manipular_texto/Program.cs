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
                3.- Salir del programa
                """);
            int option = int.Parse(Console.ReadLine());
            
            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Escribe");
                        string txt1 = Upper.Uppercase(Console.ReadLine());
                        Console.WriteLine(txt1);
                        break;

                    case 2:
                        Console.WriteLine("Escribe");
                        string txt2 = Lower.LowerCase(Console.ReadLine());
                        Console.WriteLine(txt2);
                        break;

                    default:
                        Console.WriteLine("Ingrese un valor correcto");
                        break;
                }
                Console.WriteLine("""
                Convertir a:
                1.- Matusculas
                2.- Minusculas
                3.- Salir del programa
                """);
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}

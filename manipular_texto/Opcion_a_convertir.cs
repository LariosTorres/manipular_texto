using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipular_texto
{
    public class Opcion_a_convertir
    {
        public static void Opcion(int option)
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
                    case 4:
                        Console.WriteLine("Escribe");
                        string texto4 = Convertir_binario.Convertir(Console.ReadLine());
                        Console.WriteLine(texto4);
                        break;
                    case 5:
                        Console.WriteLine("Escribe");
                        string texto5 = Convertir_binario_texto.Binario_a_texto(Console.ReadLine());
                        Console.WriteLine(texto5);
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

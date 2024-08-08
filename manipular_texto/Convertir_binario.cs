using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace manipular_texto
{
    public class Convertir_binario
    {
        public static string Convertir(string text)
        {
            StringBuilder constructor = new StringBuilder();
            foreach (char c in text.ToCharArray())
            {
                constructor.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return constructor.ToString();
        }
    }
}

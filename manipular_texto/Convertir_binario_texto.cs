using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipular_texto
{
    public class Convertir_binario_texto
    {
        public static string Binario_a_texto(string text)
        {
            List<byte> bytelist = new List<byte>();
            for (int i = 0; i < text.Length; i+= 8)
            {
                bytelist.Add(Convert.ToByte(text.Substring(i, 8),2));
            }
            return Encoding.ASCII.GetString(bytelist.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipular_texto
{
    public class Capitalizar
    {
        public static string Capitalizar_texto(string text)
        {
            TextInfo txt = new CultureInfo("en-US", false).TextInfo;
            
            return txt.ToTitleCase(text);
        }
    }
}

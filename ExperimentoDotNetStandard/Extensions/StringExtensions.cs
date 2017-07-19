using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static string ObterSomenteNumeros(this string self)
        {
            var regexNaoNumero = @"\D";
            var textoSemNumeros = Regex.Replace(self, regexNaoNumero, "");
            return textoSemNumeros;
        }
    }
}

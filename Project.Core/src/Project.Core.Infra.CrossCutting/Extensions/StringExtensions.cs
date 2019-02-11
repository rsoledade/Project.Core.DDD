using System;
using System.Linq;

namespace Project.Core.Infra.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string SomenteNumeros(this string strIn)
        {
            if (!string.IsNullOrEmpty(strIn))
            {
                var somenteNumeros = new String(strIn.Where(c => Char.IsDigit(c)).ToArray());
                return somenteNumeros;
            }

            return "";
        }

        public static string SomenteLetras(this string strIn)
        {
            if (!string.IsNullOrEmpty(strIn))
            {
                var somenteLetras = new String(strIn.Where(c => Char.IsLetter(c)).ToArray());
                return somenteLetras;
            }

            return "";
        }
    }
}

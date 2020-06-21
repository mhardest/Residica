using Servicios.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Facade.Extensions
{
    public static class StringExtension
    {
        public static string Translate(this string word)
        {
            return LanguageManager.Current.Translate(word);
        }
    }
}

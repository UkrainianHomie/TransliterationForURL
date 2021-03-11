using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Transliteration.Service.Services.Interfaces;

/// <summary>
///     First Task
/// </summary>

namespace Transliteration
{
    public class UkToLatTrasliteration : IUkToLatTransliteration
    {
        public static readonly Dictionary<string, string> transliteration = new Dictionary<string, string>();

        public string Transliterate(string text) 
        {
            string modifiedText = text;
            foreach (KeyValuePair<string, string> pair in transliteration) 
            {
                modifiedText = modifiedText.Replace(pair.Key, pair.Value);
            }
            return modifiedText;
        }

        static UkToLatTrasliteration()
        {
            transliteration.Add("зг", "zgh");
            transliteration.Add("Зг", "Zgh");
            transliteration.Add("ь", null);
            transliteration.Add("'", null);

            transliteration.Add("А", "A");
            transliteration.Add("Б", "B");
            transliteration.Add("В", "V");
            transliteration.Add("Г", "H");
            transliteration.Add("Ґ", "G");
            transliteration.Add("Д", "D");
            transliteration.Add("Е", "E");
            transliteration.Add("Є", "Ye");
            transliteration.Add("Ж", "Zh");
            transliteration.Add("З", "Z");
            transliteration.Add("И", "Y");
            transliteration.Add("І", "I");
            transliteration.Add("Ї", "Yi");
            transliteration.Add("Й", "Y");
            transliteration.Add("К", "K");
            transliteration.Add("Л", "L");
            transliteration.Add("М", "M");
            transliteration.Add("Н", "N");
            transliteration.Add("О", "O");
            transliteration.Add("П", "P");
            transliteration.Add("Р", "R");
            transliteration.Add("С", "S");
            transliteration.Add("Т", "T");
            transliteration.Add("У", "U");
            transliteration.Add("Ф", "F");
            transliteration.Add("Х", "Kh");
            transliteration.Add("Ц", "Ts");
            transliteration.Add("Ч", "Ch");
            transliteration.Add("Ш", "Sh");
            transliteration.Add("Щ", "Shch");
            transliteration.Add("Ю", "Yu");
            transliteration.Add("Я", "Ya");

            transliteration.Add("а", "a");
            transliteration.Add("б", "b");
            transliteration.Add("в", "v");
            transliteration.Add("г", "h");
            transliteration.Add("ґ", "g");
            transliteration.Add("д", "d");
            transliteration.Add("е", "e");
            transliteration.Add("є", "ie");
            transliteration.Add("ж", "zh");
            transliteration.Add("з", "z");
            transliteration.Add("и", "y");
            transliteration.Add("і", "i");
            transliteration.Add("ї", "i");
            transliteration.Add("й", "i");
            transliteration.Add("к", "k");
            transliteration.Add("л", "l");
            transliteration.Add("м", "m");
            transliteration.Add("н", "n");
            transliteration.Add("о", "o");
            transliteration.Add("п", "p");
            transliteration.Add("р", "r");
            transliteration.Add("с", "s");
            transliteration.Add("т", "t");
            transliteration.Add("у", "u");
            transliteration.Add("ф", "f");
            transliteration.Add("х", "kh");
            transliteration.Add("ц", "ts");
            transliteration.Add("ч", "ch");
            transliteration.Add("ш", "sh");
            transliteration.Add("щ", "shch");
            transliteration.Add("ю", "iu");
            transliteration.Add("я", "ia");
        }

    }
}

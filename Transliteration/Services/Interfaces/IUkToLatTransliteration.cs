using System;
using System.Collections.Generic;
using System.Text;

namespace Transliteration.Service.Services.Interfaces
{
    public interface IUkToLatTransliteration
    {
        public string Transliterate(string text);
    }
}

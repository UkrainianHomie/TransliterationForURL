using System;
using Transliteration.Service.Services.Interfaces;
using Xunit;
using Transliteration;


namespace TransliterationTests
{
    public class TrasliterationServiceTest
    {
        private readonly IUkToLatTransliteration _trasliterationService;
        public TrasliterationServiceTest() 
        {
            _trasliterationService = new UkToLatTrasliteration();
        }

        [Fact]
        public void  Transliteration()
        {
            Func<string, string> transliterationService;
            transliterationService = _trasliterationService.Transliterate;

            Assert.Equal("Poltava", transliterationService("Полтава"));
            Assert.Equal("Rybchynskyi", transliterationService("Рибчинський"));
            Assert.Equal("Znamianka", transliterationService("Знам'янка"));
            Assert.Equal("Zghorany", transliterationService("Згорани"));
            Assert.Equal("Rozghon", transliterationService("Розгон"));
            Assert.Equal("Andrii", transliterationService("Андрій"));
            Assert.Equal("Borshchahivka", transliterationService("Борщагівка"));
            Assert.Equal("Vinnytsia", transliterationService("Вінниця"));
        }
    }
}

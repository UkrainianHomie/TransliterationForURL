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

            Assert.Equal("Poltava", transliterationService("�������"));
            Assert.Equal("Rybchynskyi", transliterationService("�����������"));
            Assert.Equal("Znamianka", transliterationService("����'����"));
            Assert.Equal("Zghorany", transliterationService("�������"));
            Assert.Equal("Rozghon", transliterationService("������"));
            Assert.Equal("Andrii", transliterationService("�����"));
            Assert.Equal("Borshchahivka", transliterationService("���������"));
            Assert.Equal("Vinnytsia", transliterationService("³�����"));
        }
    }
}

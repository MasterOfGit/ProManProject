using System;
using System.Threading.Tasks;
using ProMan_BusinessLayer.Models;

namespace ProMan_Simulator.Test
{
    public class MaschinenTest : BaseTest
    {
        

        public MaschinenTest()
        {

        }

        public string StartTest()
        {
            return "";
        }

        public string StartGetTest()
        {
            var item = _httphelper.HttpGet<MaschineDto>($"api/maschine/{ID}").Result;

            return "";
        }

        public async Task<string> StartSetTest()
        {
            //await _httphelper.HttpPost($"api/maschine", new MaschineDto()
            //{
            //    Baujahr = DateTime.Now,
            //    Garantie = DateTime.Now.AddYears(5),
            //    Hersteller = "Hersteller 1",
            //    Type = "Type_1",
            //    InventarNummer = 123
            //});

            return "";
        }

        public string StartUpdateTest()
        {
            return "";
        }

        public string StartDeleteTest()
        {
            return "";
        }

        public void ResetTest()
        {
        }

    }
}

using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;

namespace ProMan_Test
{
    public class BusinessLayerTest
    {
        protected IDataProvider dataprovider;

        FertigungDto fertDto = new FertigungDto()
        {
            ID = 1
        };

        FertigungslinieDto fertlinieDto = new FertigungslinieDto()
        {

        };

        UserDto userDto = new UserDto()
        {

        };
        MaschineDto maschdto = new MaschineDto()
        {

        };
        WartungDto wartDto = new WartungDto()
        {

        };
        ReparaturDto repaDto = new ReparaturDto()
        {

        };


        public BusinessLayerTest(string provider)
        {
            dataprovider = new DataProviderFactory(provider).data;
        }

        public void SetTest()
        {
            dataprovider.SetFertigungsDto(fertDto);
            dataprovider.SetFertigungslinieDto(fertlinieDto);
            dataprovider.SetMaschineDto(maschdto);
            dataprovider.SetUserDto(userDto);
            dataprovider.SetWartungDto(wartDto);
            dataprovider.SetReparaturDto(repaDto);

        } 

        public void GetTest()
        {
            
        }

        public void DeleteTest()
        {

        }

        public void UpdateTest()
        {

        }


    }
}

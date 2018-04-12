using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;

namespace ProMan_Test
{
    public class BusinessLayerTest
    {
        protected IDataProvider dataprovider;

        FertigungDto fertDto = new FertigungDto()
        {
            fertigungsID = 1
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
            dataprovider.CreateDataProvider.SetFertigungsDto(fertDto);
            dataprovider.CreateDataProvider.SetFertigungslinieDto(fertlinieDto);
            dataprovider.CreateDataProvider.SetMaschineDto(maschdto);
            dataprovider.CreateDataProvider.SetUserDto(userDto);
            dataprovider.CreateDataProvider.SetWartungDto(wartDto);
            dataprovider.CreateDataProvider.SetReparaturDto(repaDto);

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

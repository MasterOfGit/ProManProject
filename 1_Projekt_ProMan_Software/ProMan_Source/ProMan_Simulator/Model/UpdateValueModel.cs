using ProMan_BusinessLayer.Models;
using ProMan_Simulator.Base;
using ProMan_Simulator.Helper;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProMan_Simulator.Model
{
    public class UpdateValueModel : BaseModel
    {
        private HttpHelper _httphelper;
        private string _type = string.Empty;
        private int _id = 0;

        private ObservableCollection<SetValuesHelper> _updateValues;

        public ObservableCollection<SetValuesHelper> UpdateValues
        {
            get
            {
                return _updateValues;
            }
            set
            {
                _updateValues = value;
                OnPropertyChanged(nameof(UpdateValues));
            }
        }

        private AsyncCommand m_UpdateButtonCommand;
        public AsyncCommand UpdateButtonCommand
        {
            get
            {
                if (m_UpdateButtonCommand == null)
                {
                    m_UpdateButtonCommand = new AsyncCommand(() => UpdateExecuteFunction(), () => true);
                }

                return m_UpdateButtonCommand;
            }
            set
            {
                m_UpdateButtonCommand = value;
            }
        }

        private RelayCommand m_CloseButtonCommand;
        public RelayCommand CloseButtonCommand
        {
            get
            {
                if (m_CloseButtonCommand == null)
                {
                    m_CloseButtonCommand = new RelayCommand(() => ExecuteRequestClose(), () => true);
                }

                return m_CloseButtonCommand;
            }
            set
            {
                m_CloseButtonCommand = value;
            }
        }

        private string _infoLabel;

        public string InfoLabel
        {
            get
            {
                return _infoLabel;
            }
            set
            {
                _infoLabel = value;
                OnPropertyChanged(nameof(InfoLabel));
            }
        }

        private string _idLabel;

        public string IDLabel
        {
            get
            {
                return _idLabel;
            }
            set
            {
                _idLabel = value;
                OnPropertyChanged(nameof(IDLabel));
            }
        }

        public UpdateValueModel()
        {
            InfoLabel = "Hier steht ein Dummy text für den Default Constructor";
            //FillCollection();
        }

        public UpdateValueModel(string type, int id)
        {
            _type = type;
            _id = id;
            InfoLabel = $"Set value for the type {_type}";
            IDLabel = $"Update value for element with ID {_id}";
            _httphelper = new HttpHelper();

            //little trick here to handle the async call from the http helper
            Task<ObservableCollection<SetValuesHelper>> executer = new Task<ObservableCollection<SetValuesHelper>>(() => FillCollection(_httphelper));
            executer.Start();
            executer.Wait();
            UpdateValues= executer.Result;            
        }

        /// <summary>
        /// Fills the items in the view. Loads data from the httprequest
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        private ObservableCollection<SetValuesHelper> FillCollection(HttpHelper helper)
        {
            var tmpUpdateValues = new ObservableCollection<SetValuesHelper>();
            switch (_type)
            {
                case ObjectDtos.AbteilungDtoName:
                    {
                        var item = _httphelper.HttpGet<AbteilungDto>($"api/abteilung/{_id}").Result;
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Name", Value = item.Name });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Fachbereich", Value = item.Fachbereich });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "WerkName", Value = item.WerkName });
                        break;
                    }
                case ObjectDtos.FertigungDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungDto>($"api/fertigung/{_id}").Result;
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Name", Value = item.Name });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "AbteilungName", Value = item.AbteilungName });
                        break;
                    }
                case ObjectDtos.FertigungslinieDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungslinieDto>($"api/fertigungslinie/{_id}").Result;
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Name", Value = item.Name });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "FertigungName", Value = item.FertigungName });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "FertigungID", Value = "" });
                        break;
                    }
                case ObjectDtos.MaschineDtoName:
                    {
                        //var item = _httphelper.HttpGet<MaschineDto>($"api/maschine/{_id}").Result;
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "InventarNummer", Value = item.InventarNummer.ToString() });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Zeichnungsnummer", Value = item.Zeichnungsnummer });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Type", Value = item.Type });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Hersteller", Value = item.Hersteller });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Baujahr", Value = item.Baujahr.ToString() });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Garantie", Value = item.Garantie.ToString() });
                        break;
                    }
                case ObjectDtos.ReparaturDtoName:
                    {
                        var item = _httphelper.HttpGet<ReparaturDto>($"api/reparatur/{_id}").Result;

                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Start", Value = item.Start.ToString() });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Dauer", Value = item.Dauer.ToString() });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "Status", Value = item.Status });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "MaschineID", Value = "" });
                        tmpUpdateValues.Add(new SetValuesHelper() { Label = "UserID", Value = "" });
                        break;
                    }
                case ObjectDtos.UserDtoName:
                    {
                        //var item = _httphelper.HttpGet<UserDto>($"api/user/{_id}").Result;
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Title", Value = item.Title });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "FirstName", Value = item.FirstName });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "FamilyName", Value = item.FamilyName });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Abteilung", Value = item.AbteilungName });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Werk", Value = item.WerkName });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "eMail", Value = item.eMail });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Phone", Value = item.Phone });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Mobile", Value = item.Mobile });
                        break;
                    }
                case ObjectDtos.WartungDtoName:
                    {
                        //var item = _httphelper.HttpGet<WartungDto>($"api/wartung/{_id}").Result;
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "WartungsInterval", Value = item.WartungsInterval.ToString() });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Status", Value = item.Status });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "Beschreibung", Value = item.Beschreibung });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "MaschineID", Value = "" });
                        //tmpUpdateValues.Add(new SetValuesHelper() { Label = "UserID", Value = "" });
                        break;
                    }

                default:
                    tmpUpdateValues.Add(new SetValuesHelper() { Label = "Name", Value = "Content" });
                    tmpUpdateValues.Add(new SetValuesHelper() { Label = "Ort", Value = "Content2" });
                    break;
            }

            return tmpUpdateValues;
        }

        /// <summary>
        /// Function to execute the put call from th api. loads the data from the ui
        /// </summary>
        public void UpdateExecuteFunction()
        {
            //Update the data
            switch (_type)
            {
                case ObjectDtos.AbteilungDtoName:
                    _httphelper.HttpPut($"api/abteilung/{_id}", new AbteilungDto()
                    {
                        Name = UpdateValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        Fachbereich = UpdateValues.ToList().FirstOrDefault(x => x.Label == "Fachbereich").Value,
                        WerkName = UpdateValues.ToList().FirstOrDefault(x => x.Label == "WerkName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungDtoName:
                    _httphelper.HttpPut($"api/fertigung/{_id}", new FertigungDto()
                    {
                        Name = UpdateValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        AbteilungName = UpdateValues.ToList().FirstOrDefault(x => x.Label == "AbteilungName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    _httphelper.HttpPut($"api/fertigungslinie/{_id}", new FertigungslinieDto()
                    {
                        Name = UpdateValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        FertigungName = UpdateValues.ToList().FirstOrDefault(x => x.Label == "FertigungName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.MaschineDtoName:
                    _httphelper.HttpPut($"api/maschine/{_id}", new MaschineDto()
                    {
                    }).Wait();
                    break;
                case ObjectDtos.ReparaturDtoName:
                    _httphelper.HttpPut($"api/reparatur/{_id}", new ReparaturDto()
                    {
                        Start = Convert.ToDateTime(UpdateValues.ToList().FirstOrDefault(x => x.Label == "Start").Value),
                        Dauer = Convert.ToDateTime(UpdateValues.ToList().FirstOrDefault(x => x.Label == "Dauer").Value),
                        Status = UpdateValues.ToList().FirstOrDefault(x => x.Label == "Status").Value,
                    }).Wait();
                    break;
                case ObjectDtos.UserDtoName:
                    _httphelper.HttpPut($"api/user/{_id}", new UserDto()
                    {
                    }).Wait();
                    break;
                case ObjectDtos.WartungDtoName:
                    _httphelper.HttpPut($"api/wartung", new WartungDto()
                    {
                    }).Wait();
                    break;
                default:
                    UpdateValues.Add(new SetValuesHelper() { Label = "Test", Value = "Content" });
                    UpdateValues.Add(new SetValuesHelper() { Label = "Test2", Value = "Content2" });
                    break;
            }

            base.ExecuteRequestClose();
        }
    }
}

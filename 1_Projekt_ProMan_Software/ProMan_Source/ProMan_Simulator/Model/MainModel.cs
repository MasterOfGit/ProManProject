using System.Collections.Generic;
using ProMan_BusinessLayer.Models;
using ProMan_Simulator.Base;
using ProMan_Simulator.Helper;


namespace ProMan_Simulator.Model
{
    public class MainModel : BaseModel
    {
        private HttpHelper _httphelper;


        private string _id = "0";

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private string _selectedMode;

        public string SelectedMode
        {
            get
            {
                return _selectedMode;
            }
            set
            {
                _selectedMode = value;
                OnPropertyChanged(nameof(SelectedMode));
            }
        }


        private List<string> _modes = new List<string>();

        public List<string> Modes
        {
            get
            {
                return _modes;
            }
            set
            {
                _modes = value;
                OnPropertyChanged(nameof(Modes));
            }
        }


        private string _result = "none";

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }


        public MainModel()
        {
            //_httphelper = new HttpHelper(@"http://localhost:50435/");
            //create instance of the httphelper needed to get the data
            _httphelper = new HttpHelper();

            //Get all the different mode types currently implemented
            foreach (var prop in typeof(ObjectDtos).GetFields())
            {
                if (prop.FieldType == typeof(string))
                {
                    Modes.Add(prop.GetValue(null) as string);
                }                   
            }
        }

        #region Buttons

        private AsyncCommand m_GetButtonCommand;
        public AsyncCommand GetButtonCommand
        {
            get
            {
                if (m_GetButtonCommand == null)
                {
                    m_GetButtonCommand = new AsyncCommand(() => GetExecuteFunction(), () => true);
                }

                return m_GetButtonCommand;
            }
            set
            {
                m_GetButtonCommand = value;
            }
        }

        private RelayCommand m_SetButtonCommand;
        public RelayCommand SetButtonCommand
        {
            get
            {
                if (m_SetButtonCommand == null)
                {
                    m_SetButtonCommand = new RelayCommand((s) => SetExecuteFunction(s as string), () => true);
                }

                return m_SetButtonCommand;
            }
            set
            {
                m_SetButtonCommand = value;
            }
        }

        private RelayCommand m_StartTestButtonCommand;
        public RelayCommand StartTestButtonCommand
        {
            get
            {
                if (m_StartTestButtonCommand == null)
                {
                    m_StartTestButtonCommand = new RelayCommand((s) => StartTestFunction(s as string), () => true);
                }

                return m_StartTestButtonCommand;
            }
            set
            {
                m_StartTestButtonCommand = value;
            }
        }


        #endregion
        private void GetExecuteFunction()
        {
            switch (SelectedMode)
            {
                case "Fertigung":
                    {
                        var item = _httphelper.HttpGet<FertigungDto>($"api/fertigung/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case "Fertigungslinie":
                    {
                        var item = _httphelper.HttpGet<FertigungslinieDto>($"api/fertigungslinie/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case "Maschine":
                    {
                        var item = _httphelper.HttpGet<MaschineDto>($"api/maschine/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case "User":
                    {
                        var item = _httphelper.HttpGet<UserDto>($"api/user/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case "Reparatur":
                    {
                        var item = _httphelper.HttpGet<ReparaturDto>($"api/reparatur/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case "Wartung":
                    {
                        var item = _httphelper.HttpGet<WartungDto>($"api/wartung/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                default:
                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
                    break;
            }

        }

        private void SetExecuteFunction(string s)
        {
            WindowService.ShowSetValueWindow(new SetValueModel(SelectedMode));
    //        switch (SelectedMode)
    //        {
    //            case "Fertigung":
    //                {
    //                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
    //                    break;
    //                }
    //            case "Fertigungslinie":
    //                {
    //                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
    //                    break;
    //                }
    //            case "Maschine":
    //                {
    //                    await _httphelper.HttpPost($"api/maschine", new MaschineDto()
    //                    {
    //                        Baujahr = DateTime.Now,
    //                        Garantie = DateTime.Now.AddYears(5),
    //                        Hersteller = "Hersteller 1",
    //                        Type = "Type_1",
    //                        InventarNummer = 123
    //                    }
    //);
    //                    break;
    //                }
    //            case "User":
    //                {
    //                    await _httphelper.HttpPost($"api/user", new UserDto()
    //                    {
    //                        FirstName = "Katze",
    //                        FamilyName = "Hund",
    //                        Abteilung = "Test",
    //                        eMail = "katze@firma.de",
    //                        Mobile = "123",
    //                        Phone = "456",
    //                    }
    //);
    //                    break;
    //                }
    //            case "Reparatur":
    //                {
    //                    await _httphelper.HttpPost($"api/reparatur", new ReparaturDto()
    //                    {
    //                        Dauer = DateTime.Now,
    //                        InventarNummer = 1,
    //                        Status = "InWork",
    //                        Zeichnungsnummer = "Dies ist ein Test",
    //                    }
    //);
    //                    break;
    //                }
    //            case "Wartung":
    //                {
    //                    await _httphelper.HttpPost($"api/wartung", new WartungDto()
    //                    {
    //                        Beschreibung = "Dies ist ein Test",
    //                        InventarNummer = 1,
    //                        Status = "InWork",
    //                        WartungsInterval = DateTime.Now,
    //                    }
    //                        );
    //                    break;
    //                }
    //            default:
    //                Result = $"Mode with the name \"{SelectedMode}\" is not supported";
    //                break;
    //        }

        }

        private void StartTestFunction(string value)
        {
        }



    }
}

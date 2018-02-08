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
                case ObjectDtos.WerkDtoName:
                    {
                        var item = _httphelper.HttpGet<WerkDto>($"api/werk/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.AbteilungDtoName:
                    {
                        var item = _httphelper.HttpGet<AbteilungDto>($"api/abteilung/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungDto>($"api/fertigung/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungslinieDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungslinieDto>($"api/fertigungslinie/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.MaschineDtoName:
                    {
                        var item = _httphelper.HttpGet<MaschineDto>($"api/maschine/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.UserDtoName:
                    {
                        var item = _httphelper.HttpGet<UserDto>($"api/user/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ReparaturDtoName:
                    {
                        var item = _httphelper.HttpGet<ReparaturDto>($"api/reparatur/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.WartungDtoName:
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
        }

        private void StartTestFunction(string value)
        {
        }



    }
}

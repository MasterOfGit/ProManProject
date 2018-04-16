using System.Collections.Generic;
using ProMan_BusinessLayer.Models;
using ProMan_Simulator.Base;
using ProMan_Simulator.Helper;
using System;
using System.Windows.Threading;
using ProMan_BusinessLayer.Models.AdminPages;

namespace ProMan_Simulator.Model
{
    public class MainModel : BaseModel
    {
        private HttpHelper _httphelper;


        private int _id = 1;

        public int ID
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

        private AsyncCommand m_GetAllButtonCommand;
        public AsyncCommand GetAllButtonCommand
        {
            get
            {
                if (m_GetAllButtonCommand == null)
                {
                    m_GetAllButtonCommand = new AsyncCommand(() => GetAllExecuteFunction(), () => true);
                }

                return m_GetAllButtonCommand;
            }
            set
            {
                m_GetAllButtonCommand = value;
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

        private RelayCommand m_UpdateDataButtonCommand;
        public RelayCommand UpdateDataButtonCommand
        {
            get
            {
                if (m_UpdateDataButtonCommand == null)
                {
                    m_UpdateDataButtonCommand = new RelayCommand((s) => UpdateDataFunction(s as string), () => true);
                }

                return m_UpdateDataButtonCommand;
            }
            set
            {
                m_UpdateDataButtonCommand = value;
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
                #region single objects
                case ObjectDtos.AbteilungDtoName:
                    {
                        var item = _httphelper.HttpGet<AbteilungDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ArbeitsfolgeDtoName:
                    {
                        var item = _httphelper.HttpGet<ArbeitsfolgeDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.AuditDtoName:
                    {
                        var item = _httphelper.HttpGet<AuditDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.BauteilDtoName:
                    {
                        var item = _httphelper.HttpGet<BauteilDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.BauteilVerwendungDtoName:
                    {
                        var item = _httphelper.HttpGet<BauteilVerwendungDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungslinieDtoName:
                    {
                        var item = _httphelper.HttpGet<FertigungslinieDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.InstandhaltungsAuftragDtoName:
                    {
                        var item = _httphelper.HttpGet<InstandhaltungsAuftragDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.LagerBestandDtoName:
                    {
                        var item = _httphelper.HttpGet<LagerBestandDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.LoginDtoName:
                    {
                        var item = _httphelper.HttpGet<LoginDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.MaschineDtoName:
                    {
                        var item = _httphelper.HttpGet<MaschineDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.MaschineVerwendungDtoName:
                    {
                        var item = _httphelper.HttpGet<MaschineVerwendungDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.NachrichtDtoName:
                    {
                        var item = _httphelper.HttpGet<NachrichtDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ProduktionsplanDtoName:
                    {
                        var item = _httphelper.HttpGet<ProduktionsplanDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ReparaturDtoName:
                    {
                        var item = _httphelper.HttpGet<ReparaturDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.UserAnfrageDtoName:
                    {
                        var item = _httphelper.HttpGet<UserAnfrageDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.UserDtoName:
                    {
                        var item = _httphelper.HttpGet<UserDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.WartungDtoName:
                    {
                        var item = _httphelper.HttpGet<WartungDto>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                //case ObjectDtos.WerkDtoName:
                //    {
                //        var item = _httphelper.HttpGet<>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                

                #endregion
                #region adminpages
                //case ObjectDtos.AdminPageAbteilung:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageAbteilungDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageAbteilung}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageBauteil:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageBauteilDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageBauteil}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageFertigung:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageFertigungDto>($"api/adminpage/?identifier={ ObjectDtos.AdminPageFertigung}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageFertigungslinie:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageFertigungslinieDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageFertigungslinie}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageMaschine:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageMaschineDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageMaschine}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageUser:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageUserDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageUser}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }

                #endregion
                default:
                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
                    break;
            }

        }

        private void GetAllExecuteFunction()
        {
            switch (SelectedMode)
            {
                #region single objects
                case ObjectDtos.AbteilungDtoName:
                    {
                        var item = _httphelper.HttpGet< List<AbteilungDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ArbeitsfolgeDtoName:
                    {
                        var item = _httphelper.HttpGet< List<ArbeitsfolgeDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.AuditDtoName:
                    {
                        var item = _httphelper.HttpGet< List<AuditDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.BauteilDtoName:
                    {
                        var item = _httphelper.HttpGet< List<BauteilDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.BauteilVerwendungDtoName:
                    {
                        var item = _httphelper.HttpGet< List<BauteilVerwendungDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungDtoName:
                    {
                        var item = _httphelper.HttpGet< List<FertigungDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.FertigungslinieDtoName:
                    {
                        var item = _httphelper.HttpGet< List<FertigungslinieDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.InstandhaltungsAuftragDtoName:
                    {
                        var item = _httphelper.HttpGet< List<InstandhaltungsAuftragDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.LagerBestandDtoName:
                    {
                        var item = _httphelper.HttpGet< List<LagerBestandDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.LoginDtoName:
                    {
                        var item = _httphelper.HttpGet< List<LoginDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.MaschineDtoName:
                    {
                        var item = _httphelper.HttpGet< List<MaschineDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.MaschineVerwendungDtoName:
                    {
                        var item = _httphelper.HttpGet< List<MaschineVerwendungDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.NachrichtDtoName:
                    {
                        var item = _httphelper.HttpGet< List<NachrichtDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ProduktionsplanDtoName:
                    {
                        var item = _httphelper.HttpGet< List<ProduktionsplanDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.ReparaturDtoName:
                    {
                        var item = _httphelper.HttpGet< List<ReparaturDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.UserAnfrageDtoName:
                    {
                        var item = _httphelper.HttpGet<List<UserAnfrageDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.UserDtoName:
                    {
                        var item = _httphelper.HttpGet<List<UserDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                case ObjectDtos.WartungDtoName:
                    {
                        var item = _httphelper.HttpGet<List<WartungDto>>($"api/{SelectedMode.ToLower()}").Result;
                        Result = SerializeHelper.XmlSerialize(item);
                        break;
                    }
                //case ObjectDtos.WerkDtoName:
                //    {
                //        var item = _httphelper.HttpGet<>($"api/{SelectedMode.ToLower()}/{ID}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }


                #endregion
                #region adminpages
                //case ObjectDtos.AdminPageAbteilung:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageAbteilungDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageAbteilung}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageBauteil:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageBauteilDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageBauteil}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageFertigung:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageFertigungDto>($"api/adminpage/?identifier={ ObjectDtos.AdminPageFertigung}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageFertigungslinie:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageFertigungslinieDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageFertigungslinie}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageMaschine:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageMaschineDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageMaschine}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }
                //case ObjectDtos.AdminPageUser:
                //    {
                //        var item = _httphelper.HttpGet<AdminPageUserDto>($"api/adminpage/?identifier={ObjectDtos.AdminPageUser}").Result;
                //        Result = SerializeHelper.XmlSerialize(item);
                //        break;
                //    }

                #endregion
                default:
                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
                    break;
            }

        }

        private void SetExecuteFunction(string s)
        {
            WindowService.ShowSetValueWindow(new SetValueModel(SelectedMode));
        }

        private void UpdateDataFunction(string s)
        {
            WindowService.ShowUpdateValueWindow(new UpdateValueModel(SelectedMode, Convert.ToInt32(ID)));

        }

        private void StartTestFunction(string value)
        {
        }



    }
}

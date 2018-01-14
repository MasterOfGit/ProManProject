using ProMan_Simulator.Base;
using ProMan_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            _httphelper = new HttpHelper();
            Modes.Add("Fertigung");
            Modes.Add("Fertigungslinie");
            Modes.Add("Maschine");
            Modes.Add("User");
            Modes.Add("Reparatur");
            Modes.Add("Wartung");

            // HttpHelper test = new HttpHelper();
            //var Fertigung = new List<FertigungDto>();
            //Fertigung.Add(Task.Run(() => test.HttpGet<FertigungDto>("api/fertigung/2")).Result);
        }

        private AsyncCommand m_ButtonCommand;
        public AsyncCommand ButtonCommand
        {
            get
            {
                if (m_ButtonCommand == null)
                {
                    m_ButtonCommand = new AsyncCommand(() => ExecuteFunction(), () => true);
                }

                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }

        private void ExecuteFunction()
        {
            switch (SelectedMode)
            {
                case "Fertigung":
                    {
                        var item = _httphelper.HttpGet<FertigungDto>($"api/fertigung/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                case "Fertigungslinie":
                    {
                        var item = _httphelper.HttpGet<FertigungslinieDto>($"api/fertigungslinie/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                case "Maschine":
                    {
                        var item = _httphelper.HttpGet<MaschineDto>($"api/maschine/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                case "User":
                    {
                        var item = _httphelper.HttpGet<UserDto>($"api/user/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                case "Reparatur":
                    {
                        var item = _httphelper.HttpGet<ReparaturDto>($"api/reparatur/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                case "Wartung":
                    {
                        var item = _httphelper.HttpGet<WartungDto>($"api/wartung/{ID}").Result;
                        Result = Serialize(item);
                        break;
                    }
                default:
                    Result = $"Mode with the name \"{SelectedMode}\" is not supported";
                    break;
            }

        }

        public string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}

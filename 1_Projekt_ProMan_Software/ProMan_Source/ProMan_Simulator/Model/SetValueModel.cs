using ProMan_BusinessLayer.Models;
using ProMan_Simulator.Base;
using ProMan_Simulator.Helper;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProMan_Simulator.Model
{
    public class SetValueModel : BaseModel
    {
        private HttpHelper _httphelper;
        private string _type = string.Empty;

        private ObservableCollection<SetValuesHelper> _setValues;

        public ObservableCollection<SetValuesHelper> SetValues
        {
            get
            {
                return _setValues;
            }
            set
            {
                _setValues = value;
                OnPropertyChanged(nameof(SetValues));
            }
        }

        private AsyncCommand m_SaveButtonCommand;
        public AsyncCommand SaveButtonCommand
        {
            get
            {
                if (m_SaveButtonCommand == null)
                {
                    m_SaveButtonCommand = new AsyncCommand(() => SetExecuteFunction(), () => true);
                }

                return m_SaveButtonCommand;
            }
            set
            {
                m_SaveButtonCommand = value;
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


        public SetValueModel()
        {
            InfoLabel = "Hier steht ein Dummy text für den Default Constructor";
            FillCollection();
        }

        public SetValueModel(string type)
        {
            _type = type;
            InfoLabel = $"Set value for the type {_type}";
            FillCollection();
            _httphelper = new HttpHelper();
        }

        private void FillCollection()
        {
            SetValues = new ObservableCollection<SetValuesHelper>();
            switch (_type)
            {
                case ObjectDtos.WerkDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Ort", Value = "" });
                    break;
                case ObjectDtos.AbteilungDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Fachbereich", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "WerkName", Value = "" });
                    break;
                case ObjectDtos.FertigungDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "AbteilungName", Value = "" });
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "FertigungName", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "FertigungID", Value = "" });
                    break;
                case ObjectDtos.MaschineDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "InventarNummer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Zeichnungsnummer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Type", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Hersteller", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Baujahr", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Garantie", Value = "" });
                    break;
                case ObjectDtos.ReparaturDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Start", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Dauer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Status", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "MaschineID", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "UserID", Value = "" });
                    break;
                case ObjectDtos.UserDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Title", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "FirstName", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "FamilyName", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Abteilung", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Werk", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "eMail", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Phone", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Mobile", Value = "" });
                    break;
                case ObjectDtos.WartungDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "WartungsInterval", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Status", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Beschreibung", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "MaschineID", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "UserID", Value = "" });
                    break;
                default:                   
                    SetValues.Add(new SetValuesHelper() { Label = "Test", Value = "Content" });
                    SetValues.Add(new SetValuesHelper() { Label = "Test2", Value = "Content2" });
                    break;
            }
        }


        public void SetExecuteFunction()
        {
            switch (_type)
            {
                case ObjectDtos.AbteilungDtoName:
                    _httphelper.HttpPost($"api/abteilung", new AbteilungDto()
                    {
                        Name = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        Fachbereich = SetValues.ToList().FirstOrDefault(x => x.Label == "Fachbereich").Value,
                        WerkName = SetValues.ToList().FirstOrDefault(x => x.Label == "WerkName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungDtoName:
                    _httphelper.HttpPost($"api/fertigung", new FertigungDto()
                    {
                        Name = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        AbteilungName = SetValues.ToList().FirstOrDefault(x => x.Label == "AbteilungName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    _httphelper.HttpPost($"api/fertigungslinie", new FertigungslinieDto()
                    {
                        Name = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        FertigungName = SetValues.ToList().FirstOrDefault(x => x.Label == "FertigungName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.MaschineDtoName:
                    _httphelper.HttpPost($"api/maschine", new MaschineDto()
                    {
                    }).Wait();
                    break;
                case ObjectDtos.ReparaturDtoName:
                    _httphelper.HttpPost($"api/reparatur", new ReparaturDto()
                    {
                        Start = Convert.ToDateTime(SetValues.ToList().FirstOrDefault(x => x.Label == "Start").Value),
                        Dauer = Convert.ToDateTime(SetValues.ToList().FirstOrDefault(x => x.Label == "Dauer").Value),
                        Status = SetValues.ToList().FirstOrDefault(x => x.Label == "Status").Value,
                    }).Wait();
                    break;
                case ObjectDtos.UserDtoName:
                    _httphelper.HttpPost($"api/user", new UserDto()
                    {
                    }).Wait();
                    break;
                case ObjectDtos.WartungDtoName:
                    _httphelper.HttpPost($"api/wartung", new WartungDto()
                    {
                
                    }).Wait();
                    break;
                default:
                    SetValues.Add(new SetValuesHelper() { Label = "Test", Value = "Content" });
                    SetValues.Add(new SetValuesHelper() { Label = "Test2", Value = "Content2" });
                    break;
            }

            base.ExecuteRequestClose();
        }

    }
}

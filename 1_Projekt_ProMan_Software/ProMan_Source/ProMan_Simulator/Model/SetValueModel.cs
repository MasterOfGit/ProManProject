using ProMan_BusinessLayer.Models;
using ProMan_Simulator.Base;
using ProMan_Simulator.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Simulator.Model
{
    public class SetValueModel : BaseModel
    {
        private HttpHelper _httphelper;
        private string _type = string.Empty;

        private ObservableCollection<SetValues> _setValues;

        public ObservableCollection<SetValues> SetValues
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

        private RelayCommand m_SaveButtonCommand;
        public RelayCommand SaveButtonCommand
        {
            get
            {
                if (m_SaveButtonCommand == null)
                {
                    m_SaveButtonCommand = new RelayCommand(() => SetExecuteFunction(), () => true);
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
            SetValues = new ObservableCollection<Model.SetValues>();
            switch (_type)
            {
                case ObjectDtos.WerkDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Ort", Value = "" });
                    break;
                case ObjectDtos.AbteilungDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Fachbereich", Value = "" });
                    SetValues.Add(new SetValues() { Label = "WerkName", Value = "" });
                    break;
                case ObjectDtos.FertigungDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValues() { Label = "AbteilungName", Value = "" });
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
                    SetValues.Add(new SetValues() { Label = "FertigungName", Value = "" });
                    SetValues.Add(new SetValues() { Label = "FertigungID", Value = "" });
                    break;
                case ObjectDtos.MaschineDtoName:
                    SetValues.Add(new SetValues() { Label = "InventarNummer", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Zeichnungsnummer", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Type", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Hersteller", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Baujahr", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Garantie", Value = "" });
                    break;
                case ObjectDtos.ReparaturDtoName:
                    SetValues.Add(new SetValues() { Label = "Start", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Dauer", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Status", Value = "" });
                    SetValues.Add(new SetValues() { Label = "MaschineID", Value = "" });
                    SetValues.Add(new SetValues() { Label = "UserID", Value = "" });
                    break;
                case ObjectDtos.UserDtoName:
                    SetValues.Add(new SetValues() { Label = "Title", Value = "" });
                    SetValues.Add(new SetValues() { Label = "FirstName", Value = "" });
                    SetValues.Add(new SetValues() { Label = "FamilyName", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Abteilung", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Werk", Value = "" });
                    SetValues.Add(new SetValues() { Label = "eMail", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Phone", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Mobile", Value = "" });
                    break;
                case ObjectDtos.WartungDtoName:
                    SetValues.Add(new SetValues() { Label = "WartungsInterval", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Status", Value = "" });
                    SetValues.Add(new SetValues() { Label = "Beschreibung", Value = "" });
                    SetValues.Add(new SetValues() { Label = "MaschineID", Value = "" });
                    SetValues.Add(new SetValues() { Label = "UserID", Value = "" });
                    break;
                default:                   
                    SetValues.Add(new SetValues() { Label = "Test", Value = "Content" });
                    SetValues.Add(new SetValues() { Label = "Test2", Value = "Content2" });
                    break;
            }
        }


        public void SetExecuteFunction()
        {
            switch (_type)
            {
                case ObjectDtos.WerkDtoName:
                    _httphelper.HttpPost($"api/werk", new WerkDto()
                    {
                        Name = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        Ort = SetValues.ToList().FirstOrDefault(x => x.Label == "Ort").Value,
                    }).Wait(20000);
                    break;
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
                        Baujahr = Convert.ToDateTime(SetValues.ToList().FirstOrDefault(x => x.Label == "Baujahr").Value) ,
                        Garantie = Convert.ToDateTime(SetValues.ToList().FirstOrDefault(x => x.Label == "Garantie").Value),
                        Hersteller = SetValues.ToList().FirstOrDefault(x => x.Label == "Hersteller").Value,
                        Type = SetValues.ToList().FirstOrDefault(x => x.Label == "Type").Value,
                        InventarNummer = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "InventarNummer").Value),
                        Zeichnungsnummer = SetValues.ToList().FirstOrDefault(x => x.Label == "Zeichnungsnummer").Value,
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
                        Title = SetValues.ToList().FirstOrDefault(x => x.Label == "Title").Value,
                        FirstName = SetValues.ToList().FirstOrDefault(x => x.Label == "FirstName").Value,
                        FamilyName = SetValues.ToList().FirstOrDefault(x => x.Label == "FamilyName").Value,
                        Abteilung = SetValues.ToList().FirstOrDefault(x => x.Label == "Abteilung").Value,
                        Werk = SetValues.ToList().FirstOrDefault(x => x.Label == "Werk").Value,
                        eMail = SetValues.ToList().FirstOrDefault(x => x.Label == "eMail").Value,
                        Phone = SetValues.ToList().FirstOrDefault(x => x.Label == "Phone").Value,
                        Mobile = SetValues.ToList().FirstOrDefault(x => x.Label == "Mobile").Value,
                    }).Wait();
                    break;
                case ObjectDtos.WartungDtoName:
                    _httphelper.HttpPost($"api/wartung", new WartungDto()
                    {
                        WartungsInterval = Convert.ToDateTime(SetValues.ToList().FirstOrDefault(x => x.Label == "WartungsInterval").Value),
                        Status = SetValues.ToList().FirstOrDefault(x => x.Label == "Status").Value,
                        Beschreibung = SetValues.ToList().FirstOrDefault(x => x.Label == "Beschreibung").Value,                     
                    }).Wait();
                    break;
                default:
                    SetValues.Add(new SetValues() { Label = "Test", Value = "Content" });
                    SetValues.Add(new SetValues() { Label = "Test2", Value = "Content2" });
                    break;
            }

            var test = SetValues;


            base.ExecuteRequestClose();
        }


        


    }



    public class SetValues
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }

}

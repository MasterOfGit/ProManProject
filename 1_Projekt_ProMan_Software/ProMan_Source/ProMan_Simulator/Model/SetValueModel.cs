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
                case ObjectDtos.BauteilDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilNummer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilIndex", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilArt", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilVersion", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilStatus", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "bauteilIDNachfolger", Value = "" });
                    break;

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
                    SetValues.Add(new SetValuesHelper() { Label = "Inventarnummer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Zeichnungsnummer", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Version", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Hersteller", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Standort", Value = "" });
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
                    SetValues.Add(new SetValuesHelper() { Label = "wartungsID", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "abteilung", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "fertigung", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "fertigungslinie", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "maschine", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "terminturnus", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "status", Value = "" });
                    break;
                case ObjectDtos.LoginDtoName:
                    SetValues.Add(new SetValuesHelper() { Label = "Username", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "Passwort", Value = "" });
                    SetValues.Add(new SetValuesHelper() { Label = "UserType", Value = "" });
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
                case ObjectDtos.BauteilDtoName:
                    _httphelper.HttpPost($"api/bauteil", new BauteilDto()
                    {
                        bauteilNummer = SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilNummer").Value,
                        bauteilIndex = SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilIndex").Value,
                        bauteilArt = SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilArt").Value,
                        bauteilVersion = SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilVersion").Value,
                        bauteilStatus = SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilStatus").Value,
                        bauteilIDNachfolger = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "bauteilIDNachfolger").Value),
                    }).Wait();
                    break;

                case ObjectDtos.AbteilungDtoName:
                    _httphelper.HttpPost($"api/abteilung", new AbteilungDto()
                    {
                        abteilungsname = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        Fachbereich = SetValues.ToList().FirstOrDefault(x => x.Label == "Fachbereich").Value,
                        WerkName = SetValues.ToList().FirstOrDefault(x => x.Label == "WerkName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungDtoName:
                    _httphelper.HttpPost($"api/fertigung", new FertigungDto()
                    {
                        fertigungsname = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                        abteilungName = SetValues.ToList().FirstOrDefault(x => x.Label == "AbteilungName").Value,
                    }).Wait();
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    _httphelper.HttpPost($"api/fertigungslinie", new FertigungslinieDto()
                    {
                        fertigungslinienname = SetValues.ToList().FirstOrDefault(x => x.Label == "Name").Value,
                    }).Wait();
                    break;
                case ObjectDtos.MaschineDtoName:
                    _httphelper.HttpPost($"api/maschine", new MaschineDto()
                    {
                        maschinenInventarNummer = SetValues.ToList().FirstOrDefault(x => x.Label == "Inventarnummer").Value,
                        Zeichnungsnummer = SetValues.ToList().FirstOrDefault(x => x.Label == "Zeichnungsnummer").Value,
                        Version = SetValues.ToList().FirstOrDefault(x => x.Label == "Version").Value,
                        hersteller = SetValues.ToList().FirstOrDefault(x => x.Label == "Hersteller").Value,
                        standort = SetValues.ToList().FirstOrDefault(x => x.Label == "Standort").Value,
                        status = "1",
                        technologie = "1",
                        Garantie = DateTime.Now,
                        Anschaffungsdatum = DateTime.Now.AddDays(-10),

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
                        wartungsID = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "wartungsID").Value),
                        abteilung = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "abteilung").Value),
                        fertigung = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "fertigung").Value),
                        fertigungslinie = Convert.ToInt32(SetValues.ToList().FirstOrDefault(x => x.Label == "fertigungslinie").Value),
                        maschine = Convert.ToInt32( SetValues.ToList().FirstOrDefault(x => x.Label == "maschine").Value),
                        terminturnus = SetValues.ToList().FirstOrDefault(x => x.Label == "terminturnus").Value,
                        status = SetValues.ToList().FirstOrDefault(x => x.Label == "status").Value,
                    }).Wait();
                    break;
                case ObjectDtos.LoginDtoName:
                    _httphelper.HttpPost($"api/login", new LoginDto()
                    {
                        userKennung = SetValues.ToList().FirstOrDefault(x => x.Label == "Username").Value,
                        userpasswort = SetValues.ToList().FirstOrDefault(x => x.Label == "Passwort").Value,
                        userbereich = SetValues.ToList().FirstOrDefault(x => x.Label == "UserType").Value,
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

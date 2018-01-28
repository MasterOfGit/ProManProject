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
            FillCollection(string.Empty);
        }

        public SetValueModel(string type)
        {
            InfoLabel = $"Set value for the type {type}";
            FillCollection(type);
        }

        private void FillCollection(string type)
        {
            SetValues = new ObservableCollection<Model.SetValues>();
            switch (type)
            {
                case ObjectDtos.FertigungDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
                    break;
                case ObjectDtos.FertigungslinieDtoName:
                    SetValues.Add(new SetValues() { Label = "Name", Value = "" });
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

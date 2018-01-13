using ProMan_Simulator.Base;
using ProMan_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Simulator.Model
{
    public class MainModel : BaseModel
    {
        private List<FertigungDto> _fertigung;

        public List<FertigungDto> Fertigung
        {
            get
            {
                return _fertigung;
            }
            set
            {
                _fertigung = value;
                OnPropertyChanged(nameof(Fertigung));
            }
        }

        public MainModel()
        {
            HttpHelper test = new HttpHelper();
            Fertigung = new List<FertigungDto>();
            Fertigung.Add(Task.Run(() => test.HttpGet<FertigungDto>("api/fertigung/1")).Result);
        }

    }
}

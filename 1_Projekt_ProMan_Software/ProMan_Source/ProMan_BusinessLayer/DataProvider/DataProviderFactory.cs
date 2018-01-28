using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProMan_BusinessLayer.DataProvider
{
    public class DataProviderFactory
    {
        public IDataProvider data;

        public DataProviderFactory(string provider)
        {
            if (provider == "Dummy")
                data = new DummyDataProvider();
            else
                data = new DatabaseDataProvider();
        }
    }
}
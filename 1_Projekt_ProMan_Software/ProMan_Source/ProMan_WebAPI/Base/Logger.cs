using System;
using System.IO;


namespace ProMan_WebAPI.Base
{
    public class Logger
    {
        private string _logFile;
        private bool allowLog = false;

        public Logger()
        {
            allowLog = true;
            _logFile = $@"C:\API.txt";
            if (!File.Exists(_logFile))
            {
                File.Create(_logFile).Close();
            }
        }

        public void LogGetAll(string controllername)
        {
            ExecuteLog($"GET ALL --- {controllername}");
        }

        public void LogGetSingle(string controllername, int id)
        {
            ExecuteLog($"GET SIN ---{controllername} - {id}");
        }

        public void LogPostSingle(string controllername, string data)
        {
            ExecuteLog($"POST SIN ---{controllername} - {data}");
        }

        public void LogPutSingle(string controllername, string data, int id)
        {
            ExecuteLog($"PUT SIN ---{controllername} - {id} - {data}");
        }
        public void LogDelete(string controllername, int id)
        {
            ExecuteLog($"DELETE --- {controllername} - {id}");
        }

        private void ExecuteLog(string message)
        {
            File.WriteAllText($@"C:\API.txt", $"{DateTime.Now} --- {message}");
            if (allowLog)
            {
                File.WriteAllText(_logFile, $"{DateTime.Now} --- {message}");
            }
            
        }

    }
}
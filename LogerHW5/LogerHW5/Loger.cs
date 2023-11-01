using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LogerHW5
{
    internal struct Loger
    {
        string _logtext;
        string _fileWay;
        string _logType;
        string _allLog;
        public Loger(string logType = "Info")
        {
            _logType = logType;
        } 
        public void ShowLog(string logtext)
        {
            _logtext = $"{DateTime.Now}:{_logType}:{logtext}";

            Console.WriteLine($"{DateTime.Now}:{_logType}:{_logtext}");

            _allLog = $"{_allLog}"+$"\n{_logtext}";
        }
        public void GetLogText()
        {
            _fileWay = "C:\\Users\\User\\Desktop\\Log.txt";

            File.WriteAllText(_fileWay, _allLog);
        }
    }
}

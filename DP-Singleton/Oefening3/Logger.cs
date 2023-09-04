using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Logger
    {
        // TODO: Implementeer de Singleton pattern hier
        private static Logger _instance;
        private List<string> _log;

        private Logger() 
        {
            _log = new List<string>();
        }

        public static Logger Instance()
        {
            if (_instance == null)  _instance = new Logger();
            return _instance;
        }

        public void LogMessage(string message)
        {
            // TODO: Implementeer de logica om een bericht te loggen
            _log.Add(message);
        }

        public IList<string> GetLogMessages()
        {
            // TODO: Implementeer de logica om alle gelogde berichten op te halen
            return _log;
        }
    }
}

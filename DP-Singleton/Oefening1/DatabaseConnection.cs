using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private List<String> _database;

        private DatabaseConnection() 
        {
            _database = new List<String>();
        }
        public static DatabaseConnection Instance()
        {
            if (_instance == null) _instance = new DatabaseConnection();
            return _instance;
        }

        public IList<String> GetData()
        {
            return _database;
        }

        public void SaveData(string data)
        {
            _database.Add(data);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Account
    {
        private int _balance;
        private string _name;

        public int Balance { get => _balance; }
        public string Name { get => _name; }

        public Account(string name)
        {
            _name = name;
            _balance = 0;
        }

        public void AddAmount(int value)
        {
            // TODO: Implementeer de logica om een transactie te verwerken
            // en log relevante berichten met behulp van de Logger klasse
            _balance += value;
            Logger.Instance().LogMessage($"Add {value} to {Name}'s account.");
        }

        public void Withdraw(int value)
        {
            // TODO: Implementeer de logica om een transactie te verwerken
            // en log relevante berichten met behulp van de Logger klasse
            _balance -= value;
            Logger.Instance().LogMessage($"Withdraw {value} from {Name}'s account.");
        }
    }
}

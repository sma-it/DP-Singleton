using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Account
    {
        public int Balance { get; }
        public string Name { get; }

        public Account(string name)
        {
            Name = name;
            Balance = 0;
        }

        public void AddAmount(int value)
        {
            // TODO: Implementeer de logica om een transactie te verwerken
            // en log relevante berichten met behulp van de Logger klasse
        }

        public void Withdraw(int value)
        {
            // TODO: Implementeer de logica om een transactie te verwerken
            // en log relevante berichten met behulp van de Logger klasse
        }
    }
}

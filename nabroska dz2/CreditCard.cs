using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    public class CreditCard
    {
        private string pin;
        private int failsCount = 0;
        private const int MaxAttempts = 3;
        public string Number { get; private set; }
        public  CreditCard(string number, string pin)
        {
            this.pin = pin;
            Number = number;
        }
        public void Autorize(string pin)
        { 
            if (this.pin != pin)
            {
                failsCount++;
                {
                    if (failsCount >= MaxAttempts)
                    {
                        throw new CreditCardLockedException();
                    }
                    throw new CreditCardException() { RemainingAttempts = MaxAttempts - failsCount };
                }
            }           
        }
    }
}

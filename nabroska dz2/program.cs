using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new CreditCard("1234", "1234");
            var autorized = false;
            Console.WriteLine("Davay, riskni");
            while (!autorized)
            {
                var pin = Console.ReadLine();
                try
                {
                    card.Autorize(pin);
                    autorized = true;
                }
                catch (CreditCardException ex)
                {
                    Console.WriteLine("Allo ti poexavshiy? Y teb9 {0} popitok. Ne ser' miliy", ex.RemainingAttempts);
                }
                catch   (CreditCardLockedException)
                {
                    Console.WriteLine("V chem smisl jizni brat?");
                }
            }
        }
    }
}

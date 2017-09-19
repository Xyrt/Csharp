using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exceptions + TAB + TAB == Магия

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var excpection = new ItStepException();
            //    throw new ItStepException();
            //}
            //catch (ItStepException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            try
            {
                checked
                {
                    byte b = 100;
                    b += 200;
                    Console.WriteLine(b);
                }
            }
            catch (Exception ex when (ex.Message.Contains("MnoGA"))
            {
                Console.WriteLine(ex);
            }
        }
    }
}

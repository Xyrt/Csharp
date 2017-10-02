using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Garbage collector - сборщик мусора

namespace _02._01._2017 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            var garbage = new Garbage();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(GC.GetGeneration(garbage));
            garbage = null;
            GC.Collect();
            var garbage2 = new Garbage();
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(GC.GetGeneration(garbage2));
            WeakReference reference = new WeakReference(garbage2);
            reference.Target.ToString();
            garbage2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(reference.IsAlive);

            Garbage garbage3 = null;
            try
            {
                garbage3 = new Garbage();
            }
            finally
            {
                if (garbage3 != null)
                {
                    garbage3.Dispose();
                }
            }
            using (var garbage4 = new Garbage())
            {

            }
        }
    }
}

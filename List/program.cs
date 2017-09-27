using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //Console.WriteLine(input.RemoveSpaces());
            //var arr = new int[11];
            //int page = 0;
            //int perPage = 5;
            //arr.Skip(page * perPage).Take(perPage).ToArray();
            //page++;
            //arr.Where(x => x > 0).Select(x => x * x).FirstOrDefault(x => x == 9);

            var list = new List<Student>()
            {
                new Student() { Name = "Sergey", Surname = "Breasd", BirthDay = new DateTime(1967, 12,7) },
                new Student() { Name = "Tema", Surname = "Pregor", BirthDay = new DateTime(1992, 3,12) },
                new Student() { Name = "Ivan", Surname = "Bush", BirthDay = new DateTime(1974, 2,25) }
            };
            list.OrderBy(x => x.Name).Print();
            list.OrderBy(x => x.BirthDay.GetAge()).Print();

            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("qurewihfj");
            arrayList.Add(new Student());

            Stack<string> stack = new Stack<string>();
            stack.Push("AKBAR");
            stack.Push("ALLAX");
            stack.Push("vsem vnimanie");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Queue<Student> queue = new Queue<Student>();
            var sortedList = new SortedList<string, Student>();

        }
    }
}

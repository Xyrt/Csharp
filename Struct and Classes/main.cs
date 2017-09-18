using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whow_does_it_work_question_
{
    class Program
    {
        public static void SetXes(Point p, PointClass p2)
        {
            p.SetX(100);
            p2.SetX(200);
        }

        public static void PrintStudent(Student st)
        {
            //if (st == null)
            //{
            //    return;
            //} то же что  и нииже 
            Console.WriteLine(st?.Name);
        }
        static void Main(string[] args)
        {
            var p = new Point(1, 1);
            Console.WriteLine(p);
            var p2 = new PointClass(1, 1);
            Console.WriteLine(p2);
            p.SetX(10);
            Console.WriteLine(p);
            p2.SetX(20);
            Console.WriteLine(p2);
            SetXes(p, p2);
            Console.WriteLine(p);
            Console.WriteLine(p2);

            Point? p3 = null;
            Nullable<Point> p4 = null;
            Console.WriteLine(p3.HasValue + "\n");

            //    if (p3 == null)
            //    {
            //        p3 = new Point(1, 1);
            //    }
            //        тоже, что и
            //    p3 = p3 ?? new Point(1, 1);

            //var sergeyPermission = Permission.Read;
            //var readWrite = Permission.ReadWrite;
            //Console.WriteLine(readWrite.HasFlag(Permission.Write));

            //var userValue = Console.ReadLine();
            //int intValue = 0;
            //Permission result = 0;

            ////tryParce - возвращает булевское значение, если это число

            //if (int.TryParse(userValue, out intValue))
            //{
            //    result = (Permission)intValue;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    result = (Permission) Enum.Parse(typeof(Permission), userValue);
            //    Console.WriteLine(result);
            //}

            var student = new Student();
            student.Name = "Sergey";
            Console.WriteLine(student.Name);
            PrintStudent(null);
            
        }
    }
}

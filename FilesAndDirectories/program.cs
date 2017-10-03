using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//TextReader/TextWriter 
//Class - FileInfo, File, DirectoryInfo, Directory

namespace _03._10._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectDirectory(".");

            using (var stream = File.Create("Alakhu Akbar.txt", 10000))
            {
                stream.WriteByte(228);
                //Console.WriteLine(stream.Name);

                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Farty masti gospoda");
                    writer.WriteLine(228);
                    writer.WriteLine(true);
                }
            }

            using (var stream = File.OpenRead("Alakhu Akbar.txt"))
            {
                Console.WriteLine(stream.ReadByte());

                using (var reader = new StreamReader(stream))
                {
                    Console.WriteLine(reader.ReadLine());
                    Console.WriteLine(reader.ReadLine());
                    Console.WriteLine(reader.ReadLine());
                }
            }

            using (var stream = new FileStream("Babax.bin", FileMode.Create))
            {
                var writer = new BinaryWriter(stream);
                writer.Write(10);
                writer.Write("Neverniy");
                writer.Write(true);
                writer.Flush();
                writer.Seek(0, SeekOrigin.Begin);

                using (var reader = new BinaryReader(stream))
                {
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadBoolean());
                }
            }
        }
        public static void SelectDirectory(string current)
        {
            Console.WriteLine("\nDirectorii\n");

            if (!Directory.Exists(current))
            {
                Console.WriteLine("Directoriya bolshe ne derictoriya");
                return;
            }
            var info = new DirectoryInfo(current);
            Console.WriteLine(info.FullName);
            foreach (var subDir in info.GetDirectories())
            {
                Console.WriteLine(subDir.Name);
            }

            Console.WriteLine("\nA teper files\n");

            foreach (var file in info.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}

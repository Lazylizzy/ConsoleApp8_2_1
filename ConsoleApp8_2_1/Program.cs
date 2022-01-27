using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            const int n = 10;
            string path = "Sum.txt";
            StreamWriter sw = File.CreateText(path);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                sw.Write("{0} ", rnd.Next(100));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            string number = "";
            number = sr.ReadLine();
            Console.WriteLine(number);
            sr.Close();
            Console.WriteLine();
            string masTrim = number.Trim(' ');
            string[] massive = masTrim.Split();
            foreach (string s in massive)
            {
                Console.WriteLine("{0}", s);
            }
            int S;
            S = massive.Count();
            int[] mas = new int[S];
            for (int i = 0; i < S; i++)
            {
                mas[i] = int.Parse(massive[i]);
            }
            int sum = 0;
            for (int i = 0; i < S; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine("Сумма чисел равна {0}", sum);
            Console.ReadKey();
        }
    }
}

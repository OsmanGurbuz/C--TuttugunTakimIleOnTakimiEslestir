using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> takim = new List<string>() { "Fenerbahçe", "Beşiktaş", "Sakaryaspor", "Ankara Gücü", "Gençler Birliği", "Kayseri Spor", "Trabzon Spor", "Samsun Spor", "Göztepe", "Kasımpaşa"};
            Console.WriteLine("Eşleşmeler için Enter'a basınız.");
            for (int i = 1; i <= takim.Count(); i++)
            {
                Console.WriteLine(takim[0] + "-" + takim[i]+" Eşleşmesi");
                Console.ReadLine();
            }
        }
    }
}

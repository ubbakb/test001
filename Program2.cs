using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {asdasdasdasdasdasd
            while(true)
            {
                Console.WriteLine("Deneme sayisini gir: ");
                int denemeSayisi = 0;
                Int32.TryParse(Console.ReadLine(), out denemeSayisi);

                List<int> items = new List<int>();
                Random rd = new Random();

                int erkeksayisi2 = 0;
                for (int i = 0; i < denemeSayisi; i++)
                {
                    int a = rd.Next(0, 2);
                    int b = rd.Next(0, 2);
                    int c = rd.Next(0, 2);
                    if (a + b == 2)
                        erkeksayisi2 = erkeksayisi2 + 1;

                    items.Add(a + b + c);
                }

                int erkeksayisi3 = items.Where(x => x == 3).Count();
                //int erkeksayisi2 = items.Where(x => x == 2).Count() + erkeksayisi3;
                float yuzde = ((float)erkeksayisi3 / (float)erkeksayisi2) * 100;
                Console.WriteLine("2 Erkek sayisi (gerceklesmis ihtimal): " + erkeksayisi2.ToString());
                Console.WriteLine("3 Erkek sayisi: " + erkeksayisi3.ToString());
                Console.WriteLine("3 Erkek sayisi yüzde (3 erkek/2 erkek gerceklesmis ihtimal*100): " + yuzde.ToString());
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            
        }
    }
}

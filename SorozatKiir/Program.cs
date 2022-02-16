using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorozatKiir
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("adjon meg egy egynél nagyobb számot: ");
            int user = int.Parse(Console.ReadLine());
            if (user > 1)
            {
                user +=1;
                for (int i = 1; i < user; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("A szám nem nagyobb egynél.....");
            }
        Console.ReadKey();

        }
    }
}

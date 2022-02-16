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
            Console.Write("adjon meg egy minimum értéket: ");
            int user1 = int.Parse(Console.ReadLine());
            Console.Write("adjon meg egy maximum értéket: ");
            int user2 = int.Parse(Console.ReadLine());
            if (user1 < user2)
            {
                user2 +=1;
                for (int i = user1; i < user2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Minimum és a maximum érték nem megfelelő");
            }
        Console.ReadKey();

        }
    }
}

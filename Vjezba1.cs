using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesite vrijednost za stranicu x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost za stranicu y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost za stranicu z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Vrijednosti predstavljaju pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti ne predstavljaju pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Sve stranice moraju biti veće od 0.");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {

                case DayOfWeek.Monday:

                    Console.WriteLine("Kon'nichiwa");
 
           break;

                case DayOfWeek.Tuesday:

                    Console.WriteLine("Annyeong");

                    break;

                case DayOfWeek.Wednesday:

                    Console.WriteLine("Hola");

                    break;

                case DayOfWeek.Thursday:

                    Console.WriteLine("Hallo");

                    break;

                case DayOfWeek.Friday:

                    Console.WriteLine("Bonjour");

                    break;

                case DayOfWeek.Saturday:

                    Console.WriteLine("Nǐ hǎo");

                    break;

                case DayOfWeek.Sunday:

                    Console.WriteLine("Hej");

                    break;
            }
            Console.ReadLine();

            }
    }
}

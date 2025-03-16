using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    public class ConsoleExtension
    {
        public static void DibujarRombo(int n)
        {
            throw new NotImplementedException();
        }

        public static int GetInt(string message)
        {
            int numberInt;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out numberInt));

            return numberInt;
        }

        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.Write(message);
            var answer = Console.ReadLine();

            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;
            }
            return null;
        }


        


        
    }
}

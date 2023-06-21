using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Introduzca un numero");
            number = Convert.ToInt32(Console.ReadLine());
            if(number%2 == 0)
            {
                string messageone = String.Format("El numero {0} es par",
                         number);
                Console.WriteLine(messageone);
                Console.ReadLine();
            }
            else
            {
                string messagetwo = String.Format("El numero {0} es impar",
                         number);
                Console.WriteLine(messagetwo);
                Console.ReadLine();
            }
        }
    }
}

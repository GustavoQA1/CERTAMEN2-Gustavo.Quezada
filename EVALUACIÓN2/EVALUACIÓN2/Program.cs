using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVALUACIÓN2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando estructura FOR, realizar la secuencia

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1+"  ");
                }
                Console.WriteLine("  ");

            }

            Console.WriteLine("TERMINADO");
            Console.ReadKey();






        }
    }
}

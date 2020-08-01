using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //solicite al usuario el ingreso de una palabra
            //deberá mostrar la palabra reemplazando las vocales con el numero 0

            string palabra;

            Console.WriteLine("  Sr. Usuario, ¿Quiere saber cuales son vocales en cualquier una palabra? ");
            Console.WriteLine("Con este programa las conocerá!!!. Las vocales serán transformará en ceros");
            Console.WriteLine("*************PRESIONE >>>>ENTER<<<< PARA CONTINUAR*******************");
            Console.ReadLine();

            Console.Write("Ingrese las palabra que estime conveniente: ");
            
            palabra=Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("TU RESULTADO ES....");
            Console.WriteLine(palabra.Replace("a", "0").Replace("e","0").Replace("i", "0").Replace("o", "0").Replace("u", "0").Replace("A", "0").Replace("E", "0").Replace("I", "0").Replace("O", "0").Replace("U", "0"));
            

            Console.ReadKey();
        }
    }
}

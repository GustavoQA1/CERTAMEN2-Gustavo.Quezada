using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicite N números de ingreso al usuario y luego mostrar los siguientes resultados:
            //Cantidad de Pares
            //Cantidad de Impares
            //Cantidad de positivos
            //Cantidad de negativos
            //Suma de Pares
            //Suma de Impares
            //Cantidad de numeros primos


            Console.WriteLine("Sr. Usuario, averigüe cantidad de no. pares, impares, positivos, negativos, primos y suma de pares e impares.");
            Console.WriteLine("**************************      PRESIONE >>>>ENTER<<<< PARA CONTINUAR         *****************************");
            Console.ReadLine();

            //declaración de variables
            int contador = 0;
            int limite = 0;
            int numero = 0;
            int par = 0;
            int impar = 0;
            int pos = 0;
            int neg = 0;
            int sumapar = 0;
            int sumaimpar = 0;
            int primo = 0;

            bool estado = true;

            Console.Write(">>> Ingrese la cantidad de numeros que quiere averiguar: ");
            limite = int.Parse(Console.ReadLine());

            while (estado)
            {
                contador++;
                Console.Write(">>> ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (contador == limite)
                {

                    estado = false;
                }
                if (numero % 2 == 0)
                {
                    par++;
                    sumapar += numero;

                }
                else
                {
                    impar++;
                    sumaimpar += numero;
                }

                if (numero >= 0)
                {
                    pos++;

                }
                else
                {
                    neg++;
                }



                for (int i = 1; i < (numero + 1); i++)
                {
                    if (numero % i == 0 && i == 2)
                    {
                        primo++;

                    }

                }




            }
            Console.WriteLine("");
            Console.WriteLine(">>> Cantidad de números PARES    : " + par);
            Console.WriteLine(">>> Cantidad de números IMPARES  : " + impar);
            Console.WriteLine(">>> Cantidad de números POSITIVOS: " + pos);
            Console.WriteLine(">>> Cantidad de números NEGATIVOS: " + neg);
            Console.WriteLine(">>> Cantidad de números PRIMOS   : "  + primo);
            Console.WriteLine(">>> Suma de los PARES            : " + sumapar);
            Console.WriteLine(">>> Suma de los IMPARES          : " + sumaimpar);

            Console.ReadKey();




        }
    }
}

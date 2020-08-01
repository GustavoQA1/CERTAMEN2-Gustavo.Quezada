using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // solicite al usuario que registre su nombre, username y password.
            //el ingreso de la clave debe contener 6 caracteres como minimo y 10 como maximo.
            //el username debe contener en la primera posicion el simbolo @ del cual debera validar los datos para el registro.
            // solictar nuevamente si fue un ingreso incorrecto.
            //como resultado que muestre los datos en mayusculas.


            Console.WriteLine( "    Sr. Usuario, ¿Desea saber sus datos de tu cuenta en MAYUSCULA?  ");
            Console.WriteLine("************* PRESIONE >>>>ENTER<<<< PARA CONTINUAR *******************");
            Console.ReadLine();

            //variables

            string nombre;
            string username;
            string password;
            int caracteres;
            bool flag = true;



            do
            {
                //Console.Clear();
                Console.Write(">>> Ingrese su nombre: ");
                nombre = Console.ReadLine().Trim().ToUpper();


                Console.Write(">>> Ingrese su username: ");
                username = Console.ReadLine().Trim().ToUpper();


                Console.Write(">>> Ingrese su password: ");
                password = Console.ReadLine().Trim().ToUpper();

                Console.Clear();

                if (username[0] != '@')
                {
                   
                    continue;

                }

                caracteres = password.Length;

                if (caracteres < 6 || caracteres > 10)
                {
                   
                    continue;
                }

                break;


            } while (flag);


            Console.WriteLine("");
            Console.WriteLine(">>>>>> ESTOS SON TUS DATOS EN LETRAS MAYÚSCULAS <<<<<");
            Console.WriteLine("");
            Console.WriteLine("* "+nombre);
            Console.WriteLine("* " + username);
            Console.WriteLine("* " + password);


            Console.ReadKey();





        }
    }
}

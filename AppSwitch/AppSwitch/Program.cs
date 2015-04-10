using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número entre uno y cinco en castellano. Luego
            //mostrar en formato numérico. Si se ingresa un valor fuera 
            //de dicho rango mostrar un mensaje indicando tal situación
            string numero;
            Console.WriteLine("Digite el numero en letras:");
            numero = Console.ReadLine();
            switch (numero.ToUpper()) 
            {
                case "UNO":
                    Console.WriteLine("1");
                    break;
                case "DOS":
                    Console.WriteLine("2");
                    break;
                case "TRES":
                    Console.WriteLine("3");
                    break;
                case "CUATRO":
                    Console.WriteLine("4");
                    break;
                case "CINCO":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Fuera del rango");
                    break;
            }
            Console.ReadKey();

        }
    }
}

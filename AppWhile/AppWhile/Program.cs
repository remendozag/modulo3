using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una planta que fabrica perfiles de hierro posee un lote de n piezas.
             * Confeccionar un programa que pida ingresar por teclado la cantidad de piezas 
             * a procesar y luego ingrese la longitud de cada perfil; sabiendo que la pieza 
             * cuya longitud esté comprendida en el rango de 1,20 y 1,30 son aptas. 
             * Imprimir por pantalla la cantidad de piezas aptas que hay en el lote*/
            int piezas,contador;
            float longitud;
            Console.WriteLine("Digite numero de piezas");
            piezas = int.Parse(Console.ReadLine());
            contador=1;
            while (contador <= piezas) 
            {
                Console.WriteLine("Digite longitud:");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine("La pieza " + contador + " es apta");
                }
                else
                {
                    Console.WriteLine("La pieza " + contador + " no es apta");
                }
                contador++;
            }
            Console.ReadKey();

        }
    }
}

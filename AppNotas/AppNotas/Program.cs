using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan tres notas de un alumno, si el promedio es mayor 
            //o igual a tres mostrar un mensaje "Promocionado".
            float nota1, nota2, nota3, suma, promedio;
            Console.WriteLine("Digite Nota 1:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 2:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio >= 3)
            {
                Console.WriteLine("Promocionado con:"+promedio);
            }
            else 
            {
                Console.WriteLine("No fue Promocionado con:"+promedio);
            }

            Console.ReadKey();
        }
    }
}

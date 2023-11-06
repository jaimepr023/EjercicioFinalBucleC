using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalBucleC.Servicios
{
    /// <summary>
    /// Implementacion de la interfaz PedirInterfaz
    /// <author>jpr-61123</author>
    /// </summary>
    internal class PedirImplementacion : PedirInterfaz
    {
        public int año( int año)
        {
            Console.WriteLine("Dime el año que usted quiera:");
            año = Int32.Parse(Console.ReadLine());
            return año;
        }

        public int mes(int mes)
        {
            Console.WriteLine("Dime el mes que quieras sbr los dias que tienes:");
            mes = Int32.Parse(Console.ReadLine());
            return mes;
        }
    }
}

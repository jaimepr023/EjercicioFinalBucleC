using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalBucleC.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra el metodo de la operacion
    /// <author>jpr-301023</author>
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que hace la operacion de los dias que tiene un mes
        /// <author>jpr-301023</author>
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="año"></param>
        public void operacion(int mes, int año);

        /// <summary>
        /// Metodo que realiza la condicion del bucle
        /// <author>jpr-71123</author>
        /// </summary>
        /// <returns>devuelve la condicion que nosotro le demos</returns>
        public string pedirCondicion();
    }
}

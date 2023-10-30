using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalBucleC.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra los metodos de pedir mes y pedir año
    /// <author>jpr-301023</author>
    /// </summary>
    internal interface PedirInterfaz
    {
        /// <summary>
        /// Metodo que pide por pantalla el mes y lo guarda
        /// <author>jpr-301023</author>
        /// </summary>
        /// <param name="mes"></param>
        /// <returns>int</returns>
        public int mes(int mes);
        /// <summary>
        /// Metodo que pide por pantalla el año y lo guarda
        /// <author>jpr-301023</author>
        /// </summary>
        /// <param name="año"></param>
        /// <returns>int</returns>
        public int año(int año);
    }
}

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
        /// <author>jpr-71123</author>
        /// </summary>
        /// <returns>el numero de mes</returns>
        public int mes();
        /// <summary>
        ///  /// Metodo que pide por pantalla el año y lo guarda
        /// <author>jpr-71123</author>
        /// </summary>
        /// <returns>el numero de año</returns>
        public int año();
    }
}

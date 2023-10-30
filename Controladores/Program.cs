using EjercicioFinalBucleC.Servicios;

namespace EjercicioFinalBucleC.Controladores
{
    /// <summary>
    /// Clase inicial de nuestro programa
    /// <author>jpr-301023</author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de nuestro programa donde esta el esqueleto de todos los metodos
        /// <author>jpr-301023</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            OperacionInterfaz oi = new OperacionImplementacion();
            oi.operacion();
        }
    }
}

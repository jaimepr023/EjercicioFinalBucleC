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
            PedirInterfaz pi = new PedirImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            string afirmacion;
            do
            {
                int año = pi.año();
                int mes = pi.mes();
                oi.operacion(mes, año);
                afirmacion = oi.pedirCondicion();
            } 
            while (afirmacion=="s");

        }
    }
}

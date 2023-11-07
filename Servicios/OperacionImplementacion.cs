using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinalBucleC.Servicios
{
    /// <summary>
    /// Implementtacionde la interfaz OperacionInterfaz
    /// <author>jpr-61123</author>
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void operacion(int mes, int año)
        {

            //aqui realiza toda la operacion de los meses y los años.

            if (mes == 1)
            {
                Console.WriteLine("Este mes se trata de Enero y tiene 31 dias ");
                Console.WriteLine("Y el año se trata de:" + año + "\n");

            }
            else
            {
                if (mes == 2 & año % 4 != 0)
                {
                    Console.WriteLine("Este año no es bisiesto y el mes es Febrero, lo cual tiene 28 dias");
                    Console.WriteLine("Y el año se trata de:" + año + "\n");
                }
                else
                {
                    if (mes == 2 & año % 100 != 0)
                    {
                        Console.WriteLine("Este año es bisiesto y el mes es Febrero, lo cual tiene 29 dias");
                        Console.WriteLine("Y el año se trata de:" + año + "\n");
                    }
                    else
                    {
                        if (mes == 2 & año % 400 != 0)
                        {
                            Console.WriteLine("Este año no es bisiesto y el mes es Febrero, lo cual tiene 28 dias");
                            Console.WriteLine("Y el año se trata de:" + año + "\n");
                        }
                        else
                        {
                            if (mes == 2 & año % 400 == 0)
                            {
                                Console.WriteLine("Este año es bisiesto y el mes es Febrero, lo cual tiene 29 dias");
                                Console.WriteLine("Y el año se trata de:" + año + "\n");
                            }
                            else
                            {
                                if (mes == 3)
                                {
                                    Console.WriteLine("Este mes se trata de Marzo y tiene 31 dias ");
                                    Console.WriteLine("Y el año se trata de:" + año + "\n");
                                }
                                else
                                {
                                    if (mes == 4)
                                    {
                                        Console.WriteLine("Este mes se trata de Abril y tiene 30 dias ");
                                        Console.WriteLine("Y el año se trata de:" + año + "\n");
                                    }
                                    else
                                    {
                                        if (mes == 5)
                                        {
                                            Console.WriteLine("Este mes se trata de Mayo y tiene 31 dias ");
                                            Console.WriteLine("Y el año se trata de:" + año + "\n");
                                        }
                                        else
                                        {
                                            if (mes == 6)
                                            {
                                                Console.WriteLine("Este mes se trata de Junio y tiene 30 dias ");
                                                Console.WriteLine("Y el año se trata de:" + año + "\n");
                                            }
                                            else
                                            {
                                                if (mes == 7)
                                                {
                                                    Console.WriteLine("Este mes se trata de Julio y tiene 31 dias ");
                                                    Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                }
                                                else
                                                {
                                                    if (mes == 8)
                                                    {
                                                        Console.WriteLine("Este mes se trata de Agosto y tiene 31 dias ");
                                                        Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                    }
                                                    else
                                                    {
                                                        if (mes == 9)
                                                        {
                                                            Console.WriteLine("Este mes se trata de Sepetiembre y tiene 30 dias ");
                                                            Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                        }
                                                        else
                                                        {
                                                            if (mes == 10)
                                                            {
                                                                Console.WriteLine("Este mes se trata de Octubre y tiene 31 dias ");
                                                                Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                            }
                                                            else
                                                            {
                                                                if (mes == 11)
                                                                {
                                                                    Console.WriteLine("Este mes se trata de Noviembre y tiene 30 dias ");
                                                                    Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                                }
                                                                else
                                                                {
                                                                    if (mes == 12)
                                                                    {
                                                                        Console.WriteLine("Este mes se trata de Diciembre y tiene 31 dias ");
                                                                        Console.WriteLine("Y el año se trata de:" + año + "\n");
                                                                    }
                                                                    else
                                                                    {
                                                                        if (mes < 1 & mes > 12)
                                                                        {
                                                                            Console.WriteLine("Error en el sistema, este mes no existe");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }


                        }
                    }
                }

            }
        }

        public string pedirCondicion()
        {
            Console.WriteLine("¿Quieres continuar?Elija la opcion s(si quieres avanzar)/n(si no quieres avanzar)");
            string afirmacion = Console.ReadLine();
            return afirmacion;
        }
    }
}
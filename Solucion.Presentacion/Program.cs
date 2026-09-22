using System;
using Solucion.negocio;

namespace Solucion.Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese el número de Legajo: ");

            if (int.TryParse(Console.ReadLine(), out int legajo))
            {
                AlumnoNegocio negocio = new AlumnoNegocio();
                Alumno alumno = negocio.ObtenerAlumno(legajo);

                if (alumno != null)
                {
                    Console.WriteLine($"Alumno: {alumno.Nombre}");
                    Console.WriteLine($"Condición: {alumno.Condicion}");
                }
                else
                {
                    Console.WriteLine("Error: El legajo debe ser mayor a cero o el alumno no existe.");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número entero válido.");
            }
            Console.ReadKey();
        }
    }
}
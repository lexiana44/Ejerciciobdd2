using System;
using Solucion.datos;

namespace Solucion.negocio
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
    }

    public class AlumnoNegocio
    {
        private AlumnoDatos _datos = new AlumnoDatos();

        public Alumno ObtenerAlumno(int legajo)
        {
            if (legajo <= 0) return null;

            var resultado = _datos.BuscarPorLegajo(legajo);
            if (resultado == null) return null;

            return new Alumno
            {
                Legajo = resultado.Value.Legajo,
                Nombre = resultado.Value.Nombre,
                Condicion = resultado.Value.Condicion
            };
        }
    }
}
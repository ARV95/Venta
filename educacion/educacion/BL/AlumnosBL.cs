using educacion.BL;
using educacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educacion.BL
{
    public class AlumnosBL
    {
        public List<Alumnos> Lista<Alumno> { get; set; }

        public AlumnosBL()
        {
            ListadeAlumnos = new List<Alumno> ();
        }
        public List<Alumno> ObtenerAlumnos();
        {
        var alumno1 = new Alumno();
        alumno1.Id = 1;
        Alumnos.Nombre = "Juan Perez ";
            alumno1.FechaNacimiento = DateTime.Now;
            alumno1.Direccion = " SPS ";


        }
}
}
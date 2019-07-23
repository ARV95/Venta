using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    class Alumno
    {
        public DateTime FechaNacimiento { get; internal set; }
        public int Id { get; internal set; }
        public string Nombre { get; internal set; }
        public string Telefono { get; internal set; }
    }
}

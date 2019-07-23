using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores
{
    public class producto
    { 

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public producto()
        {
            Id = 1;
        }

        public producto ( int id, string descripcion )
        {
        Id= id;
            Descripcion = descripcion;
        }
        public producto (int id, string descripcion, float precio)

  }

}

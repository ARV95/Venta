using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public Producto ObtenerProducto()
        {
            var producto1 = new Producto(1, "Laptop");

            return producto1;
        }

        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto(1, "Laptop");
            var producto2 = new Producto(2, "Mouse");

            var listadeproductos = new List<Producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);

            return listadeproductos;
        }
    }
}

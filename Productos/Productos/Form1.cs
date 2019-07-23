using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria1 = new categoria(1, "Laptops");
            var categoria2 = new categoria(2, "Accesosrios");
            var categoria3 = new categoria(3, "Monitores");

            var producto1 = new Producto

            var producto1 = new Producto(1, "  Laptop ");
            var producto2 = new Producto(2, "  Mouse ");
            var producto3 = new Producto(3, "  Monitor ");

            var productos = new List<Producto>();
            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
       
            foreach ( var producto in productos)
            {
                MessageBox.Show(producto.Id + "  " + producto.Descripcion);
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

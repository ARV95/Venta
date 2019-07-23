using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTAS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Cliente = new cliente();
            Cliente.Id = 1;
            Cliente.Nombre = "Carlos Barraza";
            Cliente.Telefono = "9980-7654";
            Cliente.Direccion = " Villas Mackay ";
            var ciudad1 = new ciudad();

            var Cliente2 = new cliente();
            Cliente2.Id = 2;
            Cliente2.Nombre = " Roberto Zelaya";
            Cliente2.Telefono = "9009-9887";
            Cliente2.Direccion = " Barrio Barandillas ";
            var ciudad2 = new ciudad();

            var Cliente3 = new cliente();
            Cliente3.Id = 3;
            Cliente3.Nombre = " Juan Carrios ";
            Cliente3.Telefono = "9087-8890";
            Cliente3.Direccion = " Barrio Morazan";
            var ciudad3 = new ciudad();

            var listadeClientes = new List<cliente>();
            listadeClientes.Add(Cliente);
            listadeClientes.Add(Cliente2);
            listadeClientes.Add(Cliente3);

            foreach (var cliente in listadeClientes)
            {
                MessageBox.Show(cliente.Id + "\n" + cliente.Nombre + "\n" + cliente.Telefono + "\n" + cliente.Direccion +
                    "\n" + cliente.Ciudad);
            }




        }
    }
}
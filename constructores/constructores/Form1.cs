using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto1 = new producto();
            producto1.Descripcion = " Laptop ";

            var producto2 = new producto(2, " Mouse ");

            var producto3 = new producto(3, " Teclado " , 200 );


            MessageBox.Show(producto1.Id + "  " + producto2.Descripcion)











        }
    }
}

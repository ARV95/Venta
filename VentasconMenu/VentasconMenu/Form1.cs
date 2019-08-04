using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasconMenu
{
    public partial class Form1 : Form
    {
         ProductosBL _productosBL;

        public Form1()
        {
            InitializeComponent();
            _productosBL = new ProductosBL();
        }
    }
}

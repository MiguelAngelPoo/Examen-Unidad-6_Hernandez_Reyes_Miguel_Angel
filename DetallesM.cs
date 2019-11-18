using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListform
{
    public partial class DetallesM : Form
    {
        public DetallesM()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {//boton para salir de detalles
            Close();
        }
    }
}

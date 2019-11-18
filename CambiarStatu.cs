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
    public partial class CambiarStatu : Form
    {
        public CambiarStatu()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {//mesaje de que se cambio el statu
            MessageBox.Show("Statu cambiado correctamente");
            Close();
        }
    }
}

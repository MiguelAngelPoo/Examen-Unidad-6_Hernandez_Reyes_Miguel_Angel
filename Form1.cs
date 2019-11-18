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
    public partial class frmPrincipal : Form
    {   //creamos una lista e instaciamos la  clase de datos tarea para que podamos usar sus datos
        public List<Datos_Tareas> DT = new List<Datos_Tareas>();
        Datos_Tareas DatoT = new Datos_Tareas();

        public frmPrincipal()
        {//inicializa la forma principal
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//el boton guardar manda a llamar al metodo guardar 
            Guardar();
        }

        public void Guardar()
        {   //con este metodo logramas guardar los datos en una lista y al mismo tiempo mostrarlos en el datagritview principal
            AgregarUsuario Au = new AgregarUsuario();
            Au.ShowDialog();

            //se capturan los datos que se toman de los texbox
            DatoT.Usuario = Au.txtNombre.Text;
            DatoT.Tarea = Au.txtNTarea.Text;
            DatoT.Hora = Au.txtHora.Text;
            DatoT.Fecha = Convert.ToDateTime(Au.txtFecha.Text);
            DatoT.Statu = Au.txtStatu.Text;
            DT.Add(DatoT);

            //mandamos los datos al datagritview especificando su columna y celda
            int Columna1 = dbgrdMostrar.Rows.Add();

            dbgrdMostrar.Rows[Columna1].Cells[0].Value = DatoT.Tarea;
            dbgrdMostrar.Rows[Columna1].Cells[1].Value = DatoT.Statu;
            dbgrdMostrar.Rows[Columna1].Cells[2].Value = DatoT.Usuario;
            dbgrdMostrar.Rows[Columna1].Cells[3].Value = DatoT.Hora;
            dbgrdMostrar.Rows[Columna1].Cells[4].Value = DatoT.Fecha;
           
            dbgrdMostrar.DataSource = null;
        }


        public void Detalles()
        {
           //instaciamos primero la forma detalles

            DetallesM M = new DetallesM();
            

            Datos_Tareas DatoT = new Datos_Tareas();

            
            //unamos este foreach para hacer referencia al datagritview y buscar dentro de el
            foreach (DataGridViewRow row in dbgrdMostrar.Rows)
            {
                //usamos la condicion para decir que cuando lo escrito en el texbox sea cierto muestre los datos dela tarea
                if (txtDetalles.Text == Convert.ToString(row.Cells["Tarea"].Value))
                {//especificamos las celdas y columnas donde se mandaran los detalles
                    M.dataGridView1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                    break;
                }
                
               
            }
            //mandamos a llamar ala forma
             M.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {//llamamos al metodo detalles mediante el boton detalles
            Detalles();
        }



        public void CambiarStatu()
        {//metodo de cambiar statu
           CambiarStatu Cst = new CambiarStatu();
            Cst.ShowDialog();
            Datos_Tareas DatoT = new Datos_Tareas();
            //instancia y llamada de la forma
            
           

           //misma condicion pero ahora cuando la condicion sea cierta se actualizara el statu en la celda indicada de otro datagritview

            foreach ( DataGridViewRow row in dbgrdMostrar.Rows )
            {
                if (Cst.txtCabS.Text == Convert.ToString(row.Cells["Tarea"].Value))
                {
                    dbgrdMostrar.Rows[row.Index].Cells[1].Value = Cst.txtNuevSta.Text;break;
                }
               
            }

        }
       

        private void btnStatus_Click(object sender, EventArgs e)
        {//llamada del statu
            CambiarStatu();
        }

        private void btnBorrarD_Click(object sender, EventArgs e)
        {//se limpian los datos del datagritview
            dbgrdMostrar.Rows.Clear();

            dbgrdMostrar.Refresh();
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {//boton para salir del programa principal
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

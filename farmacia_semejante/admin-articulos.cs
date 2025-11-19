using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia_semejante
{
    public partial class admin_articulos : Form
    {
        public admin_articulos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void admin_articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this._bd_farmacia_semejanteDataSet.ARTICULOS);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          //  var agregarArticuloForm = new agregar-articulo();
            //agregarArticuloForm.ShowDialog();
            // Después de cerrar el formulario de agregar, recargar los datos
           // this.aRTICULOSTableAdapter.Fill(this._bd_farmacia_semejanteDataSet.ARTICULOS);

        }
    }
}

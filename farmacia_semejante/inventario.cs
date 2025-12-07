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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet3.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this._bd_farmacia_semejanteDataSet3.ARTICULOS);

        }

        private void aRTICULOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRTICULOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_farmacia_semejanteDataSet3);

        }
    }
}

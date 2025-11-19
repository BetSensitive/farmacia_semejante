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
    public partial class agregar_articulos : Form
    {
        public agregar_articulos()
        {
            InitializeComponent();
        }

        private void aRTICULOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRTICULOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_farmacia_semejanteDataSet);

        }

        private void agregar_articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet2.PROVEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEDORESTableAdapter.Fill(this._bd_farmacia_semejanteDataSet2.PROVEDORES);
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet1.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
            this.dEPARTAMENTOTableAdapter.Fill(this._bd_farmacia_semejanteDataSet1.DEPARTAMENTO);
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this._bd_farmacia_semejanteDataSet.ARTICULOS);

        }
    }
}

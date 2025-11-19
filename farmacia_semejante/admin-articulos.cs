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
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet2.PROVEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEDORESTableAdapter.Fill(this._bd_farmacia_semejanteDataSet2.PROVEDORES);
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet1.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
            this.dEPARTAMENTOTableAdapter.Fill(this._bd_farmacia_semejanteDataSet1.DEPARTAMENTO);
            // TODO: esta línea de código carga datos en la tabla '_bd_farmacia_semejanteDataSet.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this._bd_farmacia_semejanteDataSet.ARTICULOS);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Esto limpia las cajas de texto y crea una fila nueva lista para escribir
            this.aRTICULOSBindingSource.AddNew();

            // Pone el cursor en el primer campo (ajusta el nombre si es necesario)
            // nombreComercialTextBox.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ingreso destino = new ingreso();
            this.Close();
            destino.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // Borra la fila seleccionada actualmente
                    this.aRTICULOSBindingSource.RemoveCurrent();

                    // Confirma el borrado en la base de datos inmediatamente
                    this.aRTICULOSBindingSource.EndEdit();
                    this.aRTICULOSTableAdapter.Update(this._bd_farmacia_semejanteDataSet.ARTICULOS);

                    MessageBox.Show("Eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Valida que el dato que acabas de escribir esté correcto (ej. que no haya letras en el precio)
                this.Validate();

                // 2. "Cierra" la edición. Esto le dice al programa: "El usuario terminó de escribir, guarda esto en la tabla temporal".
                this.aRTICULOSBindingSource.EndEdit();

                // 3. Envía los cambios de la tabla temporal a la base de datos real (SQL).
                // El TableAdapter es inteligente: detecta qué fila cambiaste y hace el UPDATE solo.
                this.aRTICULOSTableAdapter.Update(this._bd_farmacia_semejanteDataSet.ARTICULOS);

                MessageBox.Show("El artículo ha sido modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void admin_articulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Esto mata la aplicación entera, incluyendo formularios ocultos
            Application.Exit();
        }
    }
}

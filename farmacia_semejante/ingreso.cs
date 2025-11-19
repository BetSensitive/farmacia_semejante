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
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Enzo" && txtPassword.Text == "12983")
            {
                // Reemplaza 'Form2' por el nombre del formulario destino en tu proyecto
                admin_articulos destino = new admin_articulos();
                this.Hide();      // Usa Close() si quieres cerrar definitivamente este formulario
                destino.Show();   // ShowDialog() si quieres modal
              
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

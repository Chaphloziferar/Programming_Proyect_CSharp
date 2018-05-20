using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Proyect_CSharp
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
            pbxlogo.ImageLocation = "Images/Logo.png";
            pbximagenright.ImageLocation = "Images/Imagen2.png";
            pbximagenleft.ImageLocation = "Images/Imagen1.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventana_Agregar v = new Ventana_Agregar();
            v.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventana_Mostrar v = new Ventana_Mostrar();
            v.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

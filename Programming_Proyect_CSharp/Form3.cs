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
    public partial class Ventana_Mostrar : Form
    {
        private List<Persona> lista = new List<Persona>();
        public Ventana_Mostrar()
        {
            InitializeComponent();

            string file = "Personas.dat";

            if (File.Exists(file))
            {
                try
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream flujo = new FileStream("Personas.dat", FileMode.Open, FileAccess.Read);
                    lista = (List<Persona>)formateador.Deserialize(flujo);
                    flujo.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            dgvDatos.DataSource = lista;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventana_Principal v = new Ventana_Principal();
            v.Show();
        }
    }
}

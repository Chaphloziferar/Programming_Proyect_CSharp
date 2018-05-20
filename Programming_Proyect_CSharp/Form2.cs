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
    public partial class Ventana_Agregar : Form
    {
        private List<Persona> lista = new List<Persona>();
        public Ventana_Agregar()
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Debe ingresar un nombre");
                txtName.Focus();
                return;
            }
            errorProvider1.SetError(txtName, "");

            if (txtConsole.Text == "")
            {
                errorProvider1.SetError(txtConsole, "Debe ingresar una consola");
                txtConsole.Focus();
                return;
            }
            errorProvider1.SetError(txtConsole, "");

            int edad;
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                errorProvider1.SetError(txtEdad, "Debe ingresar numeros en el campo edad");
                txtEdad.Focus();
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            if (edad < 0 || edad > 100)
            {
                errorProvider1.SetError(txtEdad, "Debe ingresar una edad valida");
                txtEdad.Focus();
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            double precio;
            if (!Double.TryParse(txtPrice.Text, out precio))
            {
                errorProvider1.SetError(txtPrice, "Debe ingresar numeros en el campo precio");
                txtPrice.Focus();
                return;
            }
            errorProvider1.SetError(txtPrice, "");

            if (precio < 0)
            {
                errorProvider1.SetError(txtPrice, "Debe ingresar un precio valido");
                txtPrice.Focus();
                return;
            }
            errorProvider1.SetError(txtPrice, "");

            if (txtCode.Text == "")
            {
                errorProvider1.SetError(txtCode, "Debe ingresar un codigo");
                txtCode.Focus();
                return;
            }
            errorProvider1.SetError(txtCode, "");

            Persona persona = new Persona();
            persona.name = txtName.Text;
            persona.console = txtConsole.Text;
            persona.age = edad;
            persona.date = dtpDate.Value;
            persona.comment = txtComment.Text;
            persona.price = precio;
            persona.code = txtCode.Text;

            lista.Add(persona);

            try
            {
                BinaryFormatter formateador = new BinaryFormatter();
                Stream flujo = new FileStream("Personas.dat", FileMode.Create, FileAccess.Write);
                formateador.Serialize(flujo, lista);
                flujo.Close();

                this.Hide();

                Ventana_Principal v = new Ventana_Principal();
                v.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ventana_Principal v = new Ventana_Principal();
            v.Show();
        }
    }
}

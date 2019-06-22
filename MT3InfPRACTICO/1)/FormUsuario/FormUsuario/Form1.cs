using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void BttnMostrar_Click(object sender, EventArgs e)
        {
            String Nom;
            int Edad;
            Nom = TxtNom.Text;
            Edad = int.Parse(TxtEdadUsuario.Text);
            if (Edad < 120)//Controlo que no se ingrese una edad mayor o igual a 120
            {
               
                if (Edad >= 18)//Si posee 18(o más) años muestro una ventana emergente diciendo que es mayor
                {
                    MessageBox.Show(Nom + " es mayor de edad ");
                }
                else//Si no lo es le recuerdo que es menor con una ventana emergente
                {
                    MessageBox.Show(Nom + " es menor de edad ");
                }
            }
            else { 
                MessageBox.Show("No se permiten números mayores a 120", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
            }
            
    
        }
        private void LimpiarFormulario() {//Limpio el formulario
            TxtNom.Text = "";
            TxtEdadUsuario.Text = "";
        }
        private void TxtEdadUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))//Controlo que no se permita ingresar ningún tipo de caracter que no sean números
            {
                MessageBox.Show("Solo se permiten números", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            BloqueoMostrar();//Realizo la habilitación correspondiente del botón BttnMostrar
        }

        private void TxtEdadUsuario_TextChanged(object sender, EventArgs e)
        {
            BloqueoMostrar();//Realizo la habilitación y deshabilitación correspondiente del botón BttnMostrar
        }
        private void BloqueoMostrar() {//Controlo el bloqueo del botón BttnMostrar
            if (TxtNom.Text == "" || TxtEdadUsuario.Text == "")//Si alguno de los campos de texto está vacío bloqueo el botón de mostrar
            {
                BttnMostrar.Enabled = false;
            }
            else
            {
                BttnMostrar.Enabled = true;
            }
        }
    }
}

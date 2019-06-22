using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace UsuarioBuscando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {//Realizo el movimiento utilizando hilos con el fin de dormirlos y generar tiempo de espera
            Application.DoEvents();
            string LblMeAtrap = LblMov.Text;  
            Random random = new Random();
            if(LblMeAtrap == "Atrápame") { //Si el label dice "Atrápame" sigo moviéndolo
            LblMov.Left = random.Next(this.Size.Width-200);
            LblMov.Top = random.Next(this.Size.Height-200);
            Thread.Sleep(800);
            }
        }    

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C) {//Si se presiona la tecla C cambia el texto y en consecuencia deja de moverse
                LblMov.Text = "¡Me atrapaste!";

            }
        }

        private void LblMov_Click(object sender, EventArgs e)
        {//Si se clickea al Label cambia su texto y en consecuencia deja de moverse
            LblMov.Text = "¡Me atrapaste!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

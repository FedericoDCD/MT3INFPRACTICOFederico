using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProfesorC.Frm
{
    public partial class FrmIngresoEstudiante : Form
    {
        
        public FrmIngresoEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsEstudiantes ObjEst = new Cls.ClsEstudiantes();
            ObjEst.SetNombre(TxtNom.Text);
            if (BttnGuardar.Text == "Guardar")//Si el texto dice "Guardar" realizo la opción correspondiente, en el caso contrario modifico
            {
                if (Us.CorroborarEstudiante(ObjEst))
                {
                    Us.AEstudiante(ObjEst);
                    DGEstudiantes.DataSource = Us.BuscarEstudiantes();
                }
                else {
                    MessageBox.Show("No se puede ingresar dos veces al mismo estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                int ID = int.Parse(LblID.Text);
                ObjEst.SetNroLista(ID);
                ObjEst.SetNombre(TxtNom.Text);
                Us.MEstudiante(ObjEst);
                DGEstudiantes.DataSource = Us.BuscarEstudiantes();
            }
            LimpiarFormulario();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            //Controlo que haya algo ingresado en el textbox TxtNom y en base a eso permito o prohibo el guardar, modificar y eliminar desde el botón
            if (TxtNom.Text != "")
            {
                BttnGuardar.Enabled = true;
                if (BttnEliminar.Visible) {
                    BttnEliminar.Enabled = true;
                }
            }
            else {
                BttnGuardar.Enabled = false;
                if (BttnEliminar.Visible) {
                    BttnEliminar.Enabled = false;
                }
            }

        }
        private void LimpiarFormulario()
        {//Limpio el formulario
            TxtNom.Text = "";
            LblID.Text = "?";
        }
        private void FrmIngresoEstudiante_Load(object sender, EventArgs e)
        {
            //cargo el listado de estudiantes 
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            DGEstudiantes.DataSource = Us.BuscarEstudiantes();
        }

        private void DGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si se va a trabajar con un estudiante existente permito el cargarlo en el textbox por cada click del fila del datagridview
            if (CBIngresoExist.Checked) {
                string Nom, ID;
                Nom = DGEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
                ID = DGEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtNom.Text = Nom; 
                LblID.Text = ID;
            }
           
        }

        private void CBIngresoExist_CheckedChanged(object sender, EventArgs e)
        {
            if (CBIngresoExist.Checked)//Si se desea modificar o eliminar un estudiante bloqueo y permito las opciones correspondientes
            {
                BttnGuardar.Text = "Modificar";
                BttnEliminar.Visible = true;
                LblTxtID.Visible = true;
                LblID.Visible = true;
                LblTitulo.Text = "Gestión de estudiante";
            }
            else {//Si no se desea de igual modo bloqueo y permito las opciones correspondientes
                LblTitulo.Text = "Ingreso de estudiante";
                BttnGuardar.Text = "Guardar";
                BttnEliminar.Visible = false;
                BttnEliminar.Enabled = false;
                LblTxtID.Visible = false;
                LblID.Visible = false;
            }
        }

        private void BttnEliminar_Click(object sender, EventArgs e)
        {
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsEstudiantes ObjEst= new Cls.ClsEstudiantes();//Creo un objeto de la clase ClsEstudiantes donde almacenaré los datos del estudiante
            if (LblID.Text != "?")//Controlo que haya un estudiante seleccionado
            {
                int ID = int.Parse(LblID.Text);
                ObjEst.SetNroLista(ID);
                Us.BEstudiante(ObjEst);
                DGEstudiantes.DataSource = Us.BuscarEstudiantes();//Cargo el listado de estudiantes con el fin de actualizarlo
            }
            else {//si no es el caso le aviso al usuario
                MessageBox.Show("Seleccione en el listado el estudiante que desea gestionar");
            }
            LimpiarFormulario(); 
        }
    }
}

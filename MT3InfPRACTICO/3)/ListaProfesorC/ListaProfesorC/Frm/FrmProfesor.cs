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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        //Abro el formulario de ingreso de estudiantes
        private void button1_Click(object sender, EventArgs e)
        {
            FrmIngresoEstudiante FrmIng = new FrmIngresoEstudiante();
            FrmIng.Show();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            //Cargo los listados tanto de los estudiantes como de las faltas
            DGEst.DataSource = Us.BuscarEstudiantes();
        }


        private void button2_Click(object sender, EventArgs e)
        {//Ingreso la falta
            int ID;
            int Fictas;
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsFalta ObjFalt = new Cls.ClsFalta();//Creo un objeto de la clase ClsFalta donde almacenaré los datos de la falta
            ID= int.Parse(TxtNum.Text);
            ObjFalt.SetIDEstudiante(ID);
            ObjFalt.SetFecha(DTPFecha.Value);
            Us.AltaFalta(ObjFalt);//Una vez asignados los datos de la falta en el objeto ObjFalt inserto la falta
            DGFalta.DataSource = Us.BuscarFalta(ObjFalt);//Cargo el listado de faltas otra vez con el fin de actualizarlo
            TxtNum.Text = "";//Limpio el textbox
            Fictas = int.Parse(LblFic.Text);
            Fictas++;//Incremento la ficta a modo de actualización
            LblFic.Text = Fictas.ToString();//Cargo las fictas
            DGEst.DataSource = Us.BuscarEstudiantes();//Actualizo los estudiantes para ver las nuevas faltas
           
            
            
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {//Controlo que sólo pueda asignar una falta mediante el botón si el texbox no está vacío
            if (TxtNum.Text != "")
            {
                BttnCol.Enabled = true;
            }
            else{
                BttnCol.Enabled = false;
            }
        }
        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {//Controlo que sólo se ingresen números
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
            
        }

        private void DGEst_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Según el estudiante seleccionado coloco la id en el textbox TxtNum que se encarga de almacenar las nuevas faltas
            int ID, Falt, Fic;
            DataRow DR;
            DataTable DT = new DataTable();
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsFalta ObjFalt = new Cls.ClsFalta();
            ID =int.Parse(DGEst.Rows[e.RowIndex].Cells[0].Value.ToString());
            Falt= int.Parse(DGEst.Rows[e.RowIndex].Cells[2].Value.ToString());
            TxtNum.Text = ID.ToString();
            ObjFalt.SetIDEstudiante(ID);
            DT = Us.ObtenerFictas(ObjFalt);
            DGFalta.DataSource = Us.BuscarFalta(ObjFalt);//Cargo el listado de faltas otra vez con el fin de actualizarlo
            DR = Us.ObtenerFictas(ObjFalt).Rows[0];
            Fic = int.Parse(DR[0].ToString());
            LblFic.Text = Fic.ToString();//Asigno el resultado de las Fictas en el Label LblFic
        }


        private void DGFalta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dependiendo de la falta seleccionada coloco su id en un texbox para ofrecer la poisibilidad de darle de baja
            int IDFalt;
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsFalta ObjFalt = new Cls.ClsFalta();
            bool EstadoFalta;
            IDFalt = int.Parse(DGFalta.Rows[e.RowIndex].Cells[0].Value.ToString());
            EstadoFalta = bool.Parse(DGFalta.Rows[e.RowIndex].Cells[3].Value.ToString());
            TxtIDFalt.Text = IDFalt.ToString();
            if (EstadoFalta)//Si la falta ya está justificada deshabilito el botón de Justificar y en el caso contrario lo habilito
            {
                BttnJustificar.Enabled = false;
            }
            else {
                BttnJustificar.Enabled = true;
            }
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //Justifico la falta y actualizo el datagridview
            Cls.ClsUsuario Us = new Cls.ClsUsuario();
            Cls.ClsFalta ObjFalt = new Cls.ClsFalta();
            int IDFalt;
            int IDEst;
            int Fic;
            DataRow DR;
            DialogResult Resultado = MessageBox.Show("¿Desea justificar esta falta? Este cambio no puede deshacerse", "Justificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(Resultado == DialogResult.OK)//Si se aceptó el mensaje en el messagebox justifico la falta
            {
            IDFalt = int.Parse(TxtIDFalt.Text);
            IDEst = int.Parse(TxtNum.Text);
            ObjFalt.SetID(IDFalt);
            ObjFalt.SetIDEstudiante(IDEst);
            Us.JustificarFalta(ObjFalt);
            DGFalta.DataSource = Us.BuscarFalta(ObjFalt);
            DR = Us.ObtenerFictas(ObjFalt).Rows[0];
            Fic = int.Parse(DR[0].ToString());
            LblFic.Text = Fic.ToString();//Asigno el resultado de las Fictas en el Label LblFic
            }
        }  
    }
}

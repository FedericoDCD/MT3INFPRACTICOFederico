using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
namespace ListaProfesorC.Cls
{
    class ClsUsuario
    {
        public void AEstudiante(ClsEstudiantes ObjEs) { //Utilizo el procedimiento almacenado con el fin de ingresar a un nuevo estudiante
            ClsBD BD = new ClsBD();
            string Nombre = ObjEs.GetNombre();
            using (SqlCommand comand = new SqlCommand("PAAgregarEstudiante", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    MessageBox.Show("¡" + Nombre + " guardado con éxito!");
                }
                catch(Exception ex){
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable  BuscarEstudiantes() {
            ClsBD BD = new ClsBD();
            using (SqlCommand comand = new SqlCommand("PAEstudianteselect", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    return DT;
                    
                }
                catch (Exception ex)
                {
                    Console.Write("Error al buscar: " + ex.Message);
                    return null;
                }
            }
        }
        public void MEstudiante(ClsEstudiantes ObjEs)
        { //Utilizo el procedimiento almacenado con el fin de modificar un estudiante
            ClsBD BD = new ClsBD();
            string Nombre = ObjEs.GetNombre();
            int ID = ObjEs.GetNroLista();
            using (SqlCommand comand = new SqlCommand("PAModificarEstudiante", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@ID", ID));
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    MessageBox.Show("¡" + Nombre + " modificado con éxito!");
                }
                catch (Exception ex)
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void BEstudiante(ClsEstudiantes ObjEs)
        { //Utilizo el procedimiento almacenado con el fin de dar de baja a un estudiante
            ClsBD BD = new ClsBD();
            int ID= ObjEs.GetNroLista();
            using (SqlCommand comand = new SqlCommand("PABajaEstudiante", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@ID", ID));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    MessageBox.Show("¡Estudiante dado de baja con éxito!");
                }
                catch (Exception ex)
                {
                    Console.Write("Error al eliminar: " + ex.Message);
                }
            }
        }
            public System.Data.DataTable BuscarFalta(ClsFalta ObjFalta)
        {//Busco las faltas en base a ID del estudiante y las restorno en un DataTable
            ClsBD BD = new ClsBD();
            int IDEst = ObjFalta.GetIDEstudiante();
            using (SqlCommand comand = new SqlCommand("PAFaltaselect", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@IDEstudiante", IDEst));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    return DT;
                }
                catch (Exception ex)
                {
                    Console.Write("Error al buscar: " + ex.Message);
                    return null;
                }
            }
        }
        public void AltaFalta(ClsFalta ObjFalta)
        {
            //Inserto una nueva falta y actualizo las faltas de los estudiantes que faltaron
            ClsBD BD = new ClsBD();
            DateTime Fecha = ObjFalta.GetFecha();
            int IDEstudiante = ObjFalta.GetIDEstudiante();
            using (SqlCommand comand = new SqlCommand("PAPonerfalta", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                    comand.Parameters.Add(new SqlParameter("@IDEstudiante", IDEstudiante));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    MessageBox.Show("guardado con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                using (SqlCommand com = new SqlCommand("PAActualizarFalt", BD.Conn))
                {
                    try
                    {
                        com.CommandType = System.Data.CommandType.StoredProcedure;
                        com.Parameters.Add(new SqlParameter("@IDEstudiante", IDEstudiante));
                        System.Data.DataTable DT = new System.Data.DataTable();
                        SqlDataAdapter DA = new SqlDataAdapter(com);
                        BD.Open();
                        DA.Fill(DT);
                        BD.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                }
            }
        }
        public void JustificarFalta(ClsFalta ObjFalta)
        {
            //Modifico una falta para justificarla según su ID
            ClsBD BD = new ClsBD();
            int IDFalt = ObjFalta.GetID();
            using (SqlCommand comand = new SqlCommand("PAJustificarFalta", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@IdFalt", IDFalt));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    MessageBox.Show("guardado con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable ObtenerFictas(ClsFalta ObjFalta)
        {
            //Obtengo las fictas calculadas en base de datos y las retorno
            ClsBD BD = new ClsBD();
            int IDEst = ObjFalta.GetIDEstudiante();
            using (SqlCommand comand = new SqlCommand("PAAFicta", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@IDEst", IDEst));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    return DT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                    return null;
                }
            }
        }
        public bool CorroborarEstudiante(ClsEstudiantes ObjEst) {
            //Busco si hay otro estudiante con el mismo nombre
            ClsBD BD = new ClsBD();
            String Nom = ObjEst.GetNombre();
            using (SqlCommand comand = new SqlCommand("PACorroborarEstudiante", BD.Conn))
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nom));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();
                    DA.Fill(DT);
                    BD.Close();
                    //Si hay un registro entonces retorno false(cuando se retorna false se da a entender que no se puede ingresar el estudiante deseado)
                    if (DT.Rows.Count != 0)
                    
                    {
                        return false;
                    }
                    else {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                    return false;
                }
            }
        }
    }
}

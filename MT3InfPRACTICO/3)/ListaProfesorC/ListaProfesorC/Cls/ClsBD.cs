using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ListaProfesorC.Cls
{
    class ClsBD
    {//Guardo la stringconnection y realizo las conexiones necesarias y métodos para mejorar su uso desde otras clases
        string StringConnection = "Data Source=ALICIA\\SQLEXPRESS;Initial Catalog = BDListaProfesor; Integrated Security = True";
        public SqlConnection Conn = new SqlConnection();
        public ClsBD() {
            Conn.ConnectionString = StringConnection;
        }
        public void Open() {//Abro la conexión
            try{
                Conn.Open();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Close() {//Cierro la conexión
            try
            {
                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

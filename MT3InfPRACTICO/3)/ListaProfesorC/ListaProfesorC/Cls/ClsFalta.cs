using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProfesorC.Cls
{
    class ClsFalta
    {
        //Atributos
        private int ID;
        private DateTime Fecha;
        private int IDEstudiante;
        //Getters y setters
        public void SetID(int ID) {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }
        public DateTime GetFecha()
        {
            return Fecha;
        }
        public void SetIDEstudiante(int IDEstudiante)
        {
            this.IDEstudiante = IDEstudiante;
        }
        public int GetIDEstudiante()
        {
            return IDEstudiante;
        }


    }
}

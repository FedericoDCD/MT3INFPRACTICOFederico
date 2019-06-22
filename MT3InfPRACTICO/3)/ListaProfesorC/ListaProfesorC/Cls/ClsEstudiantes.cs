using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProfesorC.Cls
{
    class ClsEstudiantes
    {
        //Atributos
        private int NroLista;
        private String Nombre;
        //Getters y setters
        public void SetNroLista(int NroLista)
        {
            this.NroLista = NroLista;
        }
        public int GetNroLista()
        {
            return NroLista;
        }
        public void SetNombre(string Nombre)
        {
            this.Nombre= Nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }

    }
}

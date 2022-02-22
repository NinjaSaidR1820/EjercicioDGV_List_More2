using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDGV_List_More
{
    class Usuario
    {
        string tipoUsuario;
        string codigo;
        string nombre;
        string apellido;
        string nCarnet;
        string carrera;
        string genero;
        string celular;
        string correo;

        public Usuario()
        {
            TipoUsuario = string.Empty;
            Codigo = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            NCarnet = string.Empty;
            Carrera = string.Empty;
            Genero = string.Empty;
            Celular = string.Empty;
            Correo = string.Empty;
        }

        public Usuario(string tipoUsuario, string codigo, string nombre,string apellido, string nCarnet, string carrera, string genero, string celular, string correo)
        {
            this.TipoUsuario = tipoUsuario;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NCarnet = nCarnet;
            this.Carrera = carrera;
            this.Genero = genero;
            this.Celular = celular;
            this.Correo = correo;
        }

        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NCarnet { get => nCarnet; set => nCarnet = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Apellido { get => apellido; set => apellido = value; }



        public string nombreorder()
        {
            return "Nombre " + Nombre + " Con Codigo " + Codigo+ "\r\n";
        }


        public string ByGenero()
        {
            return Nombre + " " + Apellido + " "+Genero +"\r\n";
        }

        public string ByCarrera()
        {
            return Nombre + " " + Apellido + " Con Carrera" + Carrera + "\r\n";
        }


    }
}

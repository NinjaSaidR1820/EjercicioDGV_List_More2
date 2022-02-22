using EjercicioDGV_List_More.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDGV_List_More
{
    public partial class Form1 : Form
    {
        List<string> listaUsuario = new List<string>();

        public Form1()
        {
            InitializeComponent();
            listaUsuario.Add("Administrador");
            listaUsuario.Add("Estudiante");
            listaUsuario.Add("Profesor");

            foreach (string d in listaUsuario)
            {
                cbTipoUsuario_InicioSesion.Items.Add(d);
            }

            tpMensaje.SetToolTip(this.txtUsuario, "Ingresar Nombre De Usuario");
            tpMensaje.SetToolTip(this.txtContraseña, "Ingresar Una Contraseña");
            tpMensaje.SetToolTip(this.cbTipoUsuario_InicioSesion, "Ingresar Un Tipo De Usuario");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "Admin123" )
            {
                this.Hide();
                Registro rg = new Registro();
                rg.lblBienvenida.Text = "Bienvenido " + txtUsuario.Text;

                rg.Show();
                

            }
            else
            {
                MessageBox.Show("El Nombre de Usuario o la Contraseña Pueden Ser Erroneos \r\n Por Favor Verifique Los Datos Y Vuelva a Intentarlo",
                    "Error de Inicio De Sesion", MessageBoxButtons.OK);
                txtContraseña.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnIniciarSesion.Enabled = false;
    
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" )
            {
                BtnIniciarSesion.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" )
            {
                BtnIniciarSesion.Enabled = true;
            }
        }
    }
}

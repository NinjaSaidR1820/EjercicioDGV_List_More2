using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDGV_List_More.Forms
{
    public partial class Registro : Form
    {
        List<string> listaUsuario = new List<string>();
        List<string> genero = new List<string>();
        List<string> carrera = new List<string>();
        List<Usuario> lista = new List<Usuario>();


        Usuario mondongo;

        int contador = 0;

        public Registro()
        {
            InitializeComponent();
            listaUsuario.Add("Administrador");
            listaUsuario.Add("Estudiante");
            listaUsuario.Add("Profesor");

            foreach (string d in listaUsuario)
            {
                cbTipodeUsuario_Registro.Items.Add(d);
            }

            
            genero.Add("Masculino");
            genero.Add("Femenino");
            

            foreach (string x in genero)
            {
                cbGenero.Items.Add(x);
            }

            carrera.Add("Ing.Sistemas");
            carrera.Add("Arquitectura");
            carrera.Add("Ing.Civil");
            carrera.Add("Diseño de Interiores");
            carrera.Add("Medicina");
            
            

            foreach (string c in carrera)
            {
                cbCarrera.Items.Add(c);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }


        



        private void Registro_Load(object sender, EventArgs e)
        {
            dgvRegistro.DataSource = lista;
            cbTipodeUsuario_Registro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           

            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtCedula.Text == "" || txtCodigo.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Porfavor Rellenar los Campos Vacios", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                GuardarUsuario();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            txtCONSULTA.Clear();


            txtCONSULTA.AppendText("El Numero de Registros Es De: "+contador );

        }


        public void getOrdenarPorNombre()
        {

            IEnumerable<Usuario> nom = from d in lista orderby d.Nombre ascending select d;

            foreach (Usuario u in nom)
            {

                txtCONSULTA.AppendText(u.nombreorder());
            }
        }

        public void GetGeneroMasculino()
        {

            IEnumerable<Usuario> gen = from d in lista orderby d.Genero == "Masculino" select d;
            

              foreach (Usuario u in gen)
              {
                    txtCONSULTA.Clear();
                    txtCONSULTA.AppendText(u.ByGenero());

              }
          

         

        }

        public void GetGeneroFemenino()
        {

            
            IEnumerable<Usuario> gen2 = from d in lista orderby d.Genero == "Femenino" select d;

              
                foreach (Usuario u in gen2)
                {

                    txtCONSULTA.Clear();
                    txtCONSULTA.AppendText(u.ByGenero());

                }

        }

        public void GetCarrera()
        {


            IEnumerable<Usuario> carr = from d in lista orderby d.Carrera select d;

            txtCONSULTA.Clear();
            foreach (Usuario u in carr)
            {
                txtCONSULTA.AppendText(u.ByCarrera());

            }



        }


        private void rbOrdenado_CheckedChanged(object sender, EventArgs e)
        {
            
            txtCONSULTA.Clear();
            getOrdenarPorNombre();  
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            txtCONSULTA.Clear();
            GetGeneroMasculino();
            

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            GetGeneroFemenino();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            GetCarrera();
        }


        private void limpiar()
        {
            cbTipodeUsuario_Registro.SelectedIndex = -1;
            cbCarrera.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtCodigo.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }


        #region CRUD
        public void GuardarUsuario()
        {

            mondongo = new Usuario(cbTipodeUsuario_Registro.Text, txtCodigo.Text, txtNombres.Text, txtApellidos.Text,
                 txtCedula.Text, cbCarrera.Text, cbGenero.Text, txtTelefono.Text, txtEmail.Text);

            lista.Add(mondongo);


            ActualizarLista();

            limpiar();


            contador = dgvRegistro.RowCount;
        }

        public void ActualizarLista()
        {

            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = lista;
            txtBuscar.Text = "";
        }

        public void Delete(string xd)
        {

            foreach( var usuario in lista)
            {

                if(usuario.Codigo == xd)
                {
                    lista.Remove(usuario);
                    break;

                }

            }


        }




        public void Buscar(string xd)
        {

            foreach (var usuario in lista)
            {

                if (usuario.Codigo == xd)
                {

                    cbTipodeUsuario_Registro.Text = usuario.TipoUsuario;
                    txtCodigo.Text = usuario.Codigo;
                    txtNombres.Text = usuario.Nombre;
                    txtApellidos.Text = usuario.Apellido;
                    txtCedula.Text = usuario.NCarnet;
                    cbGenero.Text = usuario.Genero;
                    cbCarrera.Text = usuario.Carrera;
                    txtTelefono.Text = usuario.Celular;
                    txtEmail.Text = usuario.Correo;

                    break;


                }

            }


        }



        public void modificar(string d)
        {

            foreach (var u in lista)
            {

                if (u.Codigo == d)
                {

                    u.TipoUsuario = cbTipodeUsuario_Registro.Text;
                    u.Codigo = txtCodigo.Text;
                    u.Nombre = txtNombres.Text;
                    u.Apellido = txtApellidos.Text;
                    u.NCarnet = txtCedula.Text;
                    u.Genero = cbGenero.Text;
                    u.Carrera = cbCarrera.Text;
                    u.Celular = txtTelefono.Text;
                    u.Correo = txtEmail.Text;

                    break;
                }
            }

        }

      


        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete(txtBuscar.Text);
            ActualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificar(txtBuscar.Text);
            ActualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }
    }
}

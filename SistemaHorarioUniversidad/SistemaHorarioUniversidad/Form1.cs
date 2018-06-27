using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;

using Capa_de_Negocio;
namespace SistemaHorarioUniversidad
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        //Codigo usado en el evento mousedown del formulario para poder arrastrarlo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtUser_Enter_Enter(object sender, EventArgs e)
        {
            //Si el texto es igual a "usuario", de ser asi se vacea 
            if (txtUsuario.Text == "Ingresar")
            {
                txtUsuario.Text = "";
                //color de fuente grisclaro, para que al momento de escribir resalte mas el color del texto
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            //Para que el cursor del mouse salga del texto
            //Preguntamos si el texto esta vacio, de ser asi la propiedad text volvera a tener
            //el texto "usuario"
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresar";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "*******")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "*******";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Evento para mover el Formulario 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtUsuario.Text;
                string con = txtPassword.Text;
                using (HorariosIEntities obj = new HorariosIEntities())
                {
                    usuario ocli = (from q in obj.usuario
                                    where q.id == id && q.contraseña == con
                                    select q).First();

                    
                }
                MessageBox.Show("se ingreso correctamente");

                this.Hide();
                Form2 obj1 = new Form2();
                obj1.Show();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, " Usuario o Contraseña incorrecta. Vuelva a ingresar Por Favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

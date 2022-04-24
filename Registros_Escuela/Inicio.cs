using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros_Escuela
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {

            if (txtUser.Text== "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;


            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;


            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;


            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text=="")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor= Color.DimGray;
                txtPass.UseSystemPasswordChar=false;
            }
        }
    }
}

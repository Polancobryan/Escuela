using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class login : Form

    {
        private Conectar datos = new Conectar();


        public login()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singup llamar = new singup();
            llamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String conec;
                SqlCommand comando = new SqlCommand();
                SqlConnection cnn;

                conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
                cnn = new SqlConnection(conec);
                cnn.Open();
                comando.Connection = cnn;
                comando.CommandText = "select * from Estudiantes where Nombre = @Nombre and Clave = @Clave";
                comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                comando.Parameters.AddWithValue("@Clave", txtpassword.Text);
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Sesion por Profesor Estudiante sastifactoriamente");
                    cnn.Close();
                    Estudiante alumno = new Estudiante();
                    alumno.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("No se pudo iniciar sesion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                            "" + ex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conec;
                SqlCommand comando = new SqlCommand();
                SqlConnection cnn;

                conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
                cnn = new SqlConnection(conec);
                cnn.Open();
                comando.Connection = cnn;
                comando.CommandText = "select * from Profesores where Nombre = @Nombre and Clave = @Clave";
                comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                comando.Parameters.AddWithValue("@Clave", txtpassword.Text);
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Sesion por Profesor iniciada sastifactoriamente");
                    cnn.Close();
                    entidades profesor = new entidades();
                    profesor.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("No se pudo iniciar sesion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                            "" + ex);
            }
        }
        //Director
        private void button2_Click_1(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Hide();
            MessageBox.Show("Sesion por Director iniciada sastifactoriamente");

        }
    }
}

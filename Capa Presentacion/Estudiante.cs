using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Estudiante : Form
    {
        acciones datos = new acciones();
        private string id = null;
        public Estudiante()

        {
            InitializeComponent();
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            acciones objeto = new acciones();
            dataGridView1.DataSource = objeto.consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login inicio = new login();
            inicio.Show();
            this.Hide();
        }
    }
}

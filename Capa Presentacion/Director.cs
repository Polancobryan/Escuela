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
    public partial class Director : Form
    {
        acciones datos = new acciones();
        private string id = null;
        public Director()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }


        private void gpConsultar()
        {
            acciones objeto = new acciones();
            dataGridView1.DataSource = objeto.gpConsultar();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                datos.gpEliminar(id);
                MessageBox.Show("Eliminado correctamente");
                gpConsultar();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }



        private void limpiarForm()
        {
            txtidp.Clear();
            txtnombrep.Clear();
            txtclavep.Clear();
            txtmateriap.Clear();
            txttelefonop.Clear();
            txtcorreop.Clear();
            txtsueldop.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    Metodos datos = new Metodos();
                    datos.gpCambiar(Convert.ToInt32(txtidp.Text), txtnombrep.Text, txtclavep.Text, txtmateriap.Text, txttelefonop.Text, txtcorreop.Text, txtsueldop.Text);
                    MessageBox.Show("El registro fue actualizado correctamente");
                    gpConsultar();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Su registro no pudo ser actualizado debido a: " +
                        "" + ex);
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login ir = new login();
            ir.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidp.Text == String.Empty || txtnombrep.Text == String.Empty  || txtclavep.Text == String.Empty || txtmateriap.Text == String.Empty ||  txttelefonop.Text == String.Empty || txtcorreop.Text == String.Empty || txtsueldop.Text == String.Empty)
                {
                    MessageBox.Show("Completa todos los campos!");
                }
                else
                {
                    Metodos datos = new Metodos();
                    datos.gpAgregar(txtnombrep.Text, txtclavep.Text, txtmateriap.Text, txttelefonop.Text, txtcorreop.Text, txtsueldop.Text);
                    MessageBox.Show("Se agrego el registro correctamente");
                    gpConsultar();
                    limpiarForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Su registro no pudo ser agregado debido a: " +
                    "" + ex);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtidp.Text = row.Cells[0].Value.ToString();
                txtnombrep.Text = row.Cells[1].Value.ToString();
                txtclavep.Text = row.Cells[2].Value.ToString();
                txtmateriap.Text = row.Cells[3].Value.ToString();
                txttelefonop.Text = row.Cells[4].Value.ToString();
                txtcorreop.Text = row.Cells[5].Value.ToString();
                txtsueldop.Text = row.Cells[6].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Director_Load_1(object sender, EventArgs e)
        {
            gpConsultar();
        }
    }
}

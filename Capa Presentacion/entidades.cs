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
    public partial class entidades : Form
    {
        acciones datos = new acciones();
        private string id = null;
        public entidades()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void entidades_Load(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            acciones objeto = new acciones();
            dataGridView1.DataSource = objeto.consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //--------------------------------------------------btnCAMBIAR
        private void button4_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        Metodos datos = new Metodos();
                        datos.cambiar(Convert.ToInt32(txtid.Text), txtMatricula.Text, txtNombre.Text, textEspanol.Text, txtHistoria.Text, textIngles.Text, txtFrances.Text, textNaturales.Text, textMatematica.Text, txtEtica.Text, textContabilidad.Text);
                        MessageBox.Show("El registro fue actualizado correctamente");
                        consultar();
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

        //---------------------------------------------------btnGUARDAR
        private void button5_Click(object sender, EventArgs e)
        {
                try
                {   
                    if (txtEtica.Text == String.Empty || txtApellido.Text == String.Empty  || txtMatricula.Text == String.Empty || txtHistoria.Text == String.Empty ||  txtNombre.Text == String.Empty) 
                    {
                        MessageBox.Show("Completa todos los campos!");
                    }
                    else
                    {
                        Metodos datos = new Metodos();
                        datos.agregar(txtMatricula.Text, txtNombre.Text, txtApellido.Text , txtEtica.Text, txtHistoria.Text, textEspanol.Text, textMatematica.Text, textIngles.Text, textContabilidad.Text, txtFrances.Text , textNaturales.Text);
                        MessageBox.Show("Se agrego el registro correctamente");
                        consultar();
                        limpiarForm();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Su registro no pudo ser agregado debido a: " +
                        "" + ex);
                }
        }

        private void limpiarForm()
        {
            txtEtica.Clear();
            txtApellido.Clear();
            txtMatricula.Clear();
            txtHistoria.Clear();
            txtNombre.Clear();
            txtFrances.Clear();
            txtMatricula.Clear();
            textMatematica.Clear();
            textContabilidad.Clear();
            textEspanol.Clear();
            textIngles.Clear();
            textNaturales.Clear();
            txtid.Clear();
        }

        private void sakirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sistemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about acerca_de = new about();
            acerca_de.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tiposEntidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtMatricula.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                textEspanol.Text = row.Cells[3].Value.ToString();
                txtHistoria.Text = row.Cells[4].Value.ToString();
                textIngles.Text = row.Cells[5].Value.ToString();
                txtFrances.Text = row.Cells[6].Value.ToString();
                textNaturales.Text = row.Cells[7].Value.ToString();
                textMatematica.Text = row.Cells[8].Value.ToString();
                txtEtica.Text = row.Cells[9].Value.ToString();
                textContabilidad.Text = row.Cells[10].Value.ToString();
            }
        }

        //-------------------------------------------------btnBORRAR
        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                datos.Eliminar(id);
                MessageBox.Show("Eliminado correctamente");
                consultar();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login ir = new login();
            ir.Show();
            this.Hide();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

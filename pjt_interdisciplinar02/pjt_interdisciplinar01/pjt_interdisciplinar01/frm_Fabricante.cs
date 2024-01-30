using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pjt_interdisciplinar01
{
    public partial class frm_Fabricante : Form
    {
        public frm_Fabricante()
        {
            InitializeComponent();
        }
        private void Inserir_Fabricante(string id_fabricante, string nome_fabricante)
        {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO tb_fabricante (id_fabricante, nm_fabricante) VALUES (@id_fabricante, @nome_fabricante)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_fabricante", id_fabricante);
                    cmd.Parameters.AddWithValue("@nome_fabricante", nome_fabricante);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        private void Grid_Fabricantes()
        {
            Grid_View("SELECT id_fabricante, nm_fabricante FROM tb_fabricante", Grid_02);
        }

        private void Grid_View(string query, DataGridView dataGridView)
        {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                connection.Open();
                adapter.Fill(dt);
            }

            Grid_02.DataSource = dt;
        }

        private void btn_inse_Click(object sender, EventArgs e)
        {
            string id_Fabricante = "0";
            string nome_Fabricante = txt_fabri.Text;

            if (String.IsNullOrWhiteSpace(nome_Fabricante))
            {
                MessageBox.Show("O campo 'Fabricante' é de preenchimento obrigatório!");
            }
            else
            {
                Inserir_Fabricante(id_Fabricante, nome_Fabricante);

                Grid_Fabricantes();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Box_Fabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_fabri_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            frm_UniFederativa outroForm = new frm_UniFederativa();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void frm_Fabricante_Load(object sender, EventArgs e)
        {
            Grid_Fabricantes();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Carros outroForm = new frm_Carros();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Fabricante outroForm = new frm_Fabricante();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Modelo outroForm = new frm_Modelo();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void unidadeFederativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UniFederativa outroForm = new frm_UniFederativa();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Cliente outroForm = new frm_Cliente();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Aluguel outroForm = new frm_Aluguel();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Devolucao outroForm = new frm_Devolucao();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
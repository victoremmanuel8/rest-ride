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
    public partial class frm_UniFederativa : Form
    {
        public frm_UniFederativa()
        {
            InitializeComponent();
        }

        private void Inserir_Estado_Cidade(string nome_estado, string sg_estado, string nome_cidade)
        {
            string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

               
                string queryEstado = "INSERT INTO tb_estado (nm_estado, sigla_estado) VALUES (@nome_estado, @sg_estado);";

                using (MySqlCommand cmdEstado = new MySqlCommand(queryEstado, connection))
                {
                    cmdEstado.Parameters.AddWithValue("@nome_estado", nome_estado);
                    cmdEstado.Parameters.AddWithValue("@sg_estado", sg_estado);
                    cmdEstado.ExecuteNonQuery();
                }

                
                string queryGetEstadoID = "SELECT LAST_INSERT_ID();";
                int id_estado;

                using (MySqlCommand cmdGetEstadoID = new MySqlCommand(queryGetEstadoID, connection))
                {
                    id_estado = Convert.ToInt32(cmdGetEstadoID.ExecuteScalar());
                }

               
                string queryCidade = "INSERT INTO tb_cidade (nm_cidade, id_estado) VALUES (@nome_cidade, @id_estado);";

                using (MySqlCommand cmdCidade = new MySqlCommand(queryCidade, connection))
                {
                    cmdCidade.Parameters.AddWithValue("@nome_cidade", nome_cidade);
                    cmdCidade.Parameters.AddWithValue("@id_estado", id_estado);
                    cmdCidade.ExecuteNonQuery();
                }
            }
        }

        private void AtualizarDataGrid_05()
        {
            string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";

            string query = "SELECT e.id_estado, e.nm_estado, e.sigla_estado, c.nm_cidade AS nm_cidade_estado " +
                           "FROM tb_estado e " +
                           "INNER JOIN tb_cidade c ON e.id_estado = c.id_estado";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                connection.Open();
                adapter.Fill(dt);
            }

            Grid_01.DataSource = dt;
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frm_Fabricante outroForm = new frm_Fabricante();

            this.Visible = false;

            outroForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string nome_estado = cbbox_estado.Text;
            string sg_estado = cbbox_sigla.Text;
            string nome_cidade = txt_cidade.Text;

            if (String.IsNullOrWhiteSpace(nome_estado))
            {
                MessageBox.Show("O campo 'Estado' é de preenchimento obrigatório!");
            }

            else if (String.IsNullOrWhiteSpace(nome_cidade))
            {
                MessageBox.Show("O campo 'Cidade' é de preenchimento obrigatório!");
            }

            else if (String.IsNullOrWhiteSpace(sg_estado))
            {
                MessageBox.Show("O campo 'Sigla' é de preenchimento obrigatório!");
            }
            

            else
            {
                Inserir_Estado_Cidade(nome_estado, sg_estado, nome_cidade);
                AtualizarDataGrid_05();
            }
        }

        private void cbbox_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbox_sigla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid_05();
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
    }
 }


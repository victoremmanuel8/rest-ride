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

    public partial class frm_Modelo : Form
    {
        public frm_Modelo()
        {
            InitializeComponent();
        }
        private void Carregar_Fabricantes()
        {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB";
            string query = "SELECT id_fabricante, nm_fabricante FROM tb_fabricante";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    gcbbox_Fabricantes.DataSource = dt;
                    gcbbox_Fabricantes.DisplayMember = "nm_fabricante";
                    gcbbox_Fabricantes.ValueMember = "id_fabricante";
                }
            }
        }

        //Estou pegando desse
        private void Inserir_Fabri_Model(string nome_fabricante, string nome_modelo)
        {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Obter o ID do fabricante
                string queryGetFabriID = "SELECT id_fabricante FROM tb_fabricante WHERE nm_fabricante = @nome_fabricante LIMIT 1;";
                int id_fabri;

                using (MySqlCommand cmdGetFabriID = new MySqlCommand(queryGetFabriID, connection))
                {
                    cmdGetFabriID.Parameters.AddWithValue("@nome_fabricante", nome_fabricante);
                    object result = cmdGetFabriID.ExecuteScalar();

                    if (result != null)
                    {
                        id_fabri = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Se o fabricante não existe, não deve prosseguir com a inserção do modelo
                        MessageBox.Show("Fabricante não encontrado.");
                        return;
                    }
                }

                // Inserir o modelo
                string queryModelo = "INSERT INTO tb_modelo (nm_modelo, id_fabricante) VALUES (@nome_modelo, @id_fabricante);";
                using (MySqlCommand cmdModelo = new MySqlCommand(queryModelo, connection))
                {
                    cmdModelo.Parameters.AddWithValue("@nome_modelo", nome_modelo);
                    cmdModelo.Parameters.AddWithValue("@id_fabricante", id_fabri);
                    cmdModelo.ExecuteNonQuery();
                }
            }
        }
        private void Grid_Modelo()
            {
            Grid_View("SELECT tb_modelo.id_modelo, tb_modelo.nm_modelo, tb_fabricante.nm_fabricante FROM tb_modelo JOIN tb_fabricante ON tb_modelo.id_fabricante = tb_fabricante.id_fabricante;", Grid_03);
        }

            private void Grid_View(string query, DataGridView dataGridView)
            {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB"; ;
            DataTable dt = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    connection.Open();
                    adapter.Fill(dt);
                }

                Grid_03.DataSource = dt;
            }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frm_Modelo_Load(object sender, EventArgs e)
        {
            
            Grid_Modelo();
            Carregar_Fabricantes();


           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Cliente outroForm = new frm_Cliente();

            this.Visible = false;

            outroForm.ShowDialog();
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
        
        

        private void gbtn_inserir_Click(object sender, EventArgs e)
        {
            string nome_fabricante = gcbbox_Fabricantes.Text;
            string nome_modelo = gtxt_Modelos.Text;

            if (String.IsNullOrWhiteSpace(nome_modelo))
            {
                MessageBox.Show("O campo 'Modelo' é de preenchimento obrigatório!");
            }
            else
            {
                Inserir_Fabri_Model(nome_fabricante, nome_modelo);


                Grid_Modelo();
            }
        }
    }
}


    

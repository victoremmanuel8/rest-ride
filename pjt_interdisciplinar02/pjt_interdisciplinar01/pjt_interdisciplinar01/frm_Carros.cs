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
    public partial class frm_Carros : Form
    {
        public frm_Carros()
        {
            InitializeComponent();
        }
        private void cbbox_fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Armazenar a placa do carro selecionado
            DateCarro.Placa_Carro = cbbox_fabricante.Text;
        }

        private void cbbox_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Armazenar a placa do carro selecionado
            DateCarro.Placa_Carro = cbbox_modelo.Text;
        }
        private void CarregarFabricantes()
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

                    cbbox_fabricante.DataSource = dt;
                    cbbox_fabricante.DisplayMember = "nm_fabricante";
                    cbbox_fabricante.ValueMember = "id_fabricante";
                }
            }
        }

        private void CarregarModelos()
        {
            string connectionString = "datasource=localhost;username=root;password= root;database=BancoCar_DB";

            string query = "SELECT id_modelo, nm_modelo FROM tb_modelo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cbbox_modelo.DataSource = dt;
                    cbbox_modelo.DisplayMember = "nm_modelo";
                    cbbox_modelo.ValueMember = "id_modelo";
                }
            }
        }

        private void Inserir_Carros(string id_carro, string nr_placa, string nr_chassi, string ano_fabricacao, string nome_modelo, string nome_fabricante)
        {
            string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Aqui é onde você obtém o ID do modelo
                string queryObterIdModelo = "SELECT id_modelo FROM tb_modelo WHERE nm_modelo = @nome_modelo LIMIT 1";
                MySqlCommand cmdObterIdModelo = new MySqlCommand(queryObterIdModelo, connection);
                cmdObterIdModelo.Parameters.AddWithValue("@nome_modelo", nome_modelo);
                int idModelo = Convert.ToInt32(cmdObterIdModelo.ExecuteScalar());

                string queryCarro = "INSERT INTO tb_carros (id_carro, nr_placa, nr_chassi, ano_fabricacao, id_modelo, id_fabricante) VALUES (@id_carro, @nr_placa, @nr_chassi, @ano_fabricacao, @id_modelo, (SELECT id_fabricante FROM tb_fabricante WHERE nm_fabricante = @nome_fabricante LIMIT 1));";
                using (MySqlCommand cmdCarro = new MySqlCommand(queryCarro, connection))
                {
                    cmdCarro.Parameters.AddWithValue("@id_carro", id_carro);
                    cmdCarro.Parameters.AddWithValue("@nr_placa", nr_placa);
                    cmdCarro.Parameters.AddWithValue("@nr_chassi", nr_chassi);
                    cmdCarro.Parameters.AddWithValue("@ano_fabricacao", ano_fabricacao);
                    cmdCarro.Parameters.AddWithValue("@id_modelo", idModelo); // Aqui é onde você usa o ID do modelo
                    cmdCarro.Parameters.AddWithValue("@nome_fabricante", nome_fabricante);
                    cmdCarro.ExecuteNonQuery();
                }
            }
        }
        private void Grid_Carros()
        {
            Grid_View("SELECT car.id_carro, mo.nm_modelo, fabri.nm_fabricante, car.nr_placa, car.nr_chassi, car.ano_fabricacao AS ano " +
                   "FROM tb_carros car " +
                   "INNER JOIN tb_modelo mo ON car.id_modelo = mo.id_modelo " +
                   "INNER JOIN tb_fabricante fabri ON mo.id_fabricante = fabri.id_fabricante", Grid_04);
        }

        private void Grid_View(string query, DataGridView dataGridView)
        {
            string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                connection.Open();
                adapter.Fill(dt);
            }

            Grid_04.DataSource = dt;
        }


        private void frm_Carros_Load(object sender, EventArgs e)
        {
            Grid_Carros();
            CarregarFabricantes();
            CarregarModelos();
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

        private void cbbox_fabricante_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbbox_modelo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gbtn_inserir_Click(object sender, EventArgs e)
        {
            string id_carro = "0";
            string nome_fabricante = gcbbox_fabricante.Text;
            string nome_modelo = gcbbox_modelo.Text;
            string nr_placa = gtxt_placa.Text;
            string nr_chassi = gtxt_chassis.Text;
            string ano_fabricacao = gtxt_ano.Text;

            if (String.IsNullOrWhiteSpace(nome_fabricante))
            {
                MessageBox.Show("O campo 'Fabricante' é de preenchimento obrigatório!");
            }

            else if (String.IsNullOrWhiteSpace(nome_modelo))
            {
                MessageBox.Show("O campo 'Modelo' é de preenchimento obrigatório!");
            }

            else if (String.IsNullOrWhiteSpace(nr_placa))
            {
                MessageBox.Show("O campo 'Placa' é de preenchimento obrigatório!");
            }
            else if (String.IsNullOrWhiteSpace(nr_chassi))
            {
                MessageBox.Show("O campo 'Chassi' é de preenchimento obrigatório!");
            }
            else if (String.IsNullOrWhiteSpace(ano_fabricacao))
            {
                MessageBox.Show("O campo 'Fabricacao' é de preenchimento obrigatório!");
            }


            else
            {
                Inserir_Carros(id_carro, nr_placa, nr_chassi, ano_fabricacao, nome_modelo, nome_fabricante);
                Grid_Carros();
            }
        }
    }
}



  



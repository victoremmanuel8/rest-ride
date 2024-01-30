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
    public partial class frm_Aluguel : Form
    {
        private MySqlConnection Conexao;
        string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";

        public frm_Aluguel()
        {
            InitializeComponent();
        }

        private void Carregar_Carros()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nm_modelo FROM tb_modelo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gcbbox_carros.Items.Add(reader.GetString("nm_modelo"));
                }
            }
        }

        private void Carregar_Cliente()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nm_cliente FROM tb_clientes";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gcbbox_nome.Items.Add(reader.GetString("nm_cliente"));
                }
            }
        }

        private void Inserir_Locacao(string id_locacao, int id_carro, string nm_cliente, string nm_modelo, string dtInicio, string dtFim)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Aqui é necessário obter o ID do modelo com base no nome do modelo
                string queryObterIdModelo = "SELECT id_modelo FROM tb_modelo WHERE nm_modelo = @nm_modelo";
                MySqlCommand cmdIdModelo = new MySqlCommand(queryObterIdModelo, connection);
                cmdIdModelo.Parameters.AddWithValue("@nm_modelo", nm_modelo);
                int idModelo = Convert.ToInt32(cmdIdModelo.ExecuteScalar());



                // Agora, insere na tabela de locações usando o ID do modelo
                string query = "INSERT INTO tb_locacoes (id_locacao, id_cliente, id_carro, dt_inicio, dt_fim) " +
                               "VALUES (@id_locacao, (SELECT id_cliente FROM tb_clientes WHERE nm_cliente = @nm_cliente), @id_modelo, @dt_inicio, @dt_fim)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id_locacao", id_locacao);
                cmd.Parameters.AddWithValue("@nm_cliente", nm_cliente);
                cmd.Parameters.AddWithValue("@id_modelo", idModelo);
                cmd.Parameters.AddWithValue("@dt_inicio", dtInicio);
                cmd.Parameters.AddWithValue("@dt_fim", dtFim);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Locação registrada com sucesso!");
                Carregar_Locacoes();
            }
        }


        private void Carregar_Locacoes()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT loc.id_locacao, cli.nm_cliente AS Nome, mo.nm_modelo AS Modelo, car.ano_fabricacao, loc.dt_inicio AS Inicio, loc.dt_fim AS Fim " +
                                    "FROM tb_locacoes loc " +
                                    "JOIN tb_clientes cli ON loc.id_cliente = cli.id_cliente " +
                                    "JOIN tb_carros car ON loc.id_carro = car.id_carro " +
                                    "JOIN tb_modelo mo ON car.id_modelo = mo.id_modelo " +
                                    "ORDER BY loc.id_locacao ";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Grid_06.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar locações: {ex.Message}");
            }
        }
        


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string id_locacao = "0";
            string nm_cliente = gcbbox_nome.Text;
            string nm_modelo = gcbbox_carros.Text;
            string dtInicio = gtxt_inicio.Text;
            string dtFim = gtxt_fim.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar se já existe uma locação para o cliente e carro selecionados
                string queryVerificarLocacao = "SELECT COUNT(*) FROM tb_locacoes loc " +
                                               "JOIN tb_clientes cli ON loc.id_cliente = cli.id_cliente " +
                                               "JOIN tb_carros car ON loc.id_carro = car.id_carro " +
                                               "JOIN tb_modelo mo ON car.id_modelo = mo.id_modelo " +
                                               "WHERE loc.dt_inicio = @dt_inicio AND loc.dt_fim = @dt_fim";
                MySqlCommand cmdVerificarLocacao = new MySqlCommand(queryVerificarLocacao, connection);


                cmdVerificarLocacao.Parameters.AddWithValue("@dt_inicio", dtInicio);
                cmdVerificarLocacao.Parameters.AddWithValue("@dt_fim", dtFim);


                int locacoesExistentes = Convert.ToInt32(cmdVerificarLocacao.ExecuteScalar());

                if (locacoesExistentes > 0)
                {
                    MessageBox.Show("Já existe uma locação para este veiculo com prazo.");
                }
                else
                {
                    string queryObterIdCarro = "SELECT id_carro FROM tb_carros c JOIN tb_modelo m ON c.id_modelo = m.id_modelo WHERE m.nm_modelo = @nm_modelo";
                    MySqlCommand cmdIdCarro = new MySqlCommand(queryObterIdCarro, connection);
                    cmdIdCarro.Parameters.AddWithValue("@nm_modelo", nm_modelo);
                    int id_carro = Convert.ToInt32(cmdIdCarro.ExecuteScalar());

                    Inserir_Locacao(id_locacao, id_carro, nm_cliente, nm_modelo, dtInicio, dtFim);
                    Carregar_Locacoes();
                }
            }
        }
        private void frm_Aluguel_Load(object sender, EventArgs e)
        {
            Carregar_Cliente();
            Carregar_Carros();
            Carregar_Locacoes();

        }

        private void btn_devolucao_Click(object sender, EventArgs e)
        {
            if (Grid_06.SelectedRows.Count > 0)
            {
                frm_Devolucao frmDevolucao = new frm_Devolucao();

                // Passe as informações da locação para o formulário de devolução
                frmDevolucao.id_locacao = Convert.ToInt32(Grid_06.SelectedRows[0].Cells["id_locacao"].Value);
                frmDevolucao.nm_cliente = Grid_06.SelectedRows[0].Cells["Nome"].Value.ToString();
                frmDevolucao.modelo_carro = Grid_06.SelectedRows[0].Cells["Modelo"].Value.ToString();
                frmDevolucao.dt_inicio = Grid_06.SelectedRows[0].Cells["Inicio"].Value.ToString();
                frmDevolucao.dt_fim = Grid_06.SelectedRows[0].Cells["Fim"].Value.ToString();

                frmDevolucao.ShowDialog();


                int selectedIndex = Grid_06.SelectedRows[0].Index;
                //Remover a linha da Grid
                Grid_06.Rows.RemoveAt(selectedIndex);

                Grid_06.Refresh();

                Excluir(Convert.ToInt32(frmDevolucao.id_locacao));

            }
            else
            {
                MessageBox.Show("Selecione uma locação para devolução.");
            }
        }

        private void Excluir(int id_locacao)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Exluir a locacao
                string query = "DELETE FROM tb_locacoes where id_locacao = @id_locacao";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_locacao", id_locacao);

                cmd.ExecuteNonQuery();
            }

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

        private void gbtn_inserir_Click(object sender, EventArgs e)
        {
            string id_locacao = "0";
            string nm_cliente = gcbbox_nome.Text;
            string nm_modelo = gcbbox_carros.Text;
            string dtInicio = gtxt_inicio.Text;
            string dtFim = gtxt_fim.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar se já existe uma locação para o cliente e carro selecionados
                string queryVerificarLocacao = "SELECT COUNT(*) FROM tb_locacoes loc " +
                                               "JOIN tb_clientes cli ON loc.id_cliente = cli.id_cliente " +
                                               "JOIN tb_carros car ON loc.id_carro = car.id_carro " +
                                               "JOIN tb_modelo mo ON car.id_modelo = mo.id_modelo " +
                                               "WHERE loc.dt_inicio = @dt_inicio AND loc.dt_fim = @dt_fim";
                MySqlCommand cmdVerificarLocacao = new MySqlCommand(queryVerificarLocacao, connection);


                cmdVerificarLocacao.Parameters.AddWithValue("@dt_inicio", dtInicio);
                cmdVerificarLocacao.Parameters.AddWithValue("@dt_fim", dtFim);


                int locacoesExistentes = Convert.ToInt32(cmdVerificarLocacao.ExecuteScalar());

                if (locacoesExistentes > 0)
                {
                    MessageBox.Show("Já existe uma locação para este veiculo com prazo.");
                }
                else
                {
                    string queryObterIdCarro = "SELECT id_carro FROM tb_carros c JOIN tb_modelo m ON c.id_modelo = m.id_modelo WHERE m.nm_modelo = @nm_modelo";
                    MySqlCommand cmdIdCarro = new MySqlCommand(queryObterIdCarro, connection);
                    cmdIdCarro.Parameters.AddWithValue("@nm_modelo", nm_modelo);
                    int id_carro = Convert.ToInt32(cmdIdCarro.ExecuteScalar());

                    Inserir_Locacao(id_locacao, id_carro, nm_cliente, nm_modelo, dtInicio, dtFim);
                    Carregar_Locacoes();
                }
            }
        }

        private void gbtn_devolucao_Click(object sender, EventArgs e)
        {
            if (Grid_06.SelectedRows.Count > 0)
            {
                frm_Devolucao frmDevolucao = new frm_Devolucao();

                // Passe as informações da locação para o formulário de devolução
                frmDevolucao.id_locacao = Convert.ToInt32(Grid_06.SelectedRows[0].Cells["id_locacao"].Value);
                frmDevolucao.nm_cliente = Grid_06.SelectedRows[0].Cells["Nome"].Value.ToString();
                frmDevolucao.modelo_carro = Grid_06.SelectedRows[0].Cells["Modelo"].Value.ToString();
                frmDevolucao.dt_inicio = Grid_06.SelectedRows[0].Cells["Inicio"].Value.ToString();
                frmDevolucao.dt_fim = Grid_06.SelectedRows[0].Cells["Fim"].Value.ToString();

                frmDevolucao.ShowDialog();


                int selectedIndex = Grid_06.SelectedRows[0].Index;
                //Remover a linha da Grid
                Grid_06.Rows.RemoveAt(selectedIndex);

                Grid_06.Refresh();

                Excluir(Convert.ToInt32(frmDevolucao.id_locacao));

            }
            else
            {
                MessageBox.Show("Selecione uma locação para devolução.");
            }
        }
    }
}
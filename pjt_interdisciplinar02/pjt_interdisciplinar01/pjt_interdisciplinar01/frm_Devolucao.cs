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
    public partial class frm_Devolucao : Form
    {
        public int id_locacao { get; set; }
        public string nm_cliente { get; set; }
        public string modelo_carro { get; set; }
        public string dt_inicio { get; set; }
        public string dt_fim { get; set; }

        private MySqlConnection Conexao;
        string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";
        private DataTable dt_devolucoes;

        public frm_Devolucao()
        {
            InitializeComponent();
        }

        private void Carregar_Devolucoes()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT d.id_devolucao, c.nm_cliente, mo.nm_modelo, d.data_devolucao, d.valor_total " +
                                    "FROM tb_devolucoes d " +
                                    "JOIN tb_locacoes l ON d.id_locacao = l.id_locacao " +
                                    "JOIN tb_clientes c ON l.id_cliente = c.id_cliente " +
                                    "JOIN tb_carros car ON l.id_carro = car.id_carro " +
                                    "JOIN tb_modelo mo ON car.id_modelo = mo.id_modelo " +
                                    "WHERE d.id_locacao = @id_locacao"; // Adicionado o filtro

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_locacao", id_locacao);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    dt_devolucoes = new DataTable();
                    da.Fill(dt_devolucoes);

                    Grid_07.DataSource = dt_devolucoes;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar devoluções: " + ex.Message);
            }
        }

        private void Processar_Devolucao()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    DateTime dt_devolucao = DateTime.Now;


                    decimal vl_aluguel = Calcular_Aluguel();


                    string queryInserirDevolucao = "INSERT INTO tb_devolucoes (id_locacao, data_devolucao, valor_total) " +
                                                   "VALUES (@id_locacao, @data_devolucao, @valor_aluguel)";
                    MySqlCommand cmdInserirDevolucao = new MySqlCommand(queryInserirDevolucao, connection);

                    cmdInserirDevolucao.Parameters.AddWithValue("@id_locacao", id_locacao);
                    cmdInserirDevolucao.Parameters.AddWithValue("@data_devolucao", dt_devolucao);
                    cmdInserirDevolucao.Parameters.AddWithValue("@valor_aluguel", vl_aluguel);

                    cmdInserirDevolucao.ExecuteNonQuery();

                    MessageBox.Show("Devolução processada com sucesso!");


                    Carregar_Devolucoes();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar devolução: " + ex.Message);
            }
        }
        private decimal Calcular_Aluguel()
        {


            DateTime dt_inic = DateTime.Parse(dt_inicio);
            DateTime dt_fiminic = DateTime.Parse(dt_fim);
            int dias_alugados = (int)(dt_fiminic - dt_inic).TotalDays;

            decimal taxa_diaria = 50.00m;

            decimal vl_aluguel = dias_alugados * taxa_diaria;

            return vl_aluguel;
        }

        private void btn_Devolver_Click(object sender, EventArgs e)
        {
            Processar_Devolucao();
        }

        private void frm_Devolucao_Load(object sender, EventArgs e)
        {
            gtxt_cliente.Text = "Cliente: " + nm_cliente;
            gtxt_modelo.Text = "Modelo do Carro: " + modelo_carro;
            gtxt_inicio.Text = "Data Início: " + dt_inicio;
            gtxt_fim.Text = "Data Fim: " + dt_fim;
            gtxt_custo.Text = "Custo do Aluguel: R$ " + Calcular_Aluguel().ToString("0.00");

            // Carregar as devoluções
            Carregar_Devolucoes();

            // Adicionar uma nova linha à DataTable com os dados das TextBoxes
            DataRow newRow = dt_devolucoes.NewRow();
            newRow["nm_cliente"] = nm_cliente;
            newRow["nm_modelo"] = modelo_carro;
            newRow["data_devolucao"] = DateTime.Now;  // Adapte conforme necessário
            newRow["valor_total"] = Calcular_Aluguel();

            dt_devolucoes.Rows.Add(newRow);

            // Atualizar a origem de dados da DataGridView
            Grid_07.DataSource = dt_devolucoes;
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
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

    public partial class frm_Cliente : Form
    {
        private MySqlConnection Conexao;
        string connectionString = "datasource = localhost; username = root; password = root; database = BancoCar_DB";

       
        public frm_Cliente()
        {
            InitializeComponent();
        }

        private void Inserir_Cliente(string id_cliente, string nm_cliente, string nr_cnh, string cpf, string rg, string endereco, string NR, string sigla_estado, string nm_cidade)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Aqui é necessário obter o ID do estado com base na sigla do estado
                    string queryObterIdEstado = "SELECT id_estado FROM tb_estado WHERE sigla_estado = @sigla_estado";
                    MySqlCommand cmdIdEstado = new MySqlCommand(queryObterIdEstado, connection);
                    cmdIdEstado.Parameters.AddWithValue("@sigla_estado", sigla_estado);
                    int idEstado = Convert.ToInt32(cmdIdEstado.ExecuteScalar());

                    // Agora, obter o ID da cidade com base no nome da cidade e no ID do estado
                    string queryObterIdCidade = "SELECT id_cidade FROM tb_cidade WHERE nm_cidade = @nm_cidade AND id_estado = @id_estado";
                    MySqlCommand cmdIdCidade = new MySqlCommand(queryObterIdCidade, connection);
                    cmdIdCidade.Parameters.AddWithValue("@nm_cidade", nm_cidade);
                    cmdIdCidade.Parameters.AddWithValue("@id_estado", idEstado);
                    int idCidade = Convert.ToInt32(cmdIdCidade.ExecuteScalar());

                    // Inserir os dados do cliente
                    string queryCliente = "INSERT INTO tb_clientes (id_cliente, nm_cliente, nr_cnh, cpf, rg, endereco, NR, id_cidade) " +
                                          "VALUES (@id_cliente, @nome_cliente, @numero_cnh, @cpf, @rg, @endereco, @NR, @id_cidade)";
                    using (MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection))
                    {
                        cmdCliente.Parameters.AddWithValue("@id_cliente", id_cliente);
                        cmdCliente.Parameters.AddWithValue("@nome_cliente", nm_cliente);
                        cmdCliente.Parameters.AddWithValue("@numero_cnh", nr_cnh);
                        cmdCliente.Parameters.AddWithValue("@cpf", cpf);
                        cmdCliente.Parameters.AddWithValue("@rg", rg);
                        cmdCliente.Parameters.AddWithValue("@endereco", endereco);
                        cmdCliente.Parameters.AddWithValue("@NR", NR);
                        cmdCliente.Parameters.AddWithValue("@id_cidade", idCidade);
                        cmdCliente.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
            }
        }
        
        private void CarregarDadosGrid()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT cli.id_cliente, cli.nm_cliente, cli.nr_cnh, cli.cpf, cli.rg, cli.endereco, cli.NR, cid.nm_cidade, est.sigla_estado " +
                                 "FROM tb_clientes cli " +
                                 "JOIN tb_cidade cid ON cli.id_cidade = cid.id_cidade " +
                                 "JOIN tb_estado est ON cid.id_estado = est.id_estado " +
                                 "ORDER BY id_cliente";

                    MySqlCommand comando = new MySqlCommand(sql, connection);
                    comando.CommandType = CommandType.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(comando);

                    DataTable componentes = new DataTable();

                    da.Fill(componentes);

                    Grid_05.DataSource = componentes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void Carregar_Cidades(string sigla_estado)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT nm_cidade FROM tb_cidade " +
                                 "WHERE id_estado = (SELECT id_estado FROM tb_estado WHERE sigla_estado = @sigla_estado) " +
                                 "ORDER BY nm_cidade";

                    MySqlCommand comando = new MySqlCommand(sql, connection);
                    comando.Parameters.AddWithValue("@sigla_estado", sigla_estado);

                    MySqlDataReader reader = comando.ExecuteReader();

                    gcbbox_cidade.Items.Clear();

                    while (reader.Read())
                    {
                        gcbbox_cidade.Items.Add(reader.GetString("nm_cidade"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cidades: " + ex.Message);
            }
        }
        private void Carregar_Estado()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT sigla_estado FROM tb_estado ORDER BY sigla_estado";

                    MySqlCommand comando = new MySqlCommand(sql, connection);

                    MySqlDataReader reader = comando.ExecuteReader();

                    gcbbox_uf.Items.Clear();

                    while (reader.Read())
                    {
                        gcbbox_uf.Items.Add(reader.GetString("sigla_estado"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cidades: " + ex.Message);
            }
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            Carregar_Cidades(gcbbox_uf.Text);
            Carregar_Estado();
            CarregarDadosGrid();
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

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_habilitacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void gcbbox_uf_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sigla_estado = gcbbox_uf.Text;
            Carregar_Cidades(sigla_estado);
        }

        private void cbbox_uf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbtn_inserir_Click(object sender, EventArgs e)
        {
            string id_cliente = "0";
            string nome_cliente = txt_nome.Text;
            string nr_cnh = txt_habilitacao.Text;
            string cpf = txt_cpf.Text;
            string rg = txt_rg.Text;
            string endereco = txt_endereco.Text;
            string NR = txt_numero.Text;
            string id_cidade = gcbbox_cidade.Text; //exclusão, talves

            string sigla_estado = gcbbox_uf.Text;
            string nm_cidade = gcbbox_cidade.Text;


            if (String.IsNullOrWhiteSpace(nome_cliente))
            {
                MessageBox.Show("O campo 'Cliente' é de preenchimento obrigatório!");
                return;
            }

            if (String.IsNullOrWhiteSpace(nr_cnh))
            {
                MessageBox.Show("O campo 'CNH' é de preenchimento obrigatório!");
                return;
            }

            if (String.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("O campo 'CPF' é de preenchimento obrigatório!");
                return;
            }

            if (String.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("O campo 'Endereco' é de preenchimento obrigatório!");
                return;
            }

            if (String.IsNullOrWhiteSpace(NR))
            {
                MessageBox.Show("O campo 'Numero' é de preenchimento obrigatório!");
                return;
            }

            Inserir_Cliente(id_cliente, nome_cliente, nr_cnh, cpf, rg, endereco, NR, sigla_estado, nm_cidade);
            CarregarDadosGrid();
            Grid_05.Refresh();
        }
    }
}
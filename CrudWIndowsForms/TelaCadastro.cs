using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWIndowsForms;


namespace CrudWIndowsForms
{


    public partial class TelaCadastro : Form
    {
        //    private bool novo;
        //    private string connectionString;
        //    private object txtBairro;
        //    private object txtCidade;

        //    public object CIDADE { get; private set; }
        //    public object BAIRRO { get; private set; }
        //    public object CEP { get; private set; }
        //    public object ENDERECO { get; private set; }
        //    public object NOME { get; private set; }
        //    public object UF { get; private set; }
        //    public object TELEFONE { get; private set; }

        string connectionString = @"Server=DESKTOP-JIFS59M\SQLEXPRESS;Database=Crud;Trusted_Connection=True;";
        bool novo;


        public TelaCadastro()
        {

            InitializeComponent();


        }

        private void TelaCadastroLoad(object sender, EventArgs e)
        {

        }







        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

            Novo.Enabled = true;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = false;
            textID.Enabled = true;
            Pesquisar.Enabled = true;
            textNome.Enabled = false;
            textEndereco.Enabled = false;
            textCEP.Enabled = false;
            textBairro.Enabled = false;
            textCidade.Enabled = false;
            textUF.Enabled = false;
            textTelefone.Enabled = false;

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            Novo.Enabled = false;
            Salvar.Enabled = true;
            Cancelar.Enabled = true;
            Excluir.Enabled = false;
            textID.Enabled = false;
            Pesquisar.Enabled = false;
            textNome.Enabled = true;
            textEndereco.Enabled = true;
            textCEP.Enabled = true;
            textBairro.Enabled = true;
            textCidade.Enabled = true;
            textUF.Enabled = true;
            textTelefone.Enabled = true;
            textNome.Focus();
            novo = true;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO CLIENTE (NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) " + "VALUES ('" + textNome.Text + "', '" + textEndereco.Text + "', '" + textCEP.Text + "', '" + textBairro.Text + "', '" + textCidade.Text + "', '" + textUF.Text + "', '" + textTelefone.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME='" + textNome.Text + "', ENDERECO = '" + textEndereco.Text + "' " + "CEP='" + textCEP.Text + "', BAIRRO='" + textBairro.Text + "',CIDADE = '" + textCidade.Text + "', " + "UF='" + textUF.Text + "', TELEFONE='" + textTelefone.Text + "' WHERE ID=" + textID.Text;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            Novo.Enabled = true;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = false;
            ID.Enabled = true;
            Pesquisar.Enabled = true;
            textNome.Enabled = false;
            textEndereco.Enabled = false;
            textCEP.Enabled = false;
            textBairro.Enabled = false;
            textCidade.Enabled = false;
            textUF.Enabled = false;
            textTelefone.Enabled = false;
            textID.Text = "";
            textNome.Text = "";
            textEndereco.Text = "";
            textCEP.Text = "";
            textBairro.Text = "";
            textCidade.Text = "";
            textUF.Text = "";
            textTelefone.Text = "";
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CLIENTE WHERE ID=" + textID.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            Novo.Enabled = true;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = false;
            txtID.Enabled = true;
            Pesquisar.Enabled = true;
            textNome.Enabled = false;
            textEndereco.Enabled = false;
            textCEP.Enabled = false;
            textBairro.Enabled = false;
            textCidade.Enabled = false;
            textUF.Enabled = false;
            textTelefone.Enabled = false;
            txtID.Text = "";
            textNome.Text = "";
            textEndereco.Text = "";
            textCEP.Text = "";
            textBairro.Text = "";
            textCidade.Text = "";
            textUF.Text = "";
            textTelefone.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Novo.Enabled = true;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = false;
            txtID.Enabled = true;
            Pesquisar.Enabled = true;
            textNome.Enabled = false;
            textEndereco.Enabled = false;
            textCEP.Enabled = false;
            textBairro.Enabled = false;
            textCidade.Enabled = false;
            textUF.Enabled = false;
            textTelefone.Enabled = false;
            txtID.Text = "";
            textNome.Text = "";
            textEndereco.Text = "";
            textCEP.Text = "";
            textBairro.Text = "";
            textCidade.Text = "";
            textUF.Text = "";
            textTelefone.Text = "";


        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID=" + txtID.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Novo.Enabled = false;
                    Salvar.Enabled = true;
                    Cancelar.Enabled = true;
                    Excluir.Enabled = true;
                    txtID.Enabled = false;
                    Pesquisar.Enabled = false;
                    textNome.Enabled = true;
                    textEndereco.Enabled = true;
                    textCEP.Enabled = true;
                    textBairro.Enabled = true;
                    textCidade.Enabled = true;
                    textUF.Enabled = true;
                    textTelefone.Enabled = true;
                    textNome.Focus();
                    txtID.Text = reader[0].ToString();
                    textNome.Text = reader[1].ToString();
                    textEndereco.Text = reader[2].ToString();
                    textCEP.Text = reader[3].ToString();
                    textBairro.Text = reader[4].ToString();
                    textCidade.Text = reader[5].ToString();
                    textUF.Text = reader[6].ToString();
                    textTelefone.Text = reader[7].ToString();
                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o Id informado!");
       
     }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            txtID.Text = "";
         
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



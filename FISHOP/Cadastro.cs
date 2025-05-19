using FISHOP;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_GestaodeProdutos
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = TxtNomeUsuario.Text.Trim();
                string cpf = TxtCpfCadastro.Text.Trim().Replace(".", "").Replace("-", "");
                string email = TxtEmailUsuario.Text.Trim();
                string login = TxtUserUsuario.Text.Trim();
                string senha = txtSenhaUsuario.Text.Trim();

                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(cpf) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(login) ||
                    string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Favor preencher corretamente os campos!", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Valida formato de CPF (11 dígitos)
                if (!new Usuarios().ValidarCPF(cpf))
                {
                    MessageBox.Show("Esse CPF não é válido!", "Aviso - Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conecta ao banco e checa se já existe login, e-mail ou CPF
                using (var conn = new ConexaoBD().Conectar())
                {
                    string sqlCheck = @"
                        SELECT COUNT(*)
                        FROM usuarios
                        WHERE usuario = @login
                           OR email = @email
                           OR cpf = @cpf;
                    ";
                    using (var cmdCheck = new MySqlCommand(sqlCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@login", login);
                        cmdCheck.Parameters.AddWithValue("@email", email);
                        cmdCheck.Parameters.AddWithValue("@cpf", cpf);

                        long count = (long)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Esse usuário já está cadastrado!", "Aviso - Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Se não existe, insere no banco
                    string hashSenha = Usuarios.GerarSha256(senha);
                    string sqlInsert = @"
                        INSERT INTO usuarios
                            (nome, cpf, email, usuario, senha)
                        VALUES
                            (@nome, @cpf, @email, @login, @hashSenha);
                    ";
                    using (var cmdInsert = new MySqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@nome", nome);
                        cmdInsert.Parameters.AddWithValue("@cpf", cpf);
                        cmdInsert.Parameters.AddWithValue("@email", email);
                        cmdInsert.Parameters.AddWithValue("@login", login);
                        cmdInsert.Parameters.AddWithValue("@hashSenha", hashSenha);

                        int rows = cmdInsert.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show($"Cadastro feito com sucesso! {login} cadastrado.", "Sucesso - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();

                            LoginPrincipal FormLogin = new LoginPrincipal();
                            FormLogin.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar no momento.", "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparCampos()
        {
            txtSenhaUsuario.Clear();
            TxtCpfCadastro.Clear();
            TxtEmailUsuario.Clear();
            TxtNomeUsuario.Clear();
            TxtUserUsuario.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginPrincipal FormLogin = new LoginPrincipal();
            FormLogin.Show();
            this.Close();
        }

        private void btnFecharCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarCad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using Atividade_GestaodeProdutos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class Form1 : Form
    {
        private readonly int usuarioId;

        public Form1(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
        }

        private void input_btn_Click(object sender, EventArgs e)
        {
            flowProdutos.Controls.Clear();

            if (!string.IsNullOrWhiteSpace(input_txt.Text))
            {
                List<Item> produtos = GeradorProduto.GerarProdutos(input_txt.Text.Trim());

                if (produtos != null && produtos.Count > 0)
                {
                    foreach (var item in produtos)
                    {
                        // Cria o ProdutoCard passando o nome do usuário
                        ProdutoCard card = new ProdutoCard(usuarioId);
                        card.SetProduto(item);
                        flowProdutos.Controls.Add(card);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void input_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se quiser, trate Enter para disparar pesquisa
            if (e.KeyChar == (char)Keys.Enter)
            {
                input_btn_Click(this, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização extra se necessário
        }

        private void carrinho_btn_Click(object sender, EventArgs e)
        {
            Carrinho carrinhoForm = new Carrinho(usuarioId);
            carrinhoForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class Carrinho : Form
    {
        private readonly int usuarioId;
        private decimal taxaEntrega = 0;

        public Carrinho(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            AtualizarCarrinho();
            PopularEnderecos();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AtualizarCarrinho()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Item> produtos = CarrinhoService.ObterProdutos(usuarioId);

            if (produtos.Count == 0)
            {
                total_lbl.Text = "Total: R$ 0,00";
            }
            else
            {
                foreach (var item in produtos)
                {
                    CarrinhoCard card = new CarrinhoCard
                    {
                        Titulo = item.Title,
                        Preco = "R$ " + item.ValorNumerico.ToString("F2").Replace('.', ','),
                        Loja = item.Source,
                        Estrelas = item.Rating,
                        ImagemUrl = item.ImageUrl,
                        Produto = item,
                        Quantidade = item.Quantidade > 0 ? item.Quantidade : 1,
                        UsuarioId = usuarioId
                    };

                    card.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(card);
                }

                AtualizarTotal();
            }
        }

        public void AtualizarTotal()
        {
            decimal subtotal = 0;

            foreach (CarrinhoCard card in flowLayoutPanel1.Controls.OfType<CarrinhoCard>())
            {
                decimal valorUnitario = card.Produto?.ValorNumerico ?? 0;
                int quantidade = card.Quantidade;
                subtotal += valorUnitario * quantidade;
            }

            decimal total = subtotal + taxaEntrega;

            subtotal_lbl.Text = "Subtotal: R$ " + subtotal.ToString("F2").Replace('.', ',');
            taxa_lbl.Text = "Taxa de entrega: R$ " + taxaEntrega.ToString("F2").Replace('.', ',');
            total_lbl.Text = "Total: R$ " + total.ToString("F2").Replace('.', ',');
        }

        public void PopularEnderecos()
        {
            endereco_flow.Controls.Clear();
            List<Endereco> enderecos = EnderecoService.ObterEnderecos(usuarioId);

            if (enderecos.Count == 0)
            {
                endereco_panel.Visible = true;
            }
            else
            {
                endereco_panel.Visible = false;

                foreach (var e in enderecos)
                {
                    var card = new EnderecoCard
                    {
                        EnderecoId = e.Id,
                        UsuarioId = usuarioId,
                        Rua = e.Rua,
                        Numero = e.Numero,
                        Bairro = e.Bairro,
                        Cidade = e.Cidade,
                        Usuario = "",
                        Width = endereco_flow.ClientSize.Width - 25,
                        Margin = new Padding(3, 3, 3, 10)
                    };

                    card.EnderecoSelecionado += EnderecoSelecionadoHandler;
                    endereco_flow.Controls.Add(card);
                }

                var addEnderecoLabel = new Label()
                {
                    Text = "Adicionar novo endereço",
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    Cursor = Cursors.Hand,
                    Font = new Font("Segoe UI", 10, FontStyle.Underline),
                    Dock = DockStyle.Top,
                    Height = 30,
                };

                addEnderecoLabel.Click += (s, e) =>
                {
                    var cadastro = new EnderecoCadastro(usuarioId, this);
                    cadastro.ShowDialog();
                };

                endereco_flow.Controls.Add(addEnderecoLabel);
            }
        }

        private void EnderecoSelecionadoHandler(object sender, EventArgs e)
        {
            foreach (var control in endereco_flow.Controls)
            {
                if (control is EnderecoCard card && card != sender)
                {
                    card.Desmarcar();
                }
            }

            Random rnd = new Random();
            taxaEntrega = rnd.Next(5, 26);

            taxa_lbl.Text = "Taxa de entrega: R$ " + taxaEntrega.ToString("F2").Replace('.', ',');

            AtualizarTotal();
        }

        private void cadastro_endereco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new EnderecoCadastro(usuarioId, this);
            cadastro.ShowDialog();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class Carrinho : Form
    {
        public Carrinho()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            try
            {

                if (CarrinhoService.ProdutosNoCarrinho.Count == 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    Label label = new Label
                    {
                        Text = "Seu carrinho está vazio",
                        AutoSize = true,
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        Location = new Point(50, 50)
                    };
                    flowLayoutPanel1.Controls.Add(label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o carrinho: " + ex.Message);
                flowLayoutPanel1.Controls.Clear();

            foreach (Item p in CarrinhoService.ProdutosNoCarrinho)
            {
                CarrinhoCard card = new CarrinhoCard
                {
                    Titulo = p.Title,
                    Preco = p.Price,
                    Loja = p.Source,
                    Estrelas = p.Rating,
                    ImagemUrl = p.ImageUrl
                };

                    card.Dock = DockStyle.Top;

                    Console.WriteLine("Adicionando produto ao carrinho: " + p.Title);

                    flowLayoutPanel1.Controls.Add(card);
            }
        }
        
    }
}}


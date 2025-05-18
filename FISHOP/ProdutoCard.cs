using System;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace FISHOP
{
    public partial class ProdutoCard : UserControl
    {
        private Item produtoAtual;

        public ProdutoCard()
        {
            InitializeComponent();
        }

        public void SetProduto(Item item)
        {
            produtoAtual = item;

            // Quantidade inicial padrão (supondo que Quantidade existe em Item)
            if (produtoAtual.Quantidade == 0)
                produtoAtual.Quantidade = 1;

            Titulo = item.Title;
            Preco = "R$ " + produtoAtual.ValorNumerico.ToString("F2").Replace('.', ',');
            Loja = item.Source;
            Estrelas = item.Rating;
            Avaliacoes = item.RatingCount.ToString();
            ImagemUrl = item.ImageUrl;
        }

        public string Titulo
        {
            get => title_txt.Text;
            set => title_txt.Text = value;
        }

        public string Preco
        {
            get => price_lbl.Text;
            set => price_lbl.Text = value;
        }

        public string Loja
        {
            get => source_lbl.Text;
            set => source_lbl.Text = value;
        }

        public string Avaliacoes
        {
            get => ratingCount_lbl.Text;
            set => ratingCount_lbl.Text = value;
        }

        public float Estrelas
        {
            get => rating_stars.Value;
            set => rating_stars.Value = value;
        }

        public string ImagemUrl
        {
            set
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        byte[] imgBytes = wc.DownloadData(value);
                        using (var ms = new System.IO.MemoryStream(imgBytes))
                        {
                            image_url.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                    image_url.Image = SystemIcons.Error.ToBitmap();
                }
            }
        }

        private void comprar_btn_Click(object sender, EventArgs e)
        {
            if (produtoAtual == null)
            {
                MessageBox.Show("Produto não definido.");
                return;
            }

            var produtos = CarrinhoService.ObterProdutos();
            var existente = produtos.Find(p => p.Title == produtoAtual.Title && p.Source == produtoAtual.Source);

            if (existente != null)
            {
                existente.Quantidade += 1;
            }
            else
            {
                // Cria nova instância para adicionar, com quantidade 1
                CarrinhoService.AdicionarProduto(new Item
                {
                    Title = produtoAtual.Title,
                    Source = produtoAtual.Source,
                    Price = produtoAtual.Price,
                    ImageUrl = produtoAtual.ImageUrl,
                    Rating = produtoAtual.Rating,
                    RatingCount = produtoAtual.RatingCount,
                    Quantidade = 1
                    // ValorNumerico será calculado automaticamente via propriedade getter
                });
            }

            MessageBox.Show("Produto adicionado ao carrinho!");

            // Atualiza o contador do carrinho e lista se estiver aberto
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 form1)
                {
                    form1.AtualizarQuantidadeCarrinho();
                }

                if (form is Carrinho carrinho)
                {
                    carrinho.AtualizarCarrinho();
                }
            }
        }
    }
}

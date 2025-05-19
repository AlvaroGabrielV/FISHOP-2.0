using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class ProdutoCard : UserControl
    {
        private Item produtoAtual;
        private readonly int usuarioId;

        public ProdutoCard(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
        }

        public void SetProduto(Item item)
        {
            produtoAtual = item;
            Titulo = item.Title;
            Preco = "R$ " + item.ValorNumerico.ToString("F2").Replace('.', ',');
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
                MessageBox.Show("Produto não definido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adiciona o produto ao carrinho no banco para o usuário logado
            CarrinhoService.AdicionarProduto(usuarioId, produtoAtual);

            MessageBox.Show("Produto adicionado ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Se já houver formulário de Carrinho aberto, atualiza ele
            foreach (Form form in Application.OpenForms)
            {
                if (form is Carrinho carrinhoForm)
                {
                    carrinhoForm.AtualizarCarrinho();
                }
            }
        }
    }
}

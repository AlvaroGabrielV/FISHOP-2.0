using System;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace FISHOP
{
    public partial class CarrinhoCard : UserControl
    {
        // Em vez de CarrinhoItem, use Item diretamente
        public Item Produto { get; set; }
        public int UsuarioId { get; set; } // Precisamos saber qual usuário faz a operação

        public CarrinhoCard()
        {
            InitializeComponent();
        }

        public int Quantidade
        {
            get => (int)quantity_picker.Value;
            set
            {
                if (value < quantity_picker.Minimum)
                    value = (int)quantity_picker.Minimum;
                if (value > quantity_picker.Maximum)
                    value = (int)quantity_picker.Maximum;

                quantity_picker.Value = value;

                if (Produto != null)
                    Produto.Quantidade = value;
            }
        }

        private void quantity_picker_ValueChanged(object sender, EventArgs e)
        {
            if (Produto != null)
            {
                Produto.Quantidade = Quantidade;

                // Atualiza no banco de dados
                CarrinhoService.AtualizarQuantidade(UsuarioId, Produto.Position, Quantidade);

                // Recalcula total na interface
                var formCarrinho = this.FindForm() as Carrinho;
                formCarrinho?.AtualizarTotal();
            }
        }

        private void remover_btn_Click(object sender, EventArgs e)
        {
            if (Produto != null)
            {
                // Remove do banco
                CarrinhoService.RemoverProduto(UsuarioId, Produto.Position);

                // Atualiza interface
                var formCarrinho = this.FindForm() as Carrinho;
                formCarrinho?.AtualizarCarrinho();
            }
        }

        public string Titulo
        {
            get => title_lbl.Text;
            set => title_lbl.Text = value;
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
                            image_url.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                }
                catch
                {
                    image_url.Image = SystemIcons.Error.ToBitmap();
                }
            }
        }
    }
}

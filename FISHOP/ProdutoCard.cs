using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class ProdutoCard : UserControl
    {
        public ProdutoCard()
        {
            InitializeComponent();
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
            set { source_lbl.Text = value; }
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
                    image_url.Image = SystemIcons.Error.ToBitmap(); // Imagem padrão se falhar
                }
            }
        }

        private void comprar_btn_Click(object sender, EventArgs e)
        {
    
            Item produto = new Item
            {
                Title = this.Titulo,
                Price = this.Preco,
                Source = this.Loja,
                Rating = this.Estrelas,
            };

            CarrinhoService.AdicionarProduto(produto);
            MessageBox.Show("Produto adicionado ao carrinho!");

        }

    }
}


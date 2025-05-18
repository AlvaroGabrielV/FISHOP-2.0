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
    public partial class CarrinhoCard : UserControl
    {
        public CarrinhoCard()
        {
            InitializeComponent();
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
            set { source_lbl.Text = value; }
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
    }
}

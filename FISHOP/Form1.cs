namespace FISHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_btn_Click(object sender, EventArgs e)
        {
            flowProdutos.Controls.Clear();

            if (!string.IsNullOrEmpty(input_txt.Text))
            {
                List<Item> produtos = GeradorProduto.GerarProdutos(input_txt.Text);

                if (produtos != null)
                {
                    foreach (var item in produtos)
                    {
                        ProdutoCard card = new ProdutoCard
                        {
                            Titulo = item.Title,
                            Preco = item.Price,
                            Loja = item.Source,
                            Estrelas = item.Rating,
                            Avaliacoes = item.RatingCount.ToString(),
                            ImagemUrl = item.ImageUrl
                        };

                        flowProdutos.Controls.Add(card);
                    }
                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                }
            }
        }

        private void input_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carrinho_btn_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.ShowDialog();


        }
    }
}

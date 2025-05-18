using System;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class EnderecoCadastro : Form
    {
        public static List<Endereco> EnderecosSalvos = new List<Endereco>();
        private Carrinho carrinhoInstance; 

        public EnderecoCadastro(Carrinho carrinho)
        {
            InitializeComponent();
            carrinhoInstance = carrinho; 
        }

        private void salvar_btn_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco
            {
                Usuario = usuario_txt.Text.Trim(),
                Rua = rua_txt.Text.Trim(),
                Numero = numero_txt.Text.Trim(),
                Bairro = bairro_txt.Text.Trim(),
                Cidade = cidade_txt.Text.Trim()
            };

            EnderecoService.AdicionarEndereco(endereco);
            carrinhoInstance.PopularEnderecos(); 

            MessageBox.Show("Endereço salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

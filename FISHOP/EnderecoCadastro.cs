using System;
using System.Windows.Forms;

namespace FISHOP
{
    public partial class EnderecoCadastro : Form
    {
        private readonly int usuarioId;
        private readonly Carrinho carrinhoInstance;

        public EnderecoCadastro(int usuarioId, Carrinho carrinho)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            carrinhoInstance = carrinho;
        }

        private void salvar_btn_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco
            {
                UsuarioId = usuarioId,
                Rua = rua_txt.Text.Trim(),
                Numero = numero_txt.Text.Trim(),
                Bairro = bairro_txt.Text.Trim(),
                Cidade = cidade_txt.Text.Trim()
            };

            bool ok = EnderecoService.AdicionarEndereco(endereco);
            if (ok)
            {
                carrinhoInstance.PopularEnderecos();
                MessageBox.Show("Endereço salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao salvar endereço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

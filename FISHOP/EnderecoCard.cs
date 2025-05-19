using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FISHOP
{
    public partial class EnderecoCard : UserControl
    {
        public EnderecoCard()
        {
            InitializeComponent();
        }

        public int EnderecoId { get; set; }
        public int UsuarioId { get; set; }
        public string Rua
        {
            get => rua_lbl.Text;
            set => rua_lbl.Text = value;
        }

        public string Numero
        {
            get => numero_lbl.Text;
            set => numero_lbl.Text = value;
        }

        public string Bairro
        {
            get => bairro_lbl.Text;
            set => bairro_lbl.Text = value;
        }

        public string Cidade
        {
            get => cidade_lbl.Text;
            set => cidade_lbl.Text = value;
        }

        public string Usuario
        {
            get => user_lbl.Text;
            set => user_lbl.Text = value;
        }

        // Evento para notificar o Carrinho.cs quando um endereço é selecionado
        public event EventHandler EnderecoSelecionado;

        private void endereco_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (endereco_radio.Checked)
            {
                EnderecoSelecionado?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Desmarcar()
        {
            endereco_radio.Checked = false;
        }


        private void deletar_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja realmente remover este endereço?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool ok = EnderecoService.RemoverEndereco(EnderecoId, UsuarioId);
                if (ok)
                {
                    var form = this.FindForm() as Carrinho;
                    form?.PopularEnderecos();
                }
                else
                {
                    MessageBox.Show("Falha ao remover endereço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}


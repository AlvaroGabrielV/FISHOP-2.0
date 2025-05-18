namespace FISHOP
{
    partial class EnderecoCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            deletar_btn = new Guna.UI2.WinForms.Guna2Button();
            user_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cidade_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            bairro_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            numero_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            rua_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            endereco_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(deletar_btn);
            guna2ShadowPanel1.Controls.Add(user_lbl);
            guna2ShadowPanel1.Controls.Add(cidade_lbl);
            guna2ShadowPanel1.Controls.Add(bairro_lbl);
            guna2ShadowPanel1.Controls.Add(numero_lbl);
            guna2ShadowPanel1.Controls.Add(rua_lbl);
            guna2ShadowPanel1.Controls.Add(endereco_radio);
            guna2ShadowPanel1.FillColor = Color.LightSkyBlue;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new Size(307, 101);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // deletar_btn
            // 
            deletar_btn.BackgroundImage = Properties.Resources.trash_can;
            deletar_btn.BackgroundImageLayout = ImageLayout.Zoom;
            deletar_btn.CustomizableEdges = customizableEdges1;
            deletar_btn.DisabledState.BorderColor = Color.DarkGray;
            deletar_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            deletar_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deletar_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deletar_btn.FillColor = Color.Transparent;
            deletar_btn.Font = new Font("Segoe UI", 9F);
            deletar_btn.ForeColor = SystemColors.ActiveCaptionText;
            deletar_btn.Location = new Point(269, 58);
            deletar_btn.Name = "deletar_btn";
            deletar_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            deletar_btn.Size = new Size(23, 26);
            deletar_btn.TabIndex = 2;
            deletar_btn.Click += deletar_btn_Click;
            // 
            // user_lbl
            // 
            user_lbl.BackColor = Color.Transparent;
            user_lbl.Location = new Point(41, 35);
            user_lbl.Name = "user_lbl";
            user_lbl.Size = new Size(77, 17);
            user_lbl.TabIndex = 2;
            user_lbl.Text = "Alvaro Gabriel";
            // 
            // cidade_lbl
            // 
            cidade_lbl.BackColor = Color.Transparent;
            cidade_lbl.Location = new Point(104, 58);
            cidade_lbl.Name = "cidade_lbl";
            cidade_lbl.Size = new Size(38, 17);
            cidade_lbl.TabIndex = 2;
            cidade_lbl.Text = "Sabará";
            // 
            // bairro_lbl
            // 
            bairro_lbl.BackColor = Color.Transparent;
            bairro_lbl.Location = new Point(41, 58);
            bairro_lbl.Name = "bairro_lbl";
            bairro_lbl.Size = new Size(41, 17);
            bairro_lbl.TabIndex = 2;
            bairro_lbl.Text = "Ravena";
            // 
            // numero_lbl
            // 
            numero_lbl.BackColor = Color.Transparent;
            numero_lbl.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numero_lbl.Location = new Point(231, 12);
            numero_lbl.Name = "numero_lbl";
            numero_lbl.Size = new Size(35, 18);
            numero_lbl.TabIndex = 2;
            numero_lbl.Text = "N° 25";
            // 
            // rua_lbl
            // 
            rua_lbl.BackColor = Color.Transparent;
            rua_lbl.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rua_lbl.Location = new Point(41, 12);
            rua_lbl.Name = "rua_lbl";
            rua_lbl.Size = new Size(166, 17);
            rua_lbl.TabIndex = 2;
            rua_lbl.Text = "Rua Valdomiro Ferreira Pinto";
            // 
            // endereco_radio
            // 
            endereco_radio.Animated = true;
            endereco_radio.CheckedState.BorderColor = Color.White;
            endereco_radio.CheckedState.BorderThickness = 2;
            endereco_radio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            endereco_radio.CheckedState.InnerColor = Color.RoyalBlue;
            endereco_radio.CheckedState.InnerOffset = 2;
            endereco_radio.Location = new Point(12, -3);
            endereco_radio.Name = "endereco_radio";
            endereco_radio.Size = new Size(313, 101);
            endereco_radio.TabIndex = 0;
            endereco_radio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            endereco_radio.UncheckedState.BorderThickness = 2;
            endereco_radio.UncheckedState.FillColor = Color.Transparent;
            endereco_radio.UncheckedState.InnerColor = Color.Transparent;
            endereco_radio.CheckedChanged += endereco_radio_CheckedChanged;
            // 
            // EnderecoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "EnderecoCard";
            Size = new Size(331, 117);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2RadioButton endereco_radio;
        private Guna.UI2.WinForms.Guna2HtmlLabel cidade_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel bairro_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel numero_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel rua_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel user_lbl;
        private Guna.UI2.WinForms.Guna2Button deletar_btn;
    }
}

namespace FISHOP
{
    partial class Carrinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            back_btn = new Guna.UI2.WinForms.Guna2Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            total_lbl = new Label();
            endereco_flow = new FlowLayoutPanel();
            cadastro_endereco = new LinkLabel();
            endereco_panel = new Guna.UI2.WinForms.Guna2Panel();
            taxa_lbl = new Label();
            subtotal_lbl = new Label();
            finalizar_btn = new Guna.UI2.WinForms.Guna2Button();
            endereco_panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // back_btn
            // 
            back_btn.CustomizableEdges = customizableEdges5;
            back_btn.DisabledState.BorderColor = Color.DarkGray;
            back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            back_btn.FillColor = Color.Transparent;
            back_btn.Font = new Font("Segoe UI", 9F);
            back_btn.ForeColor = Color.Black;
            back_btn.Image = Properties.Resources.arrow;
            back_btn.Location = new Point(14, 14);
            back_btn.Margin = new Padding(5);
            back_btn.Name = "back_btn";
            back_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            back_btn.Size = new Size(90, 39);
            back_btn.TabIndex = 0;
            back_btn.Text = "Voltar";
            back_btn.Click += back_btn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.SteelBlue;
            flowLayoutPanel1.Location = new Point(14, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 449);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Location = new Point(545, 553);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(100, 23);
            total_lbl.TabIndex = 2;
            total_lbl.Text = "ValorTotal";
            // 
            // endereco_flow
            // 
            endereco_flow.BackColor = Color.SteelBlue;
            endereco_flow.Location = new Point(656, 58);
            endereco_flow.Name = "endereco_flow";
            endereco_flow.Size = new Size(330, 449);
            endereco_flow.TabIndex = 3;
            // 
            // cadastro_endereco
            // 
            cadastro_endereco.LinkArea = new LinkArea(28, 41);
            cadastro_endereco.LinkBehavior = LinkBehavior.NeverUnderline;
            cadastro_endereco.LinkColor = Color.FromArgb(192, 192, 255);
            cadastro_endereco.Location = new Point(3, 9);
            cadastro_endereco.Name = "cadastro_endereco";
            cadastro_endereco.Size = new Size(327, 86);
            cadastro_endereco.TabIndex = 0;
            cadastro_endereco.TabStop = true;
            cadastro_endereco.Text = "Nenhum endereço cadastrado! Cadastre Aqui";
            cadastro_endereco.TextAlign = ContentAlignment.MiddleCenter;
            cadastro_endereco.UseCompatibleTextRendering = true;
            cadastro_endereco.LinkClicked += cadastro_endereco_LinkClicked;
            // 
            // endereco_panel
            // 
            endereco_panel.BackColor = Color.SteelBlue;
            endereco_panel.Controls.Add(cadastro_endereco);
            endereco_panel.CustomizableEdges = customizableEdges3;
            endereco_panel.Location = new Point(656, 89);
            endereco_panel.Name = "endereco_panel";
            endereco_panel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            endereco_panel.Size = new Size(330, 95);
            endereco_panel.TabIndex = 4;
            // 
            // taxa_lbl
            // 
            taxa_lbl.AutoSize = true;
            taxa_lbl.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taxa_lbl.Location = new Point(548, 533);
            taxa_lbl.Name = "taxa_lbl";
            taxa_lbl.Size = new Size(39, 15);
            taxa_lbl.TabIndex = 2;
            taxa_lbl.Text = "Frete:";
            // 
            // subtotal_lbl
            // 
            subtotal_lbl.AutoSize = true;
            subtotal_lbl.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtotal_lbl.Location = new Point(548, 510);
            subtotal_lbl.Name = "subtotal_lbl";
            subtotal_lbl.Size = new Size(59, 15);
            subtotal_lbl.TabIndex = 2;
            subtotal_lbl.Text = "SubTotal:";
            // 
            // finalizar_btn
            // 
            finalizar_btn.CustomizableEdges = customizableEdges1;
            finalizar_btn.DisabledState.BorderColor = Color.DarkGray;
            finalizar_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            finalizar_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            finalizar_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            finalizar_btn.Font = new Font("Segoe UI", 9F);
            finalizar_btn.ForeColor = Color.White;
            finalizar_btn.Location = new Point(729, 525);
            finalizar_btn.Name = "finalizar_btn";
            finalizar_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            finalizar_btn.Size = new Size(202, 33);
            finalizar_btn.TabIndex = 5;
            finalizar_btn.Text = "Finalizar Compra ";
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 203, 255);
            ClientSize = new Size(1016, 577);
            Controls.Add(finalizar_btn);
            Controls.Add(endereco_panel);
            Controls.Add(endereco_flow);
            Controls.Add(subtotal_lbl);
            Controls.Add(taxa_lbl);
            Controls.Add(total_lbl);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(back_btn);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Carrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrinho";
            Load += Carrinho_Load;
            endereco_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label total_lbl;
        private FlowLayoutPanel endereco_flow;
        private LinkLabel cadastro_endereco;
        private Guna.UI2.WinForms.Guna2Panel endereco_panel;
        private Label subtotal_lbl;
        private Label taxa_lbl;
        private Guna.UI2.WinForms.Guna2Button finalizar_btn;
    }
}
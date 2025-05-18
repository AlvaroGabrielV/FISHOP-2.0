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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            back_btn = new Guna.UI2.WinForms.Guna2Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // back_btn
            // 
            back_btn.CustomizableEdges = customizableEdges1;
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
            back_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            back_btn.Size = new Size(90, 39);
            back_btn.TabIndex = 0;
            back_btn.Text = "Voltar";
            back_btn.Click += back_btn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SteelBlue;
            flowLayoutPanel1.Location = new Point(14, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(916, 449);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 203, 255);
            ClientSize = new Size(942, 577);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(back_btn);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Carrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrinho";
            Load += Carrinho_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
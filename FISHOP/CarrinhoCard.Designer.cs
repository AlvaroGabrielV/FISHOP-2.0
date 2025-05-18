namespace FISHOP
{
    partial class CarrinhoCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            image_url = new Guna.UI2.WinForms.Guna2PictureBox();
            title_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            source_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            price_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            quantity_picker = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            rating_stars = new Guna.UI2.WinForms.Guna2RatingStar();
            ((System.ComponentModel.ISupportInitialize)image_url).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantity_picker).BeginInit();
            SuspendLayout();
            // 
            // image_url
            // 
            image_url.BackColor = Color.Transparent;
            image_url.BackgroundImageLayout = ImageLayout.Zoom;
            image_url.BorderRadius = 10;
            image_url.CustomizableEdges = customizableEdges1;
            image_url.ImageRotate = 0F;
            image_url.Location = new Point(21, 14);
            image_url.Name = "image_url";
            image_url.ShadowDecoration.CustomizableEdges = customizableEdges2;
            image_url.Size = new Size(140, 124);
            image_url.SizeMode = PictureBoxSizeMode.Zoom;
            image_url.TabIndex = 0;
            image_url.TabStop = false;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = false;
            title_lbl.BackColor = Color.Transparent;
            title_lbl.Location = new Point(167, 21);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(429, 45);
            title_lbl.TabIndex = 1;
            title_lbl.Text = "Nome do Produto";
            // 
            // source_lbl
            // 
            source_lbl.BackColor = Color.Transparent;
            source_lbl.Location = new Point(167, 114);
            source_lbl.Name = "source_lbl";
            source_lbl.Size = new Size(33, 17);
            source_lbl.TabIndex = 2;
            source_lbl.Text = "Fonte";
            // 
            // price_lbl
            // 
            price_lbl.BackColor = Color.Transparent;
            price_lbl.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_lbl.Location = new Point(454, 105);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(62, 26);
            price_lbl.TabIndex = 2;
            price_lbl.Text = "Preco";
            price_lbl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(quantity_picker);
            guna2ShadowPanel1.Controls.Add(guna2Button1);
            guna2ShadowPanel1.Controls.Add(rating_stars);
            guna2ShadowPanel1.Controls.Add(price_lbl);
            guna2ShadowPanel1.Controls.Add(source_lbl);
            guna2ShadowPanel1.Controls.Add(title_lbl);
            guna2ShadowPanel1.Controls.Add(image_url);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(6, 5);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 12;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(580, 144);
            guna2ShadowPanel1.TabIndex = 3;
            // 
            // quantity_picker
            // 
            quantity_picker.BackColor = Color.Transparent;
            quantity_picker.CustomizableEdges = customizableEdges3;
            quantity_picker.Font = new Font("Segoe UI", 9F);
            quantity_picker.Location = new Point(493, 57);
            quantity_picker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantity_picker.Name = "quantity_picker";
            quantity_picker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            quantity_picker.Size = new Size(71, 33);
            quantity_picker.TabIndex = 5;
            quantity_picker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantity_picker.ValueChanged += quantity_picker_ValueChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BackgroundImage = Properties.Resources.trash_can;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.FocusedColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.ImageAlign = HorizontalAlignment.Right;
            guna2Button1.ImageSize = new Size(35, 35);
            guna2Button1.Location = new Point(537, 14);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(27, 22);
            guna2Button1.TabIndex = 4;
            guna2Button1.Click += remover_btn_Click;
            // 
            // rating_stars
            // 
            rating_stars.Location = new Point(167, 92);
            rating_stars.Name = "rating_stars";
            rating_stars.ReadOnly = true;
            rating_stars.Size = new Size(81, 23);
            rating_stars.TabIndex = 3;
            // 
            // CarrinhoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Name = "CarrinhoCard";
            Size = new Size(586, 153);
            ((System.ComponentModel.ISupportInitialize)image_url).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantity_picker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox image_url;
        private Guna.UI2.WinForms.Guna2HtmlLabel title_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel source_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel price_lbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2RatingStar rating_stars;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantity_picker;
    }
}

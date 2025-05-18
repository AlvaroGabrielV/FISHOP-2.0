namespace FISHOP
{
    partial class ProdutoCard
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
            image_url = new Guna.UI2.WinForms.Guna2PictureBox();
            price_lbl = new Label();
            source_lbl = new Label();
            rating_stars = new Guna.UI2.WinForms.Guna2RatingStar();
            ratingCount_lbl = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            comprar_btn = new Guna.UI2.WinForms.Guna2Button();
            title_txt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)image_url).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // image_url
            // 
            image_url.BackColor = Color.Black;
            image_url.BackgroundImageLayout = ImageLayout.Center;
            image_url.CustomizableEdges = customizableEdges1;
            image_url.ImageRotate = 0F;
            image_url.Location = new Point(41, 16);
            image_url.Name = "image_url";
            image_url.ShadowDecoration.BorderRadius = 0;
            image_url.ShadowDecoration.Color = Color.Transparent;
            image_url.ShadowDecoration.CustomizableEdges = customizableEdges2;
            image_url.ShadowDecoration.Depth = 0;
            image_url.Size = new Size(140, 127);
            image_url.SizeMode = PictureBoxSizeMode.StretchImage;
            image_url.TabIndex = 2;
            image_url.TabStop = false;
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_lbl.Location = new Point(3, 265);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(68, 30);
            price_lbl.TabIndex = 4;
            price_lbl.Text = "Preço";
            // 
            // source_lbl
            // 
            source_lbl.AutoSize = true;
            source_lbl.Location = new Point(3, 250);
            source_lbl.Name = "source_lbl";
            source_lbl.Size = new Size(37, 15);
            source_lbl.TabIndex = 4;
            source_lbl.Text = "Fonte";
            // 
            // rating_stars
            // 
            rating_stars.Location = new Point(3, 219);
            rating_stars.Name = "rating_stars";
            rating_stars.Size = new Size(103, 28);
            rating_stars.TabIndex = 5;
            // 
            // ratingCount_lbl
            // 
            ratingCount_lbl.AutoSize = true;
            ratingCount_lbl.Location = new Point(112, 232);
            ratingCount_lbl.Name = "ratingCount_lbl";
            ratingCount_lbl.Size = new Size(13, 15);
            ratingCount_lbl.TabIndex = 3;
            ratingCount_lbl.Text = "0";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(comprar_btn);
            guna2ShadowPanel1.Controls.Add(title_txt);
            guna2ShadowPanel1.Controls.Add(image_url);
            guna2ShadowPanel1.Controls.Add(price_lbl);
            guna2ShadowPanel1.Controls.Add(source_lbl);
            guna2ShadowPanel1.Controls.Add(rating_stars);
            guna2ShadowPanel1.Controls.Add(ratingCount_lbl);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Gray;
            guna2ShadowPanel1.ShadowShift = 10;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            guna2ShadowPanel1.Size = new Size(236, 311);
            guna2ShadowPanel1.TabIndex = 7;
            // 
            // comprar_btn
            // 
            comprar_btn.BorderRadius = 15;
            comprar_btn.CustomizableEdges = customizableEdges3;
            comprar_btn.DisabledState.BorderColor = Color.DarkGray;
            comprar_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            comprar_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            comprar_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            comprar_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comprar_btn.ForeColor = Color.White;
            comprar_btn.Location = new Point(131, 243);
            comprar_btn.Name = "comprar_btn";
            comprar_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            comprar_btn.Size = new Size(84, 27);
            comprar_btn.TabIndex = 8;
            comprar_btn.Text = "Comprar";
            comprar_btn.UseTransparentBackground = true;
            comprar_btn.Click += comprar_btn_Click;
            // 
            // title_txt
            // 
            title_txt.AutoSize = false;
            title_txt.BackColor = Color.Transparent;
            title_txt.Location = new Point(3, 149);
            title_txt.Name = "title_txt";
            title_txt.Size = new Size(199, 72);
            title_txt.TabIndex = 7;
            title_txt.Text = "Nome";
            // 
            // ProdutoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "ProdutoCard";
            Size = new Size(239, 314);
            ((System.ComponentModel.ISupportInitialize)image_url).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox image_url;
        private Label price_lbl;
        private Label source_lbl;
        private Guna.UI2.WinForms.Guna2RatingStar rating_stars;
        private Label ratingCount_lbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel title_txt;
        private Guna.UI2.WinForms.Guna2Button comprar_btn;
    }
}

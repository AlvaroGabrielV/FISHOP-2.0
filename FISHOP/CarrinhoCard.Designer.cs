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
            image_url = new Guna.UI2.WinForms.Guna2PictureBox();
            title_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            source_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            price_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            rating_stars = new Guna.UI2.WinForms.Guna2RatingStar();
            ((System.ComponentModel.ISupportInitialize)image_url).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // image_url
            // 
            image_url.BackColor = Color.DimGray;
            image_url.BorderRadius = 10;
            image_url.CustomizableEdges = customizableEdges1;
            image_url.ImageRotate = 0F;
            image_url.Location = new Point(21, 14);
            image_url.Name = "image_url";
            image_url.ShadowDecoration.CustomizableEdges = customizableEdges2;
            image_url.Size = new Size(140, 124);
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
            source_lbl.Location = new Point(167, 121);
            source_lbl.Name = "source_lbl";
            source_lbl.Size = new Size(33, 17);
            source_lbl.TabIndex = 2;
            source_lbl.Text = "Fonte";
            // 
            // price_lbl
            // 
            price_lbl.BackColor = Color.Transparent;
            price_lbl.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_lbl.Location = new Point(490, 106);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(62, 26);
            price_lbl.TabIndex = 2;
            price_lbl.Text = "Preco";
            price_lbl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
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
            guna2ShadowPanel1.Size = new Size(601, 153);
            guna2ShadowPanel1.TabIndex = 3;
            // 
            // rating_stars
            // 
            rating_stars.Location = new Point(164, 98);
            rating_stars.Name = "rating_stars";
            rating_stars.Size = new Size(81, 23);
            rating_stars.TabIndex = 3;
            // 
            // CarrinhoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(guna2ShadowPanel1);
            Name = "CarrinhoCard";
            Size = new Size(615, 167);
            ((System.ComponentModel.ISupportInitialize)image_url).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox image_url;
        private Guna.UI2.WinForms.Guna2HtmlLabel title_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel source_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel price_lbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2RatingStar rating_stars;
    }
}

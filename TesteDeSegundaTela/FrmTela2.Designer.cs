namespace TesteDeSegundaTela
{
    partial class Frm_tela2
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_tela2));
            this.kamiLogo = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // kamiLogo
            // 
            this.kamiLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kamiLogo.ImageStream")));
            this.kamiLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.kamiLogo.Images.SetKeyName(0, "kamikami.png");
            // 
            // Frm_tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_tela2";
            this.Text = "KAMI KAMI Yakissoba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList kamiLogo;
    }
}


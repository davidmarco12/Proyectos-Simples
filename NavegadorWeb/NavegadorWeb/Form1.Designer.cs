namespace NavegadorWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRetro = new System.Windows.Forms.ToolStripButton();
            this.btnAvanzar = new System.Windows.Forms.ToolStripButton();
            this.btnDetener = new System.Windows.Forms.ToolStripButton();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pbCarga = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRetro,
            this.btnAvanzar,
            this.btnDetener,
            this.btnRecargar,
            this.btnHome,
            this.txtURL,
            this.toolStripButton6,
            this.pbCarga});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRetro
            // 
            this.btnRetro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRetro.Image = ((System.Drawing.Image)(resources.GetObject("btnRetro.Image")));
            this.btnRetro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(23, 22);
            this.btnRetro.Text = "Atras";
            this.btnRetro.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAvanzar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvanzar.Image")));
            this.btnAvanzar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(23, 22);
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDetener.Image = ((System.Drawing.Image)(resources.GetObject("btnDetener.Image")));
            this.btnDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(23, 22);
            this.btnDetener.Text = "Detener";
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(23, 22);
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 22);
            this.btnHome.Tag = "";
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(550, 25);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            this.webBrowser1.RegionChanged += new System.EventHandler(this.webBrowser1_RegionChanged);
            // 
            // pbCarga
            // 
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(80, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRetro;
        private System.Windows.Forms.ToolStripButton btnAvanzar;
        private System.Windows.Forms.ToolStripButton btnDetener;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripProgressBar pbCarga;
    }
}


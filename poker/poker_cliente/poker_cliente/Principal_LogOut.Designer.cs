namespace poker_cliente
{
    partial class Principal_LogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_LogOut));
            this.Connector_button = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.IP_Box = new System.Windows.Forms.TextBox();
            this.consolaToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.inicioDeSesión = new System.Windows.Forms.ToolStripButton();
            this.resgistro = new System.Windows.Forms.ToolStripButton();
            this.consolaToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connector_button
            // 
            this.Connector_button.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connector_button.Location = new System.Drawing.Point(339, 184);
            this.Connector_button.Name = "Connector_button";
            this.Connector_button.Size = new System.Drawing.Size(222, 79);
            this.Connector_button.TabIndex = 0;
            this.Connector_button.Text = "Conectar";
            this.Connector_button.UseVisualStyleBackColor = true;
            this.Connector_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar.Location = new System.Drawing.Point(339, 328);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(222, 79);
            this.Desconectar.TabIndex = 1;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // IP_Box
            // 
            this.IP_Box.Location = new System.Drawing.Point(339, 88);
            this.IP_Box.Name = "IP_Box";
            this.IP_Box.Size = new System.Drawing.Size(222, 26);
            this.IP_Box.TabIndex = 2;
            this.IP_Box.TextChanged += new System.EventHandler(this.IP_Box_TextChanged);
            // 
            // consolaToolStripMenuItem
            // 
            this.consolaToolStripMenuItem.AllowMerge = false;
            this.consolaToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.consolaToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioDeSesión,
            this.resgistro});
            this.consolaToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.consolaToolStripMenuItem.Name = "consolaToolStripMenuItem";
            this.consolaToolStripMenuItem.Size = new System.Drawing.Size(989, 34);
            this.consolaToolStripMenuItem.TabIndex = 3;
            this.consolaToolStripMenuItem.Text = "Conexión";
            this.consolaToolStripMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // inicioDeSesión
            // 
            this.inicioDeSesión.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.inicioDeSesión.Image = ((System.Drawing.Image)(resources.GetObject("inicioDeSesión.Image")));
            this.inicioDeSesión.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inicioDeSesión.Name = "inicioDeSesión";
            this.inicioDeSesión.Size = new System.Drawing.Size(142, 29);
            this.inicioDeSesión.Text = "Inicio De Sesión";
            this.inicioDeSesión.Click += new System.EventHandler(this.inicioDeSesión_Click);
            // 
            // resgistro
            // 
            this.resgistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resgistro.Image = ((System.Drawing.Image)(resources.GetObject("resgistro.Image")));
            this.resgistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resgistro.Name = "resgistro";
            this.resgistro.Size = new System.Drawing.Size(81, 29);
            this.resgistro.Text = "Registro";
            this.resgistro.Click += new System.EventHandler(this.resgistro_Click);
            // 
            // Principal_LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 692);
            this.Controls.Add(this.consolaToolStripMenuItem);
            this.Controls.Add(this.IP_Box);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Connector_button);
            this.Name = "Principal_LogOut";
            this.Text = "Conexión";
            this.Load += new System.EventHandler(this.Principal_Logged_Load);
            this.consolaToolStripMenuItem.ResumeLayout(false);
            this.consolaToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connector_button;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.TextBox IP_Box;
        private System.Windows.Forms.ToolStrip consolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton inicioDeSesión;
        private System.Windows.Forms.ToolStripButton resgistro;
    }
}


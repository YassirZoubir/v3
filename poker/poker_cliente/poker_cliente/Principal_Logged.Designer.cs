namespace poker_cliente
{
    partial class Principal_Logged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Logged));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Conectados = new System.Windows.Forms.ToolStrip();
            this.logOut = new System.Windows.Forms.ToolStripButton();
            this.panelConectados = new System.Windows.Forms.ToolStripButton();
            this.dataGridConectados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.Conectados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1433, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Conectados
            // 
            this.Conectados.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Conectados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelConectados});
            this.Conectados.Location = new System.Drawing.Point(0, 34);
            this.Conectados.Name = "Conectados";
            this.Conectados.Size = new System.Drawing.Size(1433, 34);
            this.Conectados.TabIndex = 1;
            this.Conectados.Text = "toolStrip2";
            this.Conectados.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // logOut
            // 
            this.logOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(81, 29);
            this.logOut.Text = "Log Out";
            this.logOut.ToolTipText = "Log out";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panelConectados
            // 
            this.panelConectados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.panelConectados.Image = ((System.Drawing.Image)(resources.GetObject("panelConectados.Image")));
            this.panelConectados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panelConectados.Name = "panelConectados";
            this.panelConectados.Size = new System.Drawing.Size(110, 29);
            this.panelConectados.Text = "Conectados";
            this.panelConectados.Click += new System.EventHandler(this.conectados_Click);
            // 
            // dataGridConectados
            // 
            this.dataGridConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConectados.Location = new System.Drawing.Point(84, 514);
            this.dataGridConectados.Name = "dataGridConectados";
            this.dataGridConectados.RowHeadersWidth = 62;
            this.dataGridConectados.RowTemplate.Height = 28;
            this.dataGridConectados.Size = new System.Drawing.Size(298, 290);
            this.dataGridConectados.TabIndex = 2;
            // 
            // Principal_Logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1433, 894);
            this.Controls.Add(this.dataGridConectados);
            this.Controls.Add(this.Conectados);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Principal_Logged";
            this.Text = "Principal_Logged";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Conectados.ResumeLayout(false);
            this.Conectados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton logOut;
        private System.Windows.Forms.ToolStrip Conectados;
        private System.Windows.Forms.ToolStripButton panelConectados;
        private System.Windows.Forms.DataGridView dataGridConectados;
    }
}
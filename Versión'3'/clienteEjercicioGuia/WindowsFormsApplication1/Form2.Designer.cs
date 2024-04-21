namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JugadoresPartida = new System.Windows.Forms.RadioButton();
            this.Posicion = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.partidaBox = new System.Windows.Forms.TextBox();
            this.NumeroPartidas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Contraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Contraseña);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.JugadoresPartida);
            this.groupBox1.Controls.Add(this.Posicion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.partidaBox);
            this.groupBox1.Controls.Add(this.NumeroPartidas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(490, 378);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // JugadoresPartida
            // 
            this.JugadoresPartida.AutoSize = true;
            this.JugadoresPartida.Location = new System.Drawing.Point(174, 222);
            this.JugadoresPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JugadoresPartida.Name = "JugadoresPartida";
            this.JugadoresPartida.Size = new System.Drawing.Size(288, 24);
            this.JugadoresPartida.TabIndex = 7;
            this.JugadoresPartida.TabStop = true;
            this.JugadoresPartida.Text = "Cuantos jugadores hay en la partida";
            this.JugadoresPartida.UseVisualStyleBackColor = true;
            // 
            // Posicion
            // 
            this.Posicion.AutoSize = true;
            this.Posicion.Location = new System.Drawing.Point(174, 264);
            this.Posicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Posicion.Name = "Posicion";
            this.Posicion.Size = new System.Drawing.Size(249, 24);
            this.Posicion.TabIndex = 7;
            this.Posicion.TabStop = true;
            this.Posicion.Text = "Que posicion del ranking estoy";
            this.Posicion.UseVisualStyleBackColor = true;
            this.Posicion.CheckedChanged += new System.EventHandler(this.altura_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partida";
            // 
            // partidaBox
            // 
            this.partidaBox.Location = new System.Drawing.Point(42, 222);
            this.partidaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partidaBox.Name = "partidaBox";
            this.partidaBox.Size = new System.Drawing.Size(91, 26);
            this.partidaBox.TabIndex = 9;
            // 
            // NumeroPartidas
            // 
            this.NumeroPartidas.AutoSize = true;
            this.NumeroPartidas.Location = new System.Drawing.Point(174, 187);
            this.NumeroPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumeroPartidas.Name = "NumeroPartidas";
            this.NumeroPartidas.Size = new System.Drawing.Size(229, 24);
            this.NumeroPartidas.TabIndex = 8;
            this.NumeroPartidas.TabStop = true;
            this.NumeroPartidas.Text = "Cuantas partidas he jugado";
            this.NumeroPartidas.UseVisualStyleBackColor = true;
            this.NumeroPartidas.CheckedChanged += new System.EventHandler(this.Bonito_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 323);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 48);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 3;
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(12, 21);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(181, 67);
            this.Conectar.TabIndex = 8;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(235, 21);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(181, 67);
            this.Desconectar.TabIndex = 9;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(490, 183);
            this.dataGridView1.TabIndex = 10;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Enabled = false;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(35, 99);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(183, 37);
            this.Contraseña.TabIndex = 10;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 751);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton JugadoresPartida;
        private System.Windows.Forms.RadioButton Posicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partidaBox;
        private System.Windows.Forms.RadioButton NumeroPartidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox textBox1;
    }
}
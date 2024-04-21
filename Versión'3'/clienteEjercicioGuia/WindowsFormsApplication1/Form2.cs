using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            if (JugadoresPartida.Checked)
            {
                string mensaje = "1/"+nForm+"/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("El jugador "+ nombre.Text + " ha jugado "+ mensaje+ "Partidas");


            }
            else if (NumeroPartidas.Checked)
            {
                string mensaje = "2/" + nForm + "/" + partidaBox;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje + " jugaron en la fecha: " + partidaBox);
            }
            else if (Posicion.Checked)
            {
                // Enviamos nombre y altura
                string mensaje = "3/" + nForm + "/" + nombre.Text + "/" + partidaBox.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("Estas en la posición " + mensaje + "del ranking");
            }   

            string mensajes = nombre.Text + "/" + Contraseña.Text;
            byte[] msgs = System.Text.Encoding.ASCII.GetBytes(mensajes);
            server.Send(msgs);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns[0].HeaderText = "Jugadores Conectados";

            dataGridView1.Rows[0].Cells[0].Value = nombre.Text;
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(ipep);
            this.BackColor = Color.Green;
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void altura_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bonito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

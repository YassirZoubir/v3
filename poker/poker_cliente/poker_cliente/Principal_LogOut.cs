﻿using poker_cliente.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace poker_cliente
{
    public partial class Principal_LogOut : Form
    {
        Socket server;
        User user = new User();
        Thread atender; Thread ThreadLogged;
        login_form logged_form;
        login_form lform;
        register_form rform;

        public Principal_LogOut()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Principal_Logged_Load(object sender, EventArgs e)
        {

        }

        public void AtenderServidor()
        {
            while (true)
            {
                byte[] msg2 = new byte[512];
                server.Receive(msg2);

                string[] trozos = Encoding.ASCII.GetString(msg2).Split(new[] {'/'}, 2);
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje = trozos[1];

                switch (codigo)
                {
                    case 1:
                        rform.Respuesta(mensaje);
                        break;
                    case 2:
                        int res = lform.Respuesta(mensaje);
                        if (res == 0)
                        {
                            logged_form = new Principal_Logged(lform.GetUser(), server);
                            lform.Close();

                            ThreadStart ts = delegate { logged_form.ShowDialog();};
                            ThreadLogged = new Thread(ts);
                            ThreadLogged.Start();
                        }
                        break;
                    case 3:
                        logged_form.Tabla(mensaje);
                        break;
                    case 4:
                        logged_form.GestionarLogOut(mensaje);
                        logged_form.Close();
                        break;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse(IP_Box.Text);
                IPEndPoint ipep = new IPEndPoint(direc, 9070);
                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    MessageBox.Show("Conectado");

                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    server = null;
                    return;
                }

                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();
            }
            else
                MessageBox.Show("Ya estas conectado");
        }

        private void IP_Box_TextChanged(object sender, EventArgs e)
        {
            e.Handled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (consolaToolStripMenuItem.Checked == false)
                ConsolaControl.Visible = false;
            else if (consolaToolStripMenuItem.Checked == true)
                ConsolaControl.Visible = true;
        }

        private void inicioDeSesión_Click(object sender, EventArgs e)
        {
            lform = new login_form(server);
            lform.ShowDialog();
        }

        private void resgistro_Click(object sender, EventArgs e)
        {
            this.rform = new register_form(user, server);
            rform.ShowDialog();
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                // Se terminó el servicio. 
                // Nos desconectamos
                string mensaje = "0/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                atender.Abort();
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            else
                MessageBox.Show("No esta conectado");
        }
    }

}

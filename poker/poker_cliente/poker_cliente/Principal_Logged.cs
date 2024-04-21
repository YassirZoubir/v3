using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poker_cliente
{
    public partial class Principal_Logged : Form
    {
        User user;
        Socket server;
        public Principal_Logged()
        {
            InitializeComponent();
            this.user = user;
            this.server = server;

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Quieres cerrar la session?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string mensaje = "4/" + user.Name;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void conectados_Click(object sender, EventArgs e)
        {
            
        }
        public void Tabla(string mensaje)
        {
            string[] trozos = mensaje.Split('/');
            dataGridConectados.RowCount = Convert.ToInt32(trozos[0]);
            if (Convert.ToInt32(trozos[0]) != 0)
            {
                for (int i = 0; i < Convert.ToInt32(trozos[0]); i++)
                {
                    dataGridConectados.Rows[i].Cells[0].Value = trozos[i + 1];

                }
            }
        }
        public void GestionarLogOut(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Conectados.Checked == false)
                dataGridConectados.Visible = false;
            else if (Conectados.Checked == true)
                dataGridConectados.Visible = true;
        }
    }
}

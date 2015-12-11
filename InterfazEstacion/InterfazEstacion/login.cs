using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEstacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_usuario.Text.Equals("root") && textBox_password.Text.Equals("root"))
            {
                Form1 principal = new Form1(textBox_usuario.Text);
                principal.Show();
                this.Visible = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: Usuario y/o password incorrecto");
            }
        }
    }
}

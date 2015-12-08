using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                Form1 principal = new Form1();
                principal.Show();
                this.Visible = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace InterfazEstacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            int res=0;
            EstMeteo.EstacionMeteo em = new EstMeteo.EstacionMeteo();
            switch (comboBox_Atributo.Text)
            {
                case "Temperatura":
                    res = em.getTemperatura();
                    label_resultados.Text = "Temperatura=";
                    break;
                case "Humedad":
                    res = em.getHumedad();
                    label_resultados.Text = "Humedad=";
                    break;
                case "Luminosidad":
                    res = em.getLuminosidad();
                    label_resultados.Text = "Luminosidad=";
                    break;
            }
            label_resultados.Text = label_resultados.Text + res;
        }



        private void button_Modificar_Click(object sender, EventArgs e)
        {
            string res = "La operación fallo";
            EstMeteo.EstacionMeteo em = new EstMeteo.EstacionMeteo();
            switch (comboBox_Atributo.Text)
            {
                case "Temperatura":
                    res = em.setTemperatura(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
                case "Humedad":
                    res = em.setHumedad(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
                case "Luminosidad":
                    res = em.setLuminosidad(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            listView_estacionesReg.Items.Add(textBox_direccion.Text);
            comboBox_Estacion.Items.Insert(comboBox_Estacion.Items.Count, textBox_direccion.Text);
        }

        private void listView_estacionesReg_ItemActivate(object server, EventArgs e)
        {
            mensaje_conexion.Text = "Conectado";
        }
    }
}

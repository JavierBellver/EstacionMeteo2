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

        EstMeteo.EstacionMeteo maquina_seleccionada;

        public Form1()
        {
            InitializeComponent();
            maquina_seleccionada = new EstMeteo.EstacionMeteo();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            int res=0;
            switch (comboBox_Atributo.Text)
            {
                case "Temperatura":
                    res = maquina_seleccionada.getTemperatura();
                    label_resultados.Text = "Temperatura=";
                    break;
                case "Humedad":
                    res = maquina_seleccionada.getHumedad();
                    label_resultados.Text = "Humedad=";
                    break;
                case "Luminosidad":
                    res = maquina_seleccionada.getLuminosidad();
                    label_resultados.Text = "Luminosidad=";
                    break;
            }
            label_resultados.Text = label_resultados.Text + res;
        }



        private void button_Modificar_Click(object sender, EventArgs e)
        {
            string res = "La operación fallo";
            switch (comboBox_Atributo.Text)
            {
                case "Temperatura":
                    res = maquina_seleccionada.setTemperatura(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
                case "Humedad":
                    res = maquina_seleccionada.setHumedad(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
                case "Luminosidad":
                    res = maquina_seleccionada.setLuminosidad(Int32.Parse(textBox_NuevoValor.Text));
                    label_resultados.Text = res;
                    break;
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            listView_estacionesReg.Items.Add(textBox_direccion.Text);
            comboBox_Estacion.Items.Insert(comboBox_Estacion.Items.Count, textBox_direccion.Text);
        }

        private void conectar_button_Click(object sender, EventArgs e)
        {
            string url_servicio = "http://" + textBox_direccion.Text + "/EstacionMeteoService/services/EstacionMeteo?wsdl";
            maquina_seleccionada.Url = url_servicio;
        }

        private void listView_estacionesReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            maquina_seleccionada.Url = "http://" + listView_estacionesReg.SelectedItems[0].Text + "/EstacionMeteoService/services/EstacionMeteo?wsdl"; ;
        }
    }
}

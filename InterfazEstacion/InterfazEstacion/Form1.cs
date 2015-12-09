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
using System.Net;
using System.Net.Sockets;

namespace InterfazEstacion
{
    public partial class Form1 : Form
    {

        EstMeteo.EstacionMeteo maquina_seleccionada;
        String usuario;
        String IP;

        public Form1(String nUsuario)
        {
            InitializeComponent();
            usuario = nUsuario;
            IP=Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                int res=0;
                switch (comboBox_Atributo.Text)
                {
                    case "Temperatura":
                        res = maquina_seleccionada.getTemperatura();
                        label_resultados.Text = "Temperatura="+res;
                        break;
                    case "Humedad":
                        res = maquina_seleccionada.getHumedad();
                        label_resultados.Text = "Humedad="+res;
                        break;
                    case "Luminosidad":
                        res = maquina_seleccionada.getLuminosidad();
                        label_resultados.Text = "Luminosidad="+res;
                        break;
                    case "Pantalla":
                        label_resultados.Text = "Pantalla=" + maquina_seleccionada.getPantalla();
                        break;
                }
               actualiza_log(false);
            }
            catch(WebException)
            {
                System.Windows.Forms.MessageBox.Show("Error: servicio innaccesible");
            }
            catch(NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
            }
        }



        private void button_Modificar_Click(object sender, EventArgs e)
        {
            try
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
                    case "Pantalla":
                        res = maquina_seleccionada.setMsg(textBox_NuevoValor.Text);
                        label_resultados.Text = res;
                        break;
                }
                actualiza_log(true);
            }
            catch (WebException)
            {
                System.Windows.Forms.MessageBox.Show("Error: servicio innaccesible");
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Error: parametro de entrada incorrecto o vacío");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            listView_estacionesReg.Items.Add(textBox_direccion.Text);
            comboBox_Estacion.Items.Insert(comboBox_Estacion.Items.Count, textBox_direccion.Text);
        }

        private void conectar_acciones_Click(object sender, EventArgs e)
        {
            try
            {
                maquina_seleccionada = new EstMeteo.EstacionMeteo();
                string url_servicio = "http://" + comboBox_Estacion.Text + "/EstacionMeteoService/services/EstacionMeteo?wsdl";
                maquina_seleccionada.Url = url_servicio;
                WebRequest request = WebRequest.Create(url_servicio);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                maquina_seleccionada.Url = url_servicio;
            }
            catch (WebException)
            {
                System.Windows.Forms.MessageBox.Show("Error: servicio innaccesible o no existente");
            }
            catch (UriFormatException)
            {
                System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
            }
        }
        private void actualiza_log(bool escritura)
        {
            
            String entrada = "";
            String fecha=DateTime.Now.ToString();
            String nombre=usuario+"_log_"+fecha+".txt";
            StreamWriter archivo;

            if (!File.Exists("prueba2.txt"))
            {
                String s = "[" + fecha + "] " + usuario + "@" + IP;
                archivo=File.CreateText("prueba2.txt");
                archivo.WriteLine(s, true);
                archivo.WriteLine("-------------------------------------------------------------------------", true);
            }
            else archivo = new StreamWriter("prueba2.txt",true);
            if(!escritura)
            {
                entrada = "[" + fecha + "] " + usuario + "@" + IP + "|| " + "get |" + comboBox_Atributo.Text;
            }
            else
            {
                entrada = "[" + fecha + "] " + usuario + "@" + IP + "|| " + "set |" + comboBox_Atributo.Text+"->"+textBox_NuevoValor.Text;
            }
            archivo.WriteLine(entrada,true);
            archivo.Close();

        }
    }
}

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
using System.Security.Cryptography;



namespace InterfazEstacion
{
    public partial class Form1 : Form
    {

        EstMeteo.EstacionMeteo maquina_seleccionada;
        String usuario;
        String IP;
        bool Sesion;
        Dictionary<String, String> estaciones;

        public Form1(String nUsuario)
        {
            InitializeComponent();
            usuario = nUsuario;
            IP=Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
            Sesion = true;
            estaciones=new Dictionary<string,string>();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                String res="";
                switch (comboBox_Atributo.Text)
                {
                    case "Temperatura":
                        res = maquina_seleccionada.getTemperatura(usuario,IP).ToString();
                        label_resultados.Text = "Temperatura="+res;
                        break;
                    case "Humedad":
                        res = maquina_seleccionada.getHumedad(usuario, IP).ToString();
                        label_resultados.Text = "Humedad="+res;
                        break;
                    case "Luminosidad":
                        res = maquina_seleccionada.getLuminosidad(usuario, IP).ToString();
                        label_resultados.Text = "Luminosidad="+res;
                        break;
                    case "Pantalla":
                        label_resultados.Text = "Pantalla=" + maquina_seleccionada.getPantalla(usuario, IP);
                        break;
                }
                if (Sesion)
                {
                    actualiza_log(false,Sesion);
                    Sesion = false;
                }
                else actualiza_log(false, Sesion);
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
                        res = maquina_seleccionada.setTemperatura(Int32.Parse(textBox_NuevoValor.Text), usuario, IP);
                        label_resultados.Text = res;
                        break;
                    case "Humedad":
                        res = maquina_seleccionada.setHumedad(Int32.Parse(textBox_NuevoValor.Text), usuario, IP);
                        label_resultados.Text = res;
                        break;
                    case "Luminosidad":
                        res = maquina_seleccionada.setLuminosidad(Int32.Parse(textBox_NuevoValor.Text), usuario, IP);
                        label_resultados.Text = res;
                        break;
                    case "Pantalla":
                        res = maquina_seleccionada.setMsg(textBox_NuevoValor.Text, usuario, IP);
                        label_resultados.Text = res;
                        break;
                }
                if (Sesion)
                {
                    actualiza_log(true, Sesion);
                    Sesion = false;
                }
                else actualiza_log(true, Sesion);
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
            String est="estacion"+(listView_estacionesReg.Items.Count+1);
            listView_estacionesReg.Items.Add("estacion"+(listView_estacionesReg.Items.Count+1)+"->"+textBox_direccion.Text);
            estaciones.Add(est, textBox_direccion.Text.ToString());
            comboBox_Estacion.Items.Insert(comboBox_Estacion.Items.Count, est);
        }

        private void conectar_acciones_Click(object sender, EventArgs e)
        {
            try
            {
                string estacion;
                estaciones.TryGetValue(comboBox_Estacion.Text, out estacion);
                maquina_seleccionada = new EstMeteo.EstacionMeteo();
                string url_servicio = "http://" + estacion + "/EstacionMeteoService/services/EstacionMeteo?wsdl";
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

        private void actualiza_log(bool escritura,bool Sesion)
        {
            
            String entrada = "";
            String fecha=DateTime.Now.ToString();
            StreamWriter archivo;

            if (!File.Exists("log.txt"))
            {
                archivo=File.CreateText("log.txt");
            }
            else archivo = new StreamWriter("log.txt",true);

            if (Sesion)
            {
                String s = "[" + fecha + "] " + usuario + "@" + IP;
                archivo.WriteLine("-------------------------------------------------------------------------", true);
                archivo.WriteLine(s, true);
                archivo.WriteLine("-------------------------------------------------------------------------", true);
                s = "";
                Sesion = false;
            }
            if(!escritura)
            {
                entrada = "[" + fecha + "] " + usuario + "@" + IP + "|| "+ comboBox_Estacion.Text + " |get| " + comboBox_Atributo.Text;
            }
            else
            {
                entrada = "[" + fecha + "] " + usuario + "@" + IP + "|| " +comboBox_Estacion.Text+" |set| " + comboBox_Atributo.Text+"->"+textBox_NuevoValor.Text;
            }
            archivo.WriteLine(entrada,true);
            archivo.Close();

        }
        public static string MD5Encrypt(string value)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();

            byte[] data = System.Text.Encoding.ASCII.GetBytes(value);
            data = provider.ComputeHash(data);

            string md5 = string.Empty;

            for (int i = 0; i < data.Length; i++)
                md5 += data[i].ToString("x2").ToLower();

            return md5;
        }  
    }
}

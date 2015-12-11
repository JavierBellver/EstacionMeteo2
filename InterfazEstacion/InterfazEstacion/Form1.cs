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
        string log_name;
        Dictionary<String, String> estaciones;

        public Form1(String nUsuario)
        {
            InitializeComponent();
            usuario = nUsuario;
            IP=Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
            estaciones=new Dictionary<string,string>();
            this.FormClosed += new FormClosedEventHandler(f_FormClosed);
            log_name = "log" + DateTime.Now.Hour+"_"+ DateTime.Now.Minute+"_"+DateTime.Now.Second+ ".txt";
            inicializa_log();
        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            finaliza_log();
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
                    default:
                        String error = "Error: debe especificar un servicio";
                        System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
                        error_log(error);
                        break;
                }
                actualiza_log(false);
            }
            catch(WebException)
            {
                String error = "Error: servicio innaccesible";
                System.Windows.Forms.MessageBox.Show(error);
                error_log(error);
            }
            catch(NullReferenceException)
            {
                String error = "Error: debe especificar un servicio";
                System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
                error_log(error);
            }
            catch(Exception)
            {
                String error = "Error: problema no especificado";
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
                error_log(error);
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
                    default:
                        String error = "Error: debe especificar un servicio";
                        System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
                        error_log(error);
                        break;
                }
                actualiza_log(true);
            }
            catch (WebException)
            {
                String error = "Error: servicio innaccesible";
                System.Windows.Forms.MessageBox.Show(error);
                error_log(error);
            }
            catch (NullReferenceException)
            {
                String error = "Error: debe especificar un servicio";
                System.Windows.Forms.MessageBox.Show("Error: debe especificar un servicio");
                error_log(error);
            }
            catch (FormatException)
            {
                String error = "Error: parametro de entrada incorrecto o vacío";
                System.Windows.Forms.MessageBox.Show("Error: parametro de entrada incorrecto o vacío");
                error_log(error);
            }
            catch (Exception)
            {
                String error = "Error: problema no especificado";
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
                error_log(error);
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
                String error = "Error: servicio innaccesible o no existente";
                System.Windows.Forms.MessageBox.Show(error);
                error_log(error);
            }
            catch (UriFormatException)
            {
                String error = "Error: ruta de recurso invalida";
                System.Windows.Forms.MessageBox.Show(error);
                error_log(error);
            }
            catch (Exception)
            {
                String error = "Error: problema no especificado";
                System.Windows.Forms.MessageBox.Show("Error: Error no identificado");
                error_log(error);
            }
        }

        private void actualiza_log(bool escritura)
        {
            String entrada = "";
            String fecha=DateTime.Now.ToString();
            StreamWriter archivo;

            if (!File.Exists(log_name))
            {
                inicializa_log();
                archivo = new StreamWriter(log_name, true);
            }
            else
            {
                archivo = new StreamWriter(log_name, true);
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

        private void inicializa_log()
        {
            StreamWriter archivo;
            String fecha = DateTime.Now.ToString();
            if (!File.Exists(log_name))
            {
                archivo = File.CreateText(log_name);
            }
            else
            {
                archivo = new StreamWriter(log_name, true);
            }
            String s = "Inicio de Sesion:" + "[" + fecha + "] " + usuario + "@" + IP;
            archivo.WriteLine("-------------------------------------------------------------------------", true);
            archivo.WriteLine(s, true);
            archivo.WriteLine("-------------------------------------------------------------------------", true);
            archivo.Close();
        }

        private void finaliza_log()
        {
            StreamWriter archivo;
            String fecha = DateTime.Now.ToString();
            if (!File.Exists(log_name))
            {
                archivo = File.CreateText(log_name);
            }
            else
            {
                archivo = new StreamWriter(log_name, true);
            }
            String s = "Finalización de Sesion:" + "[" + fecha + "] " + usuario + "@" + IP;
            archivo.WriteLine("-------------------------------------------------------------------------", true);
            archivo.WriteLine(s, true);
            archivo.WriteLine("-------------------------------------------------------------------------", true);
            archivo.Close();
        }

        private void error_log(String error)
        {
            StreamWriter archivo;
            String fecha = DateTime.Now.ToString();
            if (!File.Exists(log_name))
            {
                inicializa_log();
                archivo = new StreamWriter(log_name, true);
            }
            else
            {
                archivo = new StreamWriter(log_name, true);
            }
            String s = error + "[" + fecha + "] " + usuario + "@" + IP;
            archivo.WriteLine(s, true);
            archivo.Close();
        }
    }
}

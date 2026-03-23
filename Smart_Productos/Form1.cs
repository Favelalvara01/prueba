using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Smart_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            SmartTV tv = new SmartTV();
            tv.Marca = "Samsung";
            tv.Resolucion = "4K";
            tv.Tamaño_Pantalla = 55;
            tv.Precio = 1200;

            txtResultado.Text = "** Smart TV **\r\n" +
                                "   Marca:    " + tv.Marca + "\r\n" +
                                "   Resol:    " + tv.Resolucion + "\r\n" +
                                "   Pantalla: " + tv.Tamaño_Pantalla + "\"\r\n" +
                                "   " + tv.MostrarPrecio() + "\r\n" +
                                "   " + Producto.FormatearPrecio(tv.Precio) + "\r\n\r\n" +
                                tv.Cambiar_Canal() + "\r\n" +
                                tv.Abrir_App() + "\r\n" +
                                tv.Conectar_Servicio("Netflix") + "\r\n\r\n" +
                                ">> " + tv.ObtenerInfo();
        }

        private void btnPeakers_Click(object sender, EventArgs e)
        {
            SmartSpeaker speaker = new SmartSpeaker();
            speaker.Marca = "Bose";
            speaker.Asistente_voz = "Alexa";
            speaker.Potencia_sonido = 100;
            speaker.Precio = 250;

            txtResultado.Text = "** Smart Speaker **\r\n" +
                                "   Marca:     " + speaker.Marca + "\r\n" +
                                "   Asistente: " + speaker.Asistente_voz + "\r\n" +
                                "   Potencia:  " + speaker.Potencia_sonido + "W\r\n" +
                                "   " + speaker.MostrarPrecio() + "\r\n\r\n" +
                                speaker.Reproducir_Musica() + "\r\n" +
                                speaker.Reproducir_Cancion("Bohemian Rhapsody") + "\r\n" +
                                speaker.Detener_Audio() + "\r\n\r\n" +
                                ">> " + speaker.ObtenerInfo();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            SmartWatch watch = new SmartWatch();
            watch.Marca = "Apple";
            watch.Precio = 400;
            watch.Sensor_Ritmo = true;
            watch.Autonomia_Bateria = 18;

            txtResultado.Text = "** Smart Watch **\r\n" +
                                "   Marca:    " + watch.Marca + "\r\n" +
                                "   Batería:  " + watch.Autonomia_Bateria + "h\r\n" +
                                "   " + watch.MostrarPrecio() + "\r\n\r\n" +
                                watch.Monitorear_Pasos() + "\r\n" +
                                watch.Medir_Ritmo() + "\r\n" +
                                watch.Configurar_Alarma("07:30") + "\r\n\r\n" +
                                ">> " + watch.ObtenerInfo();
        }

        private void btnLigth_Click(object sender, EventArgs e)
        {
            SmartLight light = new SmartLight();
            light.Marca = "Philips";
            light.Tipo_Conector = "USB-C";
            light.Color_Rgb = true;
            light.Precio = 50;

            txtResultado.Text = "** Smart Light **\r\n" +
                                "   Marca:     " + light.Marca + "\r\n" +
                                "   Conector:  " + light.Tipo_Conector + "\r\n" +
                                "   " + light.MostrarPrecio() + "\r\n\r\n" +
                                light.Conectar_Bluetooth() + "\r\n" +
                                light.Regular_Intensidad() + "\r\n" +
                                light.AjustarBrillo(75) + "\r\n\r\n" +
                                ">> " + light.ObtenerInfo();
        }

        // Polimorfismo — recorre todos los productos con ObtenerInfo()
        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            List<Producto> catalogo = new List<Producto>();

            catalogo.Add(new SmartTV { Marca = "Samsung", Resolucion = "4K", Tamaño_Pantalla = 55, Precio = 1200 });
            catalogo.Add(new SmartSpeaker { Marca = "Bose", Asistente_voz = "Alexa", Potencia_sonido = 100, Precio = 250 });
            catalogo.Add(new SmartWatch { Marca = "Apple", Sensor_Ritmo = true, Autonomia_Bateria = 18, Precio = 400 });
            catalogo.Add(new SmartLight { Marca = "Philips", Tipo_Conector = "USB-C", Color_Rgb = true, Precio = 50 });

            txtResultado.Text = "** CATÁLOGO COMPLETO (Polimorfismo) **\r\n\r\n";

            foreach (Producto prod in catalogo)
            {
                txtResultado.Text += prod.ObtenerInfo() + "\r\n";
                txtResultado.Text += prod.MostrarPrecio() + "\r\n\r\n";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
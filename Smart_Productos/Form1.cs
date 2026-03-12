using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Productos tv = new Productos();
            tv.Marca = "Samsung";
            tv.Resolucion = "4K";
            tv.Tamaño_Pantalla = 55;
            tv.Precio = 1200;

            txtResultado.Text = "** Smart TV **\r\n" +
                                "   Marca:    " + tv.Marca + "\r\n" +
                                "   Resol:    " + tv.Resolucion + "\r\n" +
                                "   Pantalla: " + tv.Tamaño_Pantalla + "\"\r\n" +
                                "   Precio:   $" + tv.Precio + "\r\n\r\n" +
                                tv.Cambiar_Canal() + "\r\n" +
                                tv.Abrir_App();
        }

        private void btnPeakers_Click(object sender, EventArgs e)
        {
            Productos speaker = new Productos();
            speaker.Marca = "Bose";
            speaker.Asistente_voz = "Alexa";
            speaker.Potencia_sonido = 100;

            txtResultado.Text = "   Smart Speaker **\r\n" +
                                "   Marca:     " + speaker.Marca + "\r\n" +
                                "   Asistente: " + speaker.Asistente_voz + "\r\n" +
                                "   Potencia:  " + speaker.Potencia_sonido + "W\r\n\r\n" +
                                speaker.Reproducir_Musica() + "\r\n" +
                                speaker.Detener_Audio();
        }
        private void btnWatch_Click(object sender, EventArgs e)
        {
            Productos watch = new Productos();
            watch.Marca = "Apple";
            watch.Precio = 400;
            watch.Sensor_Ritmo = true;
            watch.Autonomia_Bateria = 18;

            txtResultado.Text = "** Smart Watch **\r\n" +
                                "   Marca:    " + watch.Marca + "\r\n" +
                                "   Precio:   $" + watch.Precio + "\r\n" +
                                "   Batería:  " + watch.Autonomia_Bateria + "h\r\n\r\n" +
                                watch.Monitorear_Pasos() + "\r\n" +
                                watch.Medir_Ritmo();
        }

        private void btnLigth_Click(object sender, EventArgs e)
        {
            Productos light = new Productos();
            light.Marca = "Philips";
            light.Tipo_Conector = "USB-C";
            light.Color_Rgb = true;
            light.Precio = 50;

            txtResultado.Text = "** Smart Light **\r\n" +
                                "   Marca:     " + light.Marca + "\r\n" +
                                "   Conector:  " + light.Tipo_Conector + "\r\n" +
                                "   Precio:    $" + light.Precio + "\r\n\r\n" +
                                light.Conectar_Bluetooth() + "\r\n" +
                                light.Regular_Intensidad();
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

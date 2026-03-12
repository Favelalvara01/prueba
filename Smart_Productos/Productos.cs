using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Productos
{
    public class Productos
    {
        // Atributos generales
        public string Marca { get; set; }
        public double Precio { get; set; }

        // Smart TV
        public string Resolucion { get; set; }
        public int Tamaño_Pantalla { get; set; }

        // Smart Speaker
        public string Asistente_voz { get; set; }
        public int Potencia_sonido { get; set; }

        // Smart Watch
        public bool Sensor_Ritmo { get; set; }
        public int Autonomia_Bateria { get; set; }

        // Smart Light
        public string Tipo_Conector { get; set; }
        public bool Color_Rgb { get; set; }
        public string Color { get; set; }

        public string Cambiar_Canal()
        {
            return $"[{Marca}] Cambiando de canal...";
        }

        public string Abrir_App()
        {
            return $"[{Marca}] Abriendo aplicación en pantalla {Tamaño_Pantalla}\"";
        }

        //Métodos Smart Speaker
        public string Reproducir_Musica()
        {
            return $"[{Marca}] Reproduciendo música a {Potencia_sonido}W con {Asistente_voz}";
        }

        public string Detener_Audio()
        {
            return $"[{Marca}] Audio detenido.";
        }

        // Métodos Smart Watch
        public string Monitorear_Pasos()
        {
            return $"[{Marca}] Monitoreando pasos... Batería: {Autonomia_Bateria}h";
        }

        public string Medir_Ritmo()
        {
            string estado = Sensor_Ritmo ? "activo" : "inactivo";
            return $"[{Marca}] Sensor de ritmo cardíaco {estado}.";
        }

        //Métodos Smart Light 
        public string Conectar_Bluetooth()
        {
            return $"[{Marca}] Conectando vía Bluetooth ({Tipo_Conector})...";
        }

        public string Regular_Intensidad()
        {
            string rgb = Color_Rgb ? "RGB activado" : "RGB desactivado";
            return $"[{Marca}] Regulando intensidad - {rgb}";
        }

    }
}

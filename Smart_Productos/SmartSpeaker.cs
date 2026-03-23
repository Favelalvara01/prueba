namespace Smart_Productos
{
    public class SmartSpeaker : Producto
    {
        public string Asistente_voz { get; set; }
        public int Potencia_sonido { get; set; }

        public override string ObtenerInfo()
        {
            return $"Smart Speaker {Marca} — {Asistente_voz} — {Potencia_sonido}W";
        }

        public string Reproducir_Musica()
        {
            return $"[{Marca}] Reproduciendo música a {Potencia_sonido}W con {Asistente_voz}";
        }

        // Método con parámetro (Punto 5)
        public string Reproducir_Cancion(string cancion)
        {
            return $"[{Marca}] Reproduciendo: {cancion} a {Potencia_sonido}W";
        }

        public string Detener_Audio()
        {
            return $"[{Marca}] Audio detenido.";
        }
    }
}
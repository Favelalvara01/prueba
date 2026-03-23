namespace Smart_Productos
{
    public class SmartWatch : Producto
    {
        public bool Sensor_Ritmo { get; set; }
        public int Autonomia_Bateria { get; set; }

        public override string ObtenerInfo()
        {
            return $"Smart Watch {Marca} — Batería: {Autonomia_Bateria}h";
        }

        // Override con base (polimorfismo)
        public override string MostrarPrecio()
        {
            return base.MostrarPrecio() + " (incluye 1 año de garantía)";
        }

        public string Monitorear_Pasos()
        {
            return $"[{Marca}] Monitoreando pasos... Batería: {Autonomia_Bateria}h";
        }

        public string Medir_Ritmo()
        {
            string estado = Sensor_Ritmo ? "activo" : "inactivo";
            return $"[{Marca}] Sensor de ritmo cardíaco {estado}.";
        }

        // Método con parámetro (Punto 5)
        public string Configurar_Alarma(string hora)
        {
            return $"[{Marca}] Alarma configurada para las {hora}";
        }
    }
}
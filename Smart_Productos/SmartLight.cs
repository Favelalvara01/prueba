namespace Smart_Productos
{
    public class SmartLight : Producto
    {
        public string Tipo_Conector { get; set; }
        public bool Color_Rgb { get; set; }
        public string Color { get; set; }

        public override string ObtenerInfo()
        {
            string rgb = Color_Rgb ? "RGB activo" : "RGB inactivo";
            return $"Smart Light {Marca} — {Tipo_Conector} — {rgb}";
        }

        public string Conectar_Bluetooth()
        {
            return $"[{Marca}] Conectando vía Bluetooth ({Tipo_Conector})...";
        }

        public string Regular_Intensidad()
        {
            string rgb = Color_Rgb ? "RGB activado" : "RGB desactivado";
            return $"[{Marca}] Regulando intensidad - {rgb}";
        }

        // Método con parámetro (Punto 5)
        public string AjustarBrillo(int porcentaje)
        {
            return $"[{Marca}] Brillo ajustado al {porcentaje}% ({Tipo_Conector})";
        }
    }
}
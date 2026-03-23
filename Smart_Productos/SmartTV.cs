namespace Smart_Productos
{
    public class SmartTV : Producto
    {
        private int _tamañoPantalla;

        public string Resolucion { get; set; }

        public int Tamaño_Pantalla
        {
            get { return _tamañoPantalla; }
            set { _tamañoPantalla = (value >= 20 && value <= 100) ? value : 32; }
        }

        // Override — polimorfismo (Punto 12)
        public override string ObtenerInfo()
        {
            return $"Smart TV {Marca} — {Resolucion} — {Tamaño_Pantalla}\"";
        }

        // Métodos simples (Punto 4)
        public string Cambiar_Canal()
        {
            return $"[{Marca}] Cambiando de canal...";
        }

        // Método con parámetro (Punto 5)
        public string Conectar_Servicio(string nombreServicio)
        {
            return $"[{Marca}] Conectando a {nombreServicio} en {Tamaño_Pantalla}\"";
        }

        public string Abrir_App()
        {
            return $"[{Marca}] Abriendo aplicación en pantalla {Tamaño_Pantalla}\"";
        }
    }
}
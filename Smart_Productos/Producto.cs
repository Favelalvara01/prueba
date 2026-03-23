using System;
using System.Collections.Generic;

namespace Smart_Productos
{
    public abstract class Producto
    {
        // Atributos privados (encapsulamiento)
        private string _marca;
        private double _precio;

        // Propiedad Marca con validación
        public string Marca
        {
            get { return _marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _marca = value;
                else
                    _marca = "Marca desconocida";
            }
        }

        // Propiedad Precio con validación
        public double Precio
        {
            get { return _precio; }
            set
            {
                if (value > 0)
                    _precio = value;
            }
        }

        // Método abstracto — cada subclase DEBE implementarlo (polimorfismo)
        public abstract string ObtenerInfo();

        // Método virtual — puede ser sobreescrito
        public virtual string MostrarPrecio()
        {
            return $"[{_marca}] Precio: ${_precio:F2}";
        }

        // Función con parámetro (Punto 3)
        public static string FormatearPrecio(double precio)
        {
            return $"Precio sugerido: ${precio:F2} MXN";
        }
    }
}
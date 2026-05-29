using System;

namespace TattoStudio.Modelo
{
    // ============================================================
    // CLASE BASE: Persona
    // Esta clase es la "madre" de Cliente y Tatuador.
    // Contiene los atributos que AMBOS tienen en común.
    // Concepto POO aplicado: HERENCIA (clase padre)
    // ============================================================
    public class Persona
    {
        // --- Atributos privados (encapsulamiento) ---
        // Solo se pueden leer/modificar mediante las propiedades de abajo.
        private string _nombre;
        private string _id;
        private string _telefono;

        // --- Propiedades públicas (encapsulamiento) ---
        // Permiten leer y escribir los atributos con validaciones.

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID no puede estar vacío.");
                _id = value.Trim();
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono no puede estar vacío.");
                _telefono = value.Trim();
            }
        }

        // --- Constructor ---
        // Se ejecuta cuando se crea un objeto nuevo con "new Persona(...)"
        public Persona(string nombre, string id, string telefono)
        {
            Nombre    = nombre;
            Id        = id;
            Telefono  = telefono;
        }

        // --- Método virtual ---
        // "virtual" significa que las subclases (Cliente, Tatuador) pueden
        // sobreescribir (override) este método con su propio comportamiento.
        // Concepto POO aplicado: POLIMORFISMO
        public virtual string ObtenerResumen()
        {
            return $"Nombre: {Nombre} | ID: {Id} | Teléfono: {Telefono}";
        }

        // ToString() se usa automáticamente cuando se muestra el objeto en listas.
        public override string ToString()
        {
            return $"{Nombre} (ID: {Id})";
        }
    }
}

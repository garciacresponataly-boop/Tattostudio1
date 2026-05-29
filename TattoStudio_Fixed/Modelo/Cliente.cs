using System;

namespace TattoStudio.Modelo
{
    // ============================================================
    // ENUMERACIÓN: TipoTatuaje
    // Un "enum" es una lista de opciones fijas. Así evitamos
    // escribir strings libres como "realista" o "Realista" y
    // cometemos menos errores.
    // ============================================================
    public enum TipoTatuaje
    {
        Realista,
        Anime,
        Blackout,
        Acuarela,
        Tradicional,
        Geometrico,
        MiniTatuaje
    }

    // ============================================================
    // CLASE: Cliente  (hereda de Persona)
    // Un Cliente ES una Persona, pero además tiene su propio
    // atributo: el tipo de tatuaje que desea.
    // Concepto POO aplicado: HERENCIA y POLIMORFISMO
    // ============================================================
    public class Cliente : Persona
    {
        // Atributo propio del Cliente (no lo tiene Tatuador)
        private TipoTatuaje _tipoTatuajeDeseado;

        public TipoTatuaje TipoTatuajeDeseado
        {
            get { return _tipoTatuajeDeseado; }
            set { _tipoTatuajeDeseado = value; }
        }

        // Constructor del Cliente.
        // Llama al constructor del padre (Persona) con "base(...)".
        public Cliente(string nombre, string id, string telefono, TipoTatuaje tipoTatuaje)
            : base(nombre, id, telefono)
        {
            TipoTatuajeDeseado = tipoTatuaje;
        }

        // OVERRIDE: reemplaza el método de Persona con información del Cliente.
        // Concepto POO aplicado: POLIMORFISMO (override)
        public override string ObtenerResumen()
        {
            // Llamamos primero al resumen del padre y le agregamos más info.
            return base.ObtenerResumen() + $" | Tipo de tatuaje: {TipoTatuajeDeseado}";
        }
    }
}

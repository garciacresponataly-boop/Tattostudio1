using System;

namespace TattoStudio.Modelo
{
    // ============================================================
    // CLASE: Tatuador  (hereda de Persona)
    // Un Tatuador ES una Persona, pero además tiene su propio
    // atributo: el estilo en el que se especializa.
    // Concepto POO aplicado: HERENCIA y POLIMORFISMO
    // ============================================================
    public class Tatuador : Persona
    {
        // Atributo propio del Tatuador (no lo tiene Cliente)
        private TipoTatuaje _especialidad;

        public TipoTatuaje Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        // Constructor del Tatuador.
        // Llama al constructor del padre (Persona) con "base(...)".
        public Tatuador(string nombre, string id, string telefono, TipoTatuaje especialidad)
            : base(nombre, id, telefono)
        {
            Especialidad = especialidad;
        }

        // OVERRIDE: versión propia del método ObtenerResumen().
        // Concepto POO aplicado: POLIMORFISMO (override)
        public override string ObtenerResumen()
        {
            return base.ObtenerResumen() + $" | Especialidad: {Especialidad}";
        }
    }
}

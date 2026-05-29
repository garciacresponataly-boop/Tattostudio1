using System;
using System.Collections.Generic;
using TattoStudio.Modelo;

namespace TattoStudio.Servicios
{
    // ============================================================
    // CLASE: GestorTatuadores
    // Igual que GestorClientes pero para los tatuadores.
    // Nótese la similitud: ambos gestionan listas de Persona,
    // lo que podría refactorizarse con genéricos en el futuro.
    // ============================================================
    public class GestorTatuadores
    {
        private List<Tatuador> _tatuadores;

        public GestorTatuadores()
        {
            _tatuadores = new List<Tatuador>();
        }

        // --- Agregar tatuador ---
        public void AgregarTatuador(Tatuador tatuador)
        {
            if (tatuador == null)
                throw new ArgumentNullException("El tatuador no puede ser nulo.");

            if (ExisteId(tatuador.Id))
                throw new InvalidOperationException($"Ya existe un tatuador con el ID '{tatuador.Id}'.");

            _tatuadores.Add(tatuador);
        }

        // --- Obtener todos ---
        public List<Tatuador> ObtenerTodos()
        {
            return new List<Tatuador>(_tatuadores);
        }

        // --- Buscar por ID ---
        public Tatuador BuscarPorId(string id)
        {
            foreach (Tatuador t in _tatuadores)
            {
                if (t.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                    return t;
            }
            return null;
        }

        // --- Eliminar por ID ---
        public bool EliminarPorId(string id)
        {
            Tatuador encontrado = BuscarPorId(id);
            if (encontrado != null)
            {
                _tatuadores.Remove(encontrado);
                return true;
            }
            return false;
        }

        // --- Total de tatuadores ---
        public int ObtenerTotal()
        {
            return _tatuadores.Count;
        }

        private bool ExisteId(string id)
        {
            return BuscarPorId(id) != null;
        }
    }
}

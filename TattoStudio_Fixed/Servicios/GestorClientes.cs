using System;
using System.Collections.Generic;
using TattoStudio.Modelo;

namespace TattoStudio.Servicios
{
    // ============================================================
    // CLASE: GestorClientes
    // Contiene TODA la lógica relacionada con los clientes.
    // Los formularios (Vista) no deben hacer estas operaciones
    // directamente; deben llamar a este servicio.
    // Concepto aplicado: MODULARIDAD / SEPARACIÓN DE RESPONSABILIDADES
    // ============================================================
    public class GestorClientes
    {
        // Lista en memoria donde se guardan todos los clientes registrados.
        // List<Cliente> es una estructura de datos genérica (como un arreglo flexible).
        private List<Cliente> _clientes;

        // Constructor: inicializa la lista vacía al crear el gestor.
        public GestorClientes()
        {
            _clientes = new List<Cliente>();
        }

        // --- OPERACIÓN: Agregar un cliente nuevo ---
        // Recibe un objeto Cliente ya creado y lo agrega a la lista.
        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException("El cliente no puede ser nulo.");

            // Verificar que no exista ya un cliente con el mismo ID
            if (ExisteId(cliente.Id))
                throw new InvalidOperationException($"Ya existe un cliente con el ID '{cliente.Id}'.");

            _clientes.Add(cliente);
        }

        // --- OPERACIÓN: Obtener todos los clientes ---
        // Devuelve una copia de la lista para que nadie la modifique directamente.
        public List<Cliente> ObtenerTodos()
        {
            return new List<Cliente>(_clientes);
        }

        // --- OPERACIÓN: Buscar cliente por ID ---
        // Recorre la lista y devuelve el cliente si lo encuentra, o null si no.
        public Cliente BuscarPorId(string id)
        {
            foreach (Cliente c in _clientes)
            {
                if (c.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                    return c;
            }
            return null; // No encontrado
        }

        // --- OPERACIÓN: Eliminar cliente por ID ---
        // Devuelve true si se eliminó, false si no existía.
        public bool EliminarPorId(string id)
        {
            Cliente encontrado = BuscarPorId(id);
            if (encontrado != null)
            {
                _clientes.Remove(encontrado);
                return true;
            }
            return false;
        }

        // --- OPERACIÓN: Total de clientes registrados ---
        public int ObtenerTotal()
        {
            return _clientes.Count;
        }

        // --- Método auxiliar privado ---
        // Solo lo usa esta clase internamente.
        private bool ExisteId(string id)
        {
            return BuscarPorId(id) != null;
        }
    }
}

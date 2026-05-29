using System;
using System.Text.RegularExpressions;

namespace TattoStudio.Utilidades
{
    // ============================================================
    // CLASE: Validador
    // Agrupa todas las validaciones del sistema en un solo lugar.
    // Así no repetimos el mismo código en varios formularios.
    // Concepto aplicado: REUTILIZACIÓN / MODULARIDAD
    // ============================================================
    public static class Validador
    {
        // --- Valida que un texto no esté vacío ---
        // Devuelve true si el campo tiene contenido, false si está vacío.
        public static bool EsTextoValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        // --- Valida que un teléfono tenga entre 7 y 15 dígitos ---
        public static bool EsTelefonoValido(string telefono)
        {
            if (!EsTextoValido(telefono)) return false;
            // Regex: solo dígitos, opcionalmente con '+' al inicio
            return Regex.IsMatch(telefono.Trim(), @"^\+?\d{7,15}$");
        }

        // --- Valida que un ID no tenga caracteres raros ---
        // Permite letras, números, guiones y guiones bajos.
        public static bool EsIdValido(string id)
        {
            if (!EsTextoValido(id)) return false;
            return Regex.IsMatch(id.Trim(), @"^[a-zA-Z0-9\-_]{1,20}$");
        }

        // --- Verifica todos los campos del formulario de persona ---
        // Devuelve un mensaje de error, o string vacío si todo está bien.
        public static string ValidarCamposPersona(string nombre, string id, string telefono)
        {
            if (!EsTextoValido(nombre))
                return "El nombre es obligatorio.";

            if (!EsTextoValido(id))
                return "El ID es obligatorio.";

            if (!EsIdValido(id))
                return "El ID solo puede tener letras, números, guiones o guiones bajos (máx. 20 caracteres).";

            if (!EsTextoValido(telefono))
                return "El teléfono es obligatorio.";

            if (!EsTelefonoValido(telefono))
                return "El teléfono debe tener entre 7 y 15 dígitos numéricos.";

            return string.Empty; // Todo válido
        }
    }
}

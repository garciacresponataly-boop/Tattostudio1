# 🎨 TattoStudio - Gestión de Estudio de Tatuajes

[![.NET Version](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green.svg)](https://learn.microsoft.com/es-es/dotnet/csharp/)

**TattoStudio** es una aplicación de escritorio desarrollada en **C#** y **.NET 8.0** utilizando **Windows Forms**. Su objetivo principal es facilitar la gestión interna de un estudio de tatuajes, permitiendo la administración (registro, consulta y eliminación) de clientes y tatuadores.

---

## 📌 Características Principales

*   **Registro de Clientes:** Permite registrar nombre, identificación (ID), teléfono y el tipo de tatuaje que el cliente desea.
*   **Registro de Tatuadores:** Permite registrar nombre, identificación (ID), teléfono y la especialidad o estilo de tatuaje que domina.
*   **Validaciones en Tiempo Real:** Validación automática de campos vacíos, IDs (letras, números, guiones) y teléfonos (entre 7 y 15 dígitos con expresión regular).
*   **Arquitectura Limpia:** Separación estricta de responsabilidades (UI, Lógica de Negocio, Modelos y Utilidades).
*   **Seguridad en Operaciones:** Confirmaciones gráficas antes de eliminar registros e impedimento de registros duplicados por ID.

---

## 🛠️ Arquitectura del Proyecto

El proyecto sigue una estructura modular que separa la interfaz gráfica de la lógica de negocio y los datos, facilitando el mantenimiento y la escalabilidad del sistema:

```
TattoStudio_Fixed/
├── TattoStudio.sln                              # Archivo de solución de Visual Studio
└── TattoStudio_Fixed/                           # Carpeta principal del código fuente
    ├── Program.cs                               # Punto de entrada de la aplicación
    ├── TattoStudio.csproj.user                  # Configuraciones locales de Visual Studio
    ├── Modelo/                                  # Definición de Entidades (Datos)
    │   ├── Persona.cs                           # Clase base (padre)
    │   ├── Cliente.cs                           # Subclase cliente (hereda de Persona)
    │   └── Tatuador.cs                          # Subclase tatuador (hereda de Persona)
    ├── Servicios/                               # Lógica de Negocio (Controladores en memoria)
    │   ├── GestorClientes.cs                    # Lógica y almacenamiento de clientes
    │   ├── GestorTatuadores.cs                  # Lógica y almacenamiento de tatuadores
    │   └── TattoStudio.csproj                   # Archivo de configuración del proyecto C# (NET 8.0)
    ├── Vista/                                   # Interfaz Gráfica de Usuario (Forms)
    │   ├── FormPrincipal.cs                     # Menú principal y visualización rápida
    │   ├── FormRegistroCliente.cs               # Formulario de gestión de clientes
    │   └── FormRegistroTatuador.cs              # Formulario de gestión de tatuadores
    └── Utilidades/                              # Clases de soporte común
        └── Validador.cs                         # Validaciones de formato (Regex)
```

---

## 💡 Conceptos de Programación Orientada a Objetos (POO) Aplicados

Este proyecto fue diseñado con un fuerte enfoque educativo para ilustrar los pilares fundamentales de la **POO**:

1.  **Herencia:**
    *   Existe una clase base llamada `Persona` que agrupa los atributos comunes: `Nombre`, `Id` y `Telefono`.
    *   Las clases `Cliente` y `Tatuador` heredan de `Persona` mediante la sintaxis `: Persona`.
2.  **Encapsulamiento:**
    *   Todos los atributos en las clases del modelo son privados (`private string _nombre`, etc.).
    *   El acceso y modificación de estos atributos se realiza de manera controlada a través de propiedades públicas con validación integrada (`get` y `set`), asegurando que no se asignen datos inválidos.
3.  **Polimorfismo:**
    *   La clase `Persona` define un método virtual `ObtenerResumen()`.
    *   Tanto `Cliente` como `Tatuador` sobrescriben este método (`public override string ObtenerResumen()`) para retornar información específica de su rol (tipo de tatuaje deseado o especialidad artística, respectivamente).
4.  **Abstracción:**
    *   Representación fiel en el código de objetos reales (clientes, tatuadores) con sus características específicas del negocio de tatuajes.

---

## 🔍 Detalles Técnicos Importantes

### 1. Validación de Formatos
La clase [Validador.cs](file:///C:/Users/garci/Downloads/TattoStudio_Fixed/TattoStudio_Fixed/Utilidades/Validador.cs) utiliza **Expresiones Regulares (Regex)** para garantizar la integridad de los datos ingresados por el usuario:
*   **ID Válido:** Permite caracteres alfanuméricos, guiones y guiones bajos (máximo 20 caracteres):
    `^[a-zA-Z0-9\-_]{1,20}$`
*   **Teléfono Válido:** Permite dígitos numéricos (entre 7 y 15) con un prefijo opcional `+`:
    `^\+?\d{7,15}$`

### 2. Ubicación de Archivos en el Repositorio
*   **Archivo de Proyecto:** El archivo de proyecto `TattoStudio.csproj` se encuentra ubicado actualmente dentro de la carpeta `Servicios/`. Si deseas abrir el proyecto desde la solución raíz (`TattoStudio.sln`) usando Visual Studio, la solución buscará el archivo en el directorio raíz de la app. Para solucionar esto, puedes mover el archivo `TattoStudio.csproj` al directorio raíz `TattoStudio_Fixed/`.
*   **Discrepancias de Métodos:** En `FormPrincipal.cs`, las llamadas dinámicas para actualizar la interfaz utilizan los métodos `ObtenerClientes()` y `ObtenerTatuadores()`, los cuales en las clases gestoras correspondientes (`GestorClientes` y `GestorTatuadores`) están implementados como `ObtenerTodos()`. Si necesitas que el código compile de inmediato, se sugiere renombrar el método `ObtenerTodos()` a `ObtenerClientes()` / `ObtenerTatuadores()` en sus respectivos gestores, o modificar la llamada en el formulario principal a `ObtenerTodos()`.

---

## 🚀 Requisitos del Sistema

*   **Sistema Operativo:** Windows 10 o Windows 11 (requerido para ejecutar la interfaz gráfica de *Windows Forms*).
*   **SDK de .NET:** [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior instalado.
*   **IDE Recomendado:** [Visual Studio 2022](https://visualstudio.microsoft.com/) con la carga de trabajo "Desarrollo de escritorio de .NET" activa.

---

## 🏃 Cómo Compilar y Ejecutar

Puedes compilar y ejecutar el proyecto desde la consola de comandos siguiendo estos pasos:

1. Abre tu terminal de preferencia (PowerShell, CMD, Git Bash).
2. Dirígete a la carpeta raíz del código fuente donde está el archivo `.csproj`:
   ```bash
   cd C:/Users/garci/Downloads/TattoStudio_Fixed/TattoStudio_Fixed/Servicios/
   ```
3. Ejecuta el comando de ejecución de .NET:
   ```bash
   dotnet run
   ```
4. ¡Listo! La interfaz gráfica de **TattoStudio** se desplegará en tu pantalla.
# Sistema de Gestión de Buses - Proyecto Final

## Descripción

Este proyecto es un sistema de gestión de buses desarrollado en C# con arquitectura de tres capas (Modelo-Vista-Controlador). El sistema permite administrar buses, conductores, pasajeros, rutas y boletos de manera eficiente.

## Arquitectura del Proyecto

El proyecto está estructurado en tres capas principales:

### Modelo
Contiene las clases de entidad que representan los objetos del dominio:
- `Bus.cs` - Gestión de buses
- `Conductor.cs` - Información de conductores
- `Pasajero.cs` - Datos de pasajeros
- `Persona.cs` - Clase base para personas
- `Programadores.cs` - Gestión de programadores
- `Ruta.cs` - Definición de rutas
- `Boleto.cs` - Gestión de boletos

### Controlador
Maneja la lógica de negocio y la comunicación entre la vista y el modelo:
- `ControlBus.cs` - Controlador para gestión de buses
- `ControlProgramadores.cs` - Controlador para programadores

### Vista
Interfaz de usuario desarrollada con Windows Forms:
- Formularios para registro, edición, eliminación y listado de buses
- Interfaz de menú principal
- Formulario "Acerca de"

### Datos
Capa de acceso a datos:
- `Conexion.cs` - Configuración de conexión a base de datos
- `DatosBus.cs` - Operaciones de datos para buses
- `DatosProgramadores.cs` - Operaciones de datos para programadores

## Características Principales

- Gestión completa de buses (CRUD)
- Administración de conductores
- Gestión de pasajeros y boletos
- Definición y gestión de rutas
- Interfaz gráfica intuitiva
- Arquitectura de tres capas
- Validaciones de datos
- Generación de reportes (iTextSharp)

## 🛠️ Tecnologías Utilizadas

- **C#** - Lenguaje de programación principal
- **.NET Framework** - Framework de desarrollo
- **Windows Forms** - Interfaz de usuario
- **SQL Server** - Base de datos
- **iTextSharp** - Generación de reportes PDF
- **BouncyCastle** - Criptografía

## Dependencias

El proyecto utiliza los siguientes paquetes NuGet:
- `iTextSharp.5.5.13.4` - Para generación de reportes PDF
- `BouncyCastle.Cryptography.2.4.0` - Para funcionalidades criptográficas

## Cómo Ejecutar el Proyecto

### Prerrequisitos
- Visual Studio 2019 o superior
- .NET Framework 4.6.1 o superior
- SQL Server (para la base de datos)

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/EuniceVillamar/sistema-gestion-buses.git
   cd "sistema gestion buses"
   ```

2. **Abrir la solución**
   - Abrir `ProyectoPrimerParcial-ElizabethVillamar.sln` en Visual Studio

3. **Restaurar paquetes NuGet**
   - Click derecho en la solución
   - Seleccionar "Restaurar paquetes NuGet"

4. **Configurar la base de datos**
   - Modificar la cadena de conexión en `Datos/Conexion.cs`
   - Ejecutar los scripts de base de datos si es necesario

5. **Compilar y ejecutar**
   - Presionar `F5` o click en "Iniciar depuración"

## Estructura de Archivos

```
sistema gestion buses/
├── Controlador/          # Lógica de negocio
├── Datos/               # Acceso a datos
├── Modelo/              # Entidades del dominio
├── Vista/               # Interfaz de usuario
├── packages/            # Paquetes NuGet
├── .gitignore          # Archivos a ignorar por Git
├── README.md           # Este archivo
└── *.sln               # Archivo de solución
```

**Nota**: Este proyecto fue desarrollado como parte de un curso académico de Programacion Orientada a Eventos. 

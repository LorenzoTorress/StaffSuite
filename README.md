# StaffSuite

Sistema de gestión de empleados desarrollado en **C# con ASP.NET Razor Pages**, como proyecto para la asignatura *Algoritmos y Estructuras de Datos II*.

## Funcionalidades

- **Alta** de empleados
- **Baja** de empleados
- **Modificación** de datos de empleados existentes
- **Listado y consulta** de empleados registrados

## Tecnologías

- C# / .NET
- ASP.NET Razor Pages
- Persistencia de datos en archivos **JSON**

## Motivación

El proyecto se centró en aplicar estructuras de datos y lógica de programación en un caso de uso real (gestión de personal), utilizando Razor Pages para la capa de presentación e interacción con el usuario. Se optó por persistencia en JSON dado el alcance académico del trabajo, priorizando el foco de la materia sobre la complejidad de una base de datos relacional.

## Posibles mejoras futuras

- Migración de la persistencia de JSON a una base de datos relacional (SQL Server) usando Entity Framework Core
- Autenticación de usuarios (ASP.NET Identity)
- Validaciones adicionales y manejo de errores
- Tests unitarios

## Cómo ejecutar el proyecto

1. Clonar el repositorio
2. Abrir `Gestion Empleados.slnx` con Visual Studio
3. Restaurar dependencias y ejecutar el proyecto (`F5` o `dotnet run`)

## Autor

Lorenzo Torres

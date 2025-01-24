# Planify API

**Planify API** es la base de datos y backend realizado en ASP.NET para una aplicación web diseñada para la gestión de proyectos y tareas. Esta API permite que futuros proyectos frontend puedan manejar y administrar la gestión de proyectos. Es recomendable que las aplicaciones frontend sean del tipo RBAC (Control de acceso basado en roles) dado que es parte fundamental del diseño de la API.
Actualmen



## Características principales

 - Autenticación segura: implementa encriptación de contraseñas mediante **SHA-256** garantizando la protección de los datos de usuario.
 - Creación de proyectos y asignación de tareas: Los administradores podrán asignar tareas a los desarrolladores.
 - La API cuenta con información sobre los empleados como datos personales lo cuales solo podrán ser modificados por personal de Recursos humanos o usuarios con privilegios.

## Características técnicas

- Autenticación y autorización: Uso de políticas personalizadas con soporte para JWT (Bearer Tokens).
- ORM: Uso de Entity Framework Core para la definición de la base de datos (Code First) y datos precargados (HasData).
- Manejo de errores: Implementación de ProblemDetails para la estandarización de las respuestas de error.
- Manejo de la concurrencia pesimista revisando si los datos han sido modifica.

### Arquitectura
- Uso del patrón de diseño Repository para centralizar y abstraer el acceso a los datos.
- Uso de Unidades de trabajo (Unit of Work) para operaciones que involucren transacciones con múltiples tablas.
- Abstracción de todos los EndPoints en un controlador genérico que abstrae los métodos CRUD y con herramientas adicionales.



# Medicare Web (MVC .NET 7)

Aplicación frontend MVC inspirada en el mockup de Medicare, simplificada para mostrar las pantallas esenciales de inicio de sesión, dashboard, servicios, doctores, citas y recetas. El código vive en la rama `main` y se incluye una solución para abrirlo directamente en Visual Studio.

## Estructura
- `Proyecto-Final.sln`: solución para abrir el proyecto en Visual Studio.
- `MedicareWeb/Program.cs`: configuración mínima de ASP.NET Core MVC.
- `MedicareWeb/Controllers/HomeController.cs`: acciones para las vistas principales con datos de ejemplo.
- `MedicareWeb/Models/ViewModels.cs`: modelos de vista que alimentan cada sección.
- `MedicareWeb/Views/Home/*.cshtml`: vistas Razor estilizadas según el mockup.
- `MedicareWeb/wwwroot/css/site.css`: estilos personalizados inspirados en el diseño de Figma.

## Ejecutar el proyecto en Visual Studio
1. Abre `Proyecto-Final.sln` desde la raíz del repositorio (rama `main`).
2. Selecciona el perfil de inicio `MedicareWeb` y ejecuta (F5).

## Ejecutar con la CLI
1. Instala el SDK de .NET 7.
2. Desde la carpeta `MedicareWeb` ejecuta:
   ```bash
   dotnet run
   ```
3. Abre el navegador en `https://localhost:5001` o `http://localhost:5000` según la salida de la consola.

## Notas
- La navegación es estática y utiliza datos simulados para reflejar las tarjetas, formularios y listados del mockup.
- Se simplificaron vistas y menús para dejar únicamente las secciones principales solicitadas.

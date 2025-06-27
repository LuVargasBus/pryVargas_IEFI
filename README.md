pryVargas_IEFI
# Sistema de gestión

Este proyecto es una aplicación desarrollada en C# con Windows Forms (.NET Framework)

# Funcionalidades principales

- **Inicio de sesión por usuario** con registro automático de sesiones.
- Gestión de **solicitudes por usuario** (visualización y creación).
- Registro del **tiempo de uso de la aplicación** por sesión.
- Seguimiento y visualización del **progreso de tareas asignadas**.
- Visualización de métricas en **gráficas y tablas dinámicas**.
- Interfaces amigables con visibilidad dinámica de componentes.

# Estructura del sistema

# Usuarios
- Registro de datos: nombre, apellido, rol, imagen, contraseña.


# Solicitudes
- Cada usuario puede generar solicitudes.
- Se almacenan en una tabla única: `Solicitudes_Usuario`.

# Sesiones
- Se registra automáticamente el `inicio` y `fin` de sesión.
- El tiempo total se muestra en un gráfico de barras.

# Tareas
- Relación de usuarios con tareas (`Tareas_Usuario`).
- Visualización de progreso con barras por usuario (finalizadas vs. totales).

# Informes
- **Grilla** para solicitudes (DataGridView).
- **Gráfico de barras** para tiempo en la aplicación (Chart).
- **Barra de progreso** individual por usuario para tareas finalizadas.

# Tecnologías utilizadas

- Lenguaje: C# (WinForms)
- Base de datos: SQL Server
- Librerías:
  - `System.Windows.Forms.DataVisualization` para gráficas
  - `System.Data.SqlClient` para acceso a datos
  - GunaUI
  - Fontawesome. 



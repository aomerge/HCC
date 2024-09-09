# SEGUNDA PARTE DESARROLLO

## Requisitos
- Docker
- Docker-compose

## Instalación Recomendada
Para instalar el proyecto se debe clonar el repositorio y ejecutar el siguiente comando en la carpeta api del proyecto:
```bash
docker-compose up
```

### ¿Porque usar Docker Compose?
Se recomienda utilizar Docker Compose en este proyecto debido a la automatización que ofrece para la ejecución del motor de base de datos y la implementación de los archivos SQL necesarios para la creación de la misma. Docker Compose permite definir de manera clara y estructurada los servicios que componen el entorno, lo que facilita su gestión y despliegue.

Además, en el archivo docker-compose.yml se han añadido variables de entorno que optimizan su funcionamiento en entornos locales, simplificando la integración con otros sistemas operativos. Esta solución reduce significativamente el esfuerzo requerido para configurar y ejecutar el proyecto, mejorando la consistencia y permitiendo que cualquier miembro del equipo pueda levantar el entorno con un solo comando, sin importar el sistema operativo que utilice.

En resumen, Docker Compose proporciona una instalación sencilla, repetible y eficiente, que asegura la portabilidad y facilita el trabajo colaborativo entre diferentes plataformas.

## Ejecutar el Proyecto en Visual Studio
Para Ejecutar el proyecto en Visual Studio se debe abrir la solución `api.sln` ubicada en la carpeta `api` del proyecto.

### Configuración
Para configurar el proyecto se debe modificar el archivo `appsettings.json` ubicado en la carpeta `api` del proyecto.
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=db;Database=HCC;User=sa;Password=Password123;"
  }
}
```
### Ejecutar el Proyecto
Para ejecutar el proyecto se debe seleccionar el proyecto `api` como proyecto de inicio y presionar el botón de ejecución.

## Correr el Proyecto en Visual Studio Code
Para correr el proyecto en Visual Studio Code se debe abrir la carpeta `api` del proyecto.

### Configuración
Para configurar el proyecto se debe modificar el archivo `appsettings.json` ubicado en la carpeta `api` del proyecto.
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=db;Database=HCC;User=sa;Password=Password123;"
  }
}
```
### Ejecutar el Proyecto
Para ejecutar el proyecto se debe abrir una terminal y ejecutar el siguiente comando:
```bash
dotnet run
```

## Uso
Para acceder a la documentación de la API se debe ingresar a la siguiente URL:
```
http://localhost:5000/swagger/index.html
```

## Preguntas Frecuentes
### ¿Cómo puedo acceder a la base de datos?
Para acceder a la base de datos se debe utilizar un cliente de base de datos como SQL Server Management Studio o Azure Data Studio. Los datos de conexión son los siguientes:
- Servidor: `localhost`
- Usuario: `sa`
- Contraseña
- Base de Datos: `HCC`

### ¿Cómo puedo modificar la base de datos?
Para modificar la base de datos se deben ejecutar los scripts SQL ubicados en la carpeta `api/Scripts` del proyecto. Estos scripts contienen las instrucciones necesarias para crear y modificar la estructura de la base de datos.

### ¿Por que no se conecta a la base de datos?
Si el proyecto no se conecta a la base de datos, es posible que los datos de conexión en el archivo `appsettings.json` sean incorrectos. Verifique que la cadena de conexión sea la correcta y que el servidor de base de datos esté en ejecución.

### ¿Cómo puedo solucionar problemas de conexión a la base de datos?
Para solucionar problemas de conexión a la base de datos, verifique lo siguiente:
- El servidor de base de datos está en ejecución.
- Los datos de conexión en el archivo `appsettings.json` son correctos.
- No hay conflictos de puertos con otros servicios en ejecución.
- No hay restricciones de firewall que impidan la conexión.
Si después de verificar estos puntos te recomendamos utilizar Docker Compose para levantar el entorno de desarrollo.

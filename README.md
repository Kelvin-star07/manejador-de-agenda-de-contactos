# Manejador de Agenda de Contactos

Este proyecto es una aplicación de consola desarrollada en **C#** que permite manejar una agenda de contactos realizando
operaciones básicas de **CRUD** (Crear, Leer, Actualizar y Eliminar). La aplicación interactúa con una base de datos local
en **SQL Server** y fue creada como parte de una asignación académica.

## Funcionalidades

-  **Agregar** un nuevo contacto.
-  **Consultar** todos los contactos existentes.
-  **Actualizar** los datos de un contacto específico.
-  **Eliminar** un contacto de la base de datos.
- 📋 **Menú interactivo** para navegar entre las opciones del sistema.

## Tecnologías utilizadas

- Lenguaje de programación: **C#**
- Motor de base de datos: **SQL Server**
- Entorno de desarrollo: **Visual Studio Code** / **Visual Studio Community**

## Validación de datos

La aplicación incluye un sistema de validación para asegurar la integridad de la información introducida
por el usuario. Esta lógica está encapsulada en una clase llamada `AgendaValidator`.

## Cómo ejecutar el proyecto

1. Clona este repositorio:
   ```bash
   git clone https://github.com/Kelvin-star07/manejador-de-agenda-de-contactos.git
Abre el proyecto en Visual Studio Code o Visual Studio Community.
Asegúrate de tener acceso a una instancia local de SQL Server.
Ejecuta el proyecto desde la terminal o con la opción de depuración.


📌 Público objetivo
Aunque el proyecto fue creado como parte de una asignación académica, puede ser útil para cualquier persona
que desee una solución simple para administrar contactos desde la línea de comandos.

📂 Estructura del proyecto
Program.cs – Punto de entrada de la aplicación.

Agenda.cs – Clase principal para la gestión de contactos.

AgendaValidator.cs – Clase encargada de la validación de datos.

ContactoManager.cs – Manejador de lógica para operaciones CRUD.

conexionDB.cs – Clase que administra la conexión con la base de datos.

Script_db_sql.txt – Script para la creación de la base de datos.

 Estado del proyecto
 
Actualmente, el proyecto se encuentra en su versión inicial y no se tienen planes definidos para futuras funcionalidades.

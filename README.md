**Sistema de Gestión Judicial**
Este repositorio contiene un sistema de gestión judicial desarrollado para facilitar el manejo de demandas, sentencias, expedientes, empleados, alguaciles y audiencias en un entorno judicial. El sistema proporciona una plataforma centralizada para registrar, 
gestionar y consultar información relevante para el proceso judicial.

**Características Principales:**

**Registro de Demandas:** Permite registrar demandas presentadas ante el tribunal, incluyendo detalles como partes involucradas, fechas importantes y tipo de demanda.

**Gestión de Sentencias:** Facilita el seguimiento de las sentencias emitidas por el tribunal, incluyendo información sobre el fallo, la resolución y las partes afectadas.

**Administración de Expedientes:** Permite crear y mantener expedientes judiciales, asociados con las demandas y las sentencias correspondientes.

**Registro de Empleados:** Permite gestionar la información de los empleados que trabajan en el sistema.

**Gestión de Alguaciles:** Facilita el seguimiento de las actividades realizadas por los alguaciles en el tribunal.

**Programación de Audiencias:** Permite programar y gestionar audiencias judiciales.

**Tecnologías Utilizadas**
El sistema se ha desarrollado utilizando las siguientes tecnologías y herramientas:

**ASP.NET Core:** Utilizado para el desarrollo del backend del sistema, proporcionando una arquitectura robusta y escalable.

**C#: **Lenguaje de programación principal utilizado en el desarrollo del sistema, aprovechando su sintaxis intuitiva y su amplia gama de características.

**Entity Framework Core:** Utilizado para el mapeo objeto-relacional y el acceso a la base de datos, simplificando las operaciones de persistencia de datos.

**Razor Pages:** Utilizado para desarrollar las páginas web del frontend del sistema, proporcionando una interfaz de usuario dinámica y receptiva.

**HTML/CSS/:** Utilizados para la maquetación, el diseño y la interactividad de las páginas web del sistema, asegurando una experiencia de usuario atractiva y funcional.

**Instalación y Uso**
Para instalar y utilizar el sistema de gestión judicial, sigue estos pasos:

Clona el repositorio en tu máquina local utilizando el siguiente comando:

bash
Copy code
git clone https://github.com/tu-usuario/repo.git
Abre el proyecto en tu entorno de desarrollo preferido, como Visual Studio o Visual Studio Code.

Configura la conexión a la base de datos en el archivo appsettings.json proporcionando la cadena de conexión adecuada.

Ejecuta las migraciones de la base de datos para crear el esquema necesario en tu base de datos utilizando el siguiente comando:

sql
Copy code
dotnet ef database update
Inicia la aplicación y comienza a utilizar el sistema de gestión judicial.

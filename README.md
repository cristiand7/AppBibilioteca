Aplicación realizada con angular y .net core

- Proyecto .Net Core ubicado en la carperta 'Backend.Biblioteca'
- Proyecto Agular ubicado en la carperta 'Frontend.Biblioteca'

Pasos para la ejecucion de la aplicación


1) Ejecutar el script de la base de datos 'modeloDB.slq' en una base de datos creada previamente. 

2) Poner en ejecución el proyecto 'Backend.Biblioteca' para ello: 

- Configurar la conexion de la base de datos en el archivo appsettings.json
ubicado en en "Backend.Biblioteca\Backend.Biblioteca\apsstegins.json"
modificar la sección 'conexionBD' con los datos serve, database, user y password.
		
- Ejecutar el siguiente comando en la capeta "Backend.Biblioteca\Backend.Biblioteca"
> dotnet run
	
Nota: el servicio se debe exponer en la url https://localhost:5001 

3) Poner en ejecución el proyecto 'Frontend.Biblioteca' para ello: 

- Ubicamos dentro de la carpeta 'Frontend.Biblioteca' y ejecutamos el siguiente comando para descargar los modulos y dependencias de angular
> npm install

- Procedemos a ejecutar el proyecto web con el siguiente comando:
> ng serve -o 
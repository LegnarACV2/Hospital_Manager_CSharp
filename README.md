# Hospital_Manager_CSharp
Aplicación de escritorio que administra distintas entidades y procesos de un Hospital.

Desarrollada en C# y Aplicando la Arquitectura en Capas Tradicional con base de datos SQL-Server.
Puede encontrar el script de la base de datos en el repositorio para recrear la misma en su ordenador personal.

1. Tras descargar el Archivo abrá el Script de la base de datos en su Microsoft SQL Server Managment Studio y ejecutelo.
![1](https://user-images.githubusercontent.com/67526356/128108991-e2db297d-87d1-4d40-90f3-11e3ee262c4c.png)
  En caso de que surja algún error pruebe la siguiente solucion eliminando las linéas resaltadas en la
  siguiente imagen y probando ejecutar nuevamente:
  ![2](https://user-images.githubusercontent.com/67526356/128109363-346ce4fc-1a2b-4f18-afca-9c256b89aa7e.png)
  
2. Una vez se ha creado con exito la Base de datos, copie el nombre de su instancia SQL-Server como en la siguiente imagen:
   ![3](https://user-images.githubusercontent.com/67526356/128109880-56b63db4-9b3f-4d24-8920-60468a21d6d3.png)

Ahora Vamos a ir a nuestra carpeta del proyecto: 
1. Abriremos Nuestra solucion LayeredHospital.Sln Que esta dentro de la carpeta LayeredHospital
2. En el Archivo app.config en la capa presentacion remmplazaremos El Valor de DataSource=DESKTOP-58S920D\PUNTODEVENTA en todos los connectionString
   por DataSource=[ElNombreDeTuServidor] copiado anteriormente. 
  

El proyecto debería ejecutarse sin problemas(>.<)!

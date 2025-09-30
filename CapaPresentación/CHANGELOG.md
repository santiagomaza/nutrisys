# Historial de versiones sistema NutriSys

## Versión [1.1.0] - 30/10/2025

### Corrección
	- Error al agregar nuevo paciente en pantalla Pacientes

### Modificación
	- Se modificaron los métodos de capa de datos y capa de negocios de Agregar y Editar Pacientes. Se le agregó una referencia a la capa de entidades a la clase Paciente
	- Se modificó en capa de presentación los métodos de agregar y editar pacientes una instancia de la entidad Paciente y dejando así el código más legible

### Agregado
	- Nueva capa de Entidades con entidad Paciente
	- Nuevas validaciones para el paciente en Capa de Negocios en la clase ValidarPaciente

## Version [1.0.4] - 24/08/2025

### Corrección
	- Error al editar pacientes si no se agregaba un domicilio

### Modificación
	- En pantalla de Historias Clínicas, se desactivó el botón de Agregar Nuevo Diagnóstico cuando se quiere agregar una historia clínica desde cero a un paciente.
	- En pantalla Antropometría, se desactiva el botón de Editar Datos Antropométricos cuando se hace la edición de los datos de un paciente. Antes quedaba habilitado innecesariamente.

### Agregado
	- Estilos básicos a los message boxes nativos de Windows Forms

## Version [1.0.3] - 13/08/2025

### Corrección
	- Se corrigió error de conexión a la base de datos.

## Version [1.0.2] - 07/08/2025

### Corrección
	- Se corrigió la característica de habilitación del botón de Editar Historia Clínica al insertar una nueva historia clínica en la pantalla de historias clínicas, cuando no debería ser esa la funcionalidad.
	- Se corrigió la forma en la que estaba escrita la consulta SQL en la capa de datos de PAMI, agregando que haga una retribución de datos por fecha de consulta de manera ascendente

### Modificación
	- Se hizo un ligero cambio en el diseño en Antropometría, cambiando de lugar el filtro de fecha. Antes estaba ubicado a la par del botón de Mostrar Datos Antropométricos, ahora se lo ubicó abajo del mismo.
	

## Version [1.0.1] - 28/07/2025

### Corrección
	- En input número de afiliado, se le permite al usuario poder agregar algun caracter especial en caso de ser necesario

### Agregado
	- Validación en inputs email y número de afiliado. No se permite al usuario ingresar más de una cantidad de caracteres. 

## Version [1.0.0] - 27/07/2025

### Agregado
	- Primera versión estable del sistema.
	- Funcionalidades:
		- Gestión de pacientes.
		- Gestión de Historias Clinicas y Diagnósticos.
		- Gestión de Datos Antropométricos del paciente.
		- Filtro de pacientes con obra social PAMI.

# Historial de versiones sistema NutriSys

## Versi�n [1.2.0] - 06/10/2025

### Agregado
  - Modulo de Testing b�sico en consola de .NET.
  - Capa de Presentaci�n - Pacientes: Se agreg� una validaci�n al input de DNI antes de insertar un nuevo paciente.
  - Capa de Presentaci�n - Utils: Se agreg� una nueva clase `AplicarEstilos`.
  - Capa de Datos - Paciente: Se agreg� una validaci�n de control de errores en el m�todo `InsertarPacientes()` que devuelve un mensaje de error si es que la base de datos arroja error al insertar un nuevo paciente.
  - Entidad `DatoAntropometrico` en capa Entidades.
	
### Modificado
  - Capa de Presentaci�n - Historias Cl�nicas: Se migr� la l�gica de cambio de estilos en el *Rich Text Box* al m�todo `AplicarEstilosTextBox()` de la clase `AplicarEstilos`.
  - Capa de Negocios - Antropometr�a: Refactorizaci�n de los m�todos `AgregarDatoAntrometrico()` y `EditarDatoAntropom�trico()` donde se cambi� los campos primitivos **(peso, talla, imc, m�sculo esquel�tico, nivel grasa visceral, porcentaje de grasa corporal, edad corporal, fecha evoluci�n)** por la entidad DatoAntropometrico.
  
### Corregido
  - Capa de Presentaci�n - Historias Cl�nicas: Se desactiv� el bot�n de `QuitarArchivo()` cuando se inicializa el formulario.
  - Capa de Presentaci�n - Antropometr�a: Se corrigi� la solapaci�n del label `lblPacienteDA` con el groupBox `grpAntropometr�a` cuando el nombre del paciente era largo.  
  - Capa de Negocios - Pacientes: Se corrigi� la validaci�n del campo Email en el m�todo `Validar()` de la clase `ValidarPaciente` que daba el error **El email debe contener el @ para que sea valido** cuando no se ingresaba un correo.
   
## Versi�n [1.1.0] - 30/09/2025

### Corregido
  - Error al agregar nuevo paciente en pantalla Pacientes.

### Modificado
  - Se modificaron los m�todos de capa de datos y capa de negocios de `Agregar y Editar Pacientes`. Se le agreg� una referencia a la capa de entidades a la clase Paciente
  - Se modific� en capa de presentaci�n los m�todos de agregar y editar pacientes una instancia de la entidad Paciente y dejando as� el c�digo m�s legible

### Agregado
  - Nueva capa de Entidades con entidad `Paciente`.
  - Nuevas validaciones para el paciente en Capa de Negocios en la clase `ValidarPaciente`.

## Version [1.0.4] - 24/08/2025

### Corregido
  - Error al editar pacientes si no se agregaba un domicilio.

### Modificado
  - En pantalla de Historias Cl�nicas, se desactiv� el bot�n de Agregar Nuevo Diagn�stico cuando se quiere agregar una historia cl�nica desde cero a un paciente.
  - En pantalla Antropometr�a, se desactiva el bot�n de Editar Datos Antropom�tricos cuando se hace la edici�n de los datos de un paciente. Antes quedaba habilitado innecesariamente.

### Agregado
  - Estilos b�sicos a los message boxes nativos de Windows Forms.

## Version [1.0.3] - 13/08/2025

### Corregido
  - Se corrigi� error de conexi�n a la base de datos.

## Version [1.0.2] - 07/08/2025

### Corregido
  - Se corrigi� la caracter�stica de habilitaci�n del bot�n de Editar Historia Cl�nica al insertar una nueva historia cl�nica en la pantalla de historias cl�nicas, cuando no deber�a ser esa la funcionalidad.
  - Se corrigi� la forma en la que estaba escrita la consulta SQL en la capa de datos de PAMI, agregando que haga una retribuci�n de datos por fecha de consulta de manera ascendente

### Modificado
  - Se hizo un ligero cambio en el dise�o en Antropometr�a, cambiando de lugar el filtro de fecha. Antes estaba ubicado a la par del bot�n de Mostrar Datos Antropom�tricos, ahora se lo ubic� abajo del mismo.
	
## Version [1.0.1] - 28/07/2025

### Corregido
  - En input n�mero de afiliado, se le permite al usuario poder agregar algun caracter especial en caso de ser necesario

### Agregado
  - Validaci�n en inputs email y n�mero de afiliado. No se permite al usuario ingresar m�s de una cantidad de caracteres. 

## Version [1.0.0] - 27/07/2025

### Agregado
  - Primera versi�n estable del sistema.
  - Funcionalidades:
	- Gesti�n de pacientes.
	- Gesti�n de Historias Clinicas y Diagn�sticos.
	- Gesti�n de Datos Antropom�tricos del paciente.
	- Filtro de pacientes con obra social PAMI.

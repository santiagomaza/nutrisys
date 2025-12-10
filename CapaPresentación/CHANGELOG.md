# Historial de versiones sistema NutriSys

## Versión [1.3.1] - 09/12/2025

### Corregido
  - Capa de Presentación - Acerca De: Se borró la instancia al formulario de `Inicio` ya que daba error debido a que no se le pasaba el objeto de `Usuario`.

## Versión [1.3.0] - 09/12/2025

### Agregado
  - Capa de Presentación - Inicio: Se agregó un texto de bienvenida para el usuario y se hizo una instancia al objeto Usuario de la Capa de Entidades para poder trabajar con esos datos.
  - Capa de Presentación - Inicio Sesión: Se agregó una instancia a la clase Usuario de la capa de entidades para poder almacenar el nombre del usuario al momento de iniciar sesión.
  - Capa de Entidades - Usuario: Se agregó una nueva entidad llamada `Usuario` con propiedades de Nombre de Usuario y Contraseña.
  - Capa de Negocios - CN_Usuario: Se instaló la dependencia **BCrypt.Net** para poder realizar la verificación al momento de ingresar la contraseña cuando se hace el login con la contraseña almacenada en base de datos en el método `ValidarInicioSesión()`. De esta forma, se le agrega la seguridad necesaria a la aplicación.
  
### Modificado
  - Capa de Datos - CD_Usuarios: Se modificó la query de la base de datos en el método `ValidarInicioSesion()`. Además se cambió el retorno del método a una tupla de **(bool existe, Usuario usuarioDTO)**. No se trabaja más con *ExecuteScalar*, ahora se usa *ExecuteReader* y a los resultados se los guarda en la instancia del objeto Usuario.

## Versión [1.2.0] - 06/10/2025

### Agregado
  - Modulo de Testing básico en consola de .NET.
  - Capa de Presentación - Pacientes: Se agregó una validación al input de DNI antes de insertar un nuevo paciente.
  - Capa de Presentación - Utils: Se agregó una nueva clase `AplicarEstilos`.
  - Capa de Datos - Paciente: Se agregó una validación de control de errores en el método `InsertarPacientes()` que devuelve un mensaje de error si es que la base de datos arroja error al insertar un nuevo paciente.
  - Entidad `DatoAntropometrico` en capa Entidades.
	
### Modificado
  - Capa de Presentación - Historias Clínicas: Se migró la lógica de cambio de estilos en el *Rich Text Box* al método `AplicarEstilosTextBox()` de la clase `AplicarEstilos`.
  - Capa de Negocios - Antropometría: Refactorización de los métodos `AgregarDatoAntrometrico()` y `EditarDatoAntropométrico()` donde se cambió los campos primitivos **(peso, talla, imc, músculo esquelético, nivel grasa visceral, porcentaje de grasa corporal, edad corporal, fecha evolución)** por la entidad DatoAntropometrico.
  
### Corregido
  - Capa de Presentación - Historias Clínicas: Se desactivó el botón de `QuitarArchivo()` cuando se inicializa el formulario.
  - Capa de Presentación - Antropometría: Se corrigió la solapación del label `lblPacienteDA` con el groupBox `grpAntropometría` cuando el nombre del paciente era largo.  
  - Capa de Negocios - Pacientes: Se corrigió la validación del campo Email en el método `Validar()` de la clase `ValidarPaciente` que daba el error **El email debe contener el @ para que sea valido** cuando no se ingresaba un correo.
   
## Versión [1.1.0] - 30/09/2025

### Corregido
  - Error al agregar nuevo paciente en pantalla Pacientes.

### Modificado
  - Se modificaron los métodos de capa de datos y capa de negocios de `Agregar y Editar Pacientes`. Se le agregó una referencia a la capa de entidades a la clase Paciente
  - Se modificó en capa de presentación los métodos de agregar y editar pacientes una instancia de la entidad Paciente y dejando así el código más legible

### Agregado
  - Nueva capa de Entidades con entidad `Paciente`.
  - Nuevas validaciones para el paciente en Capa de Negocios en la clase `ValidarPaciente`.

## Version [1.0.4] - 24/08/2025

### Corregido
  - Error al editar pacientes si no se agregaba un domicilio.

### Modificado
  - En pantalla de Historias Clínicas, se desactivó el botón de Agregar Nuevo Diagnóstico cuando se quiere agregar una historia clínica desde cero a un paciente.
  - En pantalla Antropometría, se desactiva el botón de Editar Datos Antropométricos cuando se hace la edición de los datos de un paciente. Antes quedaba habilitado innecesariamente.

### Agregado
  - Estilos básicos a los message boxes nativos de Windows Forms.

## Version [1.0.3] - 13/08/2025

### Corregido
  - Se corrigió error de conexión a la base de datos.

## Version [1.0.2] - 07/08/2025

### Corregido
  - Se corrigió la característica de habilitación del botón de Editar Historia Clínica al insertar una nueva historia clínica en la pantalla de historias clínicas, cuando no debería ser esa la funcionalidad.
  - Se corrigió la forma en la que estaba escrita la consulta SQL en la capa de datos de PAMI, agregando que haga una retribución de datos por fecha de consulta de manera ascendente

### Modificado
  - Se hizo un ligero cambio en el diseño en Antropometría, cambiando de lugar el filtro de fecha. Antes estaba ubicado a la par del botón de Mostrar Datos Antropométricos, ahora se lo ubicó abajo del mismo.
	
## Version [1.0.1] - 28/07/2025

### Corregido
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

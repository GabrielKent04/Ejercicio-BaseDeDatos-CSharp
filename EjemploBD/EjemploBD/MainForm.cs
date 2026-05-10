/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 6/5/2026
 * Time: 7:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Conector específico de MySql con C#. El puente entre el lenguaje y el servidor. 
using System.Data; // Para manejar datos una vez extraídos de la base de datos y organizarlos en una tabla.

namespace EjemploBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		// Paso 1. Crear una cadena de conexión. Por seguridad, se le asigna una protección de tipo privada para que solo sea leído dentro de esta clase Main. Es de tipo string porque toda la dirección es una cade de texto.
		// a. Server=localhost: indica el origen de la base de datos. En esta ocasión, localhost indica que está en nuestra propia PC. Si fuera en una nube, debe ir en una dirección IP o un dominio.
		// b. Database=peducativa: indica el nombre de nuestra base de datos registrada en phpMyAdmin. Debe ser el nombre EXACTO.
		// c. uid=root. UID significa Identificador Único. Por defecto, XAMPP crea un superusuario llamado root, el cual tiene permiso para hacer todo.
		// d. Pwd=;. Es el password (contraseña). Por defecto, el usuario root no tiene contraseña; por eso se deja vacío.
		
		private string cadenaConexión = "Server=localhost;Database=peducativa;Uid=root;Pwd=;";
		
		public MainForm()
		{
			
			InitializeComponent();
			CargarUsuario();
			
		}
		
		public void CargarUsuario() // Concentramos en una función tipo void (es decir, en una orden) los pasos a seguir para cargar los usuarios de la base de datos y traerlos al disco duro.
		{
			try // INTENTA hacer esto.
			{
				// Paso 2. Creamos conexión. La conexión solo existe dentro del using para un menor consumo de RAM, para que el servidor de base de datos no se sature de conexiones olvidadas (que no han sido cerradas manualmente). Llave que abre, llave que cierra; conexión que se abre, conexión que se cierra. Así el sistema responde a nuevo usuarios. 
				
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexión)) // Gracias al using MySql.Data.MySqlClient, llamamos a la clase MySqlConnection, instanciamos un objeto llamado "conexión" cuyos parametros es la cadena de texto que creamos arriba. Esos parámetros irán a su propio constructor para saber a qué servidor se conectará. 
				{
					// Paso 3. Esta es la plantilla de lo que le vamos a pedir a MySQL para el momento de traer la base de datos de usuario.
					
					string consulta = "SELECT id, nombre, clave, rol from usuario";
					
					conexion.Open(); // Paso 4. Abrimos la conexión. Usamos el objeto creado para llamar a un método cuya acción es abrir la conexión. El programa envía la cadena de texto creada anteriormente al servidor, verifica si son correctos para la base de datos peducativa. Si todo está bien, establece una conexión abierta. A partir de aquí, ya está listo para enviar y recibir datos.
					
					// Paso 5. Instanciamos un objeto de la clase MySqlDataAdaptater llamado "adaptador". Este objeto es el mediador entre MySqL y C#. Es el traductor que entiende ambos mundos. Los parametros ingresados indica primero qué es lo que quiere extraer (consulta) y por donde debe buscar lo que quiere (conexion). Esos parámetros viajan al constructor de esa clase.
				  
					MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
					
					// Paso 6. Creamos un objeto de tipo tabla en memoria (vacía por los momentos. Aquí llenaremos los datos que llegará del objeto "adaptador". Tiene filas, columnas, y restricciones.
					
					DataTable tabla = new DataTable(); 
					
					// Paso 7. 
					
					adaptador.Fill(tabla); // Llamamos al adaptador (el objeto que viene con los datos), su método Fill (que es llenar) y le decimos en dónde se llenará (la tabla).
						
					// Paso 8.
						
					dgvUsuarios.DataSource = tabla; // Llamamos al DataGridView de usuarios y le indicamos que mostrará el contenido del objeto tabla.
					
					//lblEstado.Tet = string.Format("Cargados {0} usuarios.",tabla.Rows.Count)
				}
				
			}
			catch (Exception ex) // Si no  se puede intentar lo de arriba, HAZ ESTO.
			{
				MessageBox.Show(string.Format("No se pudo realizar conexión  por: {0}",ex.Message)); // Indicamos el error que impidió hacer lo de arriba. El error se indica llamando al objeto ex y su método "message", para ver información.
				                             
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			cmbRol fmrnuevo = new cmbRol(); // Instanciamos un objeto de la ventana de añadir usuarios.
			
			if(fmrnuevo.ShowDialog() == DialogResult.OK)
			{
				
				CargarUsuario();
				
			}

		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			string consulta = "DELETE from usuario WHERE id = @id"; // Guardamos el orden específico del botón en una variable de tipo string. 
			int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value); // Guardamos el id ÚNICO del usuario. Especificamos el dgv,luego llamamos al método que indica
			string nombre = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
			 
			DialogResult advertencia = MessageBox.Show(string.Format("¿Está seguro de eliminar al usuario '{0}'?",nombre),"Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(dgvUsuarios.CurrentRow == null)
			{
				MessageBox.Show("Debe seleccionar a un usuario");
			}
			if(advertencia == DialogResult.Yes)
			{
             			
			try
			{
				using(MySqlConnection conexion = new MySqlConnection(cadenaConexión))
					using (MySqlCommand orden = new MySqlCommand(consulta,conexion))
				             {
				             	
				       	 orden.Parameters.AddWithValue("@id", idUsuario);
				       	 
				       	 conexion.Open(); // Paso 5. Abrimos la conexión para ejecutar la orden.
				       	 	orden.ExecuteNonQuery(); // Paso 6. Ejecutamos la orden.
				       	 	CargarUsuario();
				             }
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: {0}",ex.Message);
				               
				
			}
		}
		
	}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			
		}
}
	}

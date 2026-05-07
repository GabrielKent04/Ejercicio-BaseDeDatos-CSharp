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
			
		}
		
		public void CargarUsuario()
		{
			try // Intentar hacer esto.
			{
				// Paso 2. Creamos conexión (la conexión solo existe dentro del using)
				
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexión)) // Gracias al using MySql.Data.MySqlClient, llamamos a la clase MySqlConnection, instanciamos un objeto llamado "conexión" cuyos parametros es la cadena de texto que creamos arriba. Esos parámetros irán a su propio constructor para saber a qué servidor se conectará. 
				{
					
				}
				
			}
		}
	}
}

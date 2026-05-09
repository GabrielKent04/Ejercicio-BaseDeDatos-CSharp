/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/5/2026
 * Time: 7:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace EjemploBD
{
	/// <summary>
	/// Description of UsuarioNuevo.
	/// </summary>
	public partial class cmbRol : Form
	{
		
		private string cadenaConexion = "Server=localhost;Database=peducativa;Uid=root;Pwd=;";
		
		public cmbRol()
		{
			
			InitializeComponent();
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
			   {
			   	MessageBox.Show("Todos los campos son OBLIGATORIOS","Error de registro");
			   	return;
			   }

			int idrol = Convert.ToInt32(comboBox1.SelectedIndex); // Paso 1. Esto lo que hace es tomar el id del rol desde la selección del usuario.
			
			string consulta = "INSERT INTO usuario (nombre,clave,rol) VALUES (@nombre,@clave,@rol)"; // Creamos un string el cuál nos sirve como orden. Indicamos los campos de la tabla usuario, y avisamos que vamos a introducir valores allí llamando al nombre de las columnas junto al @.
			
			try 
			{
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) // Paso 2. Creamos conexión con la base de datos 'peducativa'
					using (MySqlCommand mensajero = new MySqlCommand(consulta,conexion)) // Paso 3. Enviamos la orden (consulta) a la base de datos (conexion)
				       {
				       	 // Paso 4. Asignamos los parámetros.
				       	 
				       	 mensajero.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim()); // Llamamos al objeto 'mensajero', y a los métodos que agregaran los parámetros a los marcadores indicados previamente.
				       	 mensajero.Parameters.AddWithValue("@clave", txtClave.Text);
				       	 mensajero.Parameters.AddWithValue("@rol", idrol);
				       	 
				       	 conexion.Open(); // Paso 5. Abrimos la conexión para ejecutar la orden.
				       	 	mensajero.ExecuteNonQuery(); // Paso 6. Ejecutamos la orden.
				       }
					       
					       MessageBox.Show("Usuario agregado correctamente","Registro exitoso");
					       this.DialogResult = DialogResult.OK; // Paso 6. Le indicamos al padre que el registro fue exitoso para que proceda a refrescar el DataGridView.
			}
			
			catch (Exception ex)
			{
				MessageBox.Show("Error: {0}",ex.Message);
			}
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void CmbRolLoad(object sender, EventArgs e)
		{
			
		}
	}
}

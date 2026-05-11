using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace EjemploBD
{
	/// <summary>
	/// Description of EditarUsuario.
	/// </summary>
	public partial class EditarUsuario : Form
	{
		
		
		public int idSeleccionado;
		
		public EditarUsuario()
		{
			
			InitializeComponent();
			
		}
		

		void BtnEditarClick(object sender, EventArgs e)
		{
			string cadenaConexion = "Server=localhost;Database=peducativa;Uid=root;Pwd=;";
			string consulta = "UPDATE usuario SET nombre = @nombre, clave = @clave, rol = @rol WHERE id = @id"; 
			
			using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
				using (MySqlCommand orden = new MySqlCommand(consulta,conexion))
			{
					 orden.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim()); 
				     orden.Parameters.AddWithValue("@clave", txtClave.Text);
				     orden.Parameters.AddWithValue("@rol", cmbRol.Text);
				     orden.Parameters.AddWithValue("@id", idSeleccionado);
				     
				     
				     conexion.Open();
				     
				     orden.ExecuteNonQuery();
				     
			}
			
						MessageBox.Show("Datos editados correctamente","Acción exitosa");
					       this.DialogResult = DialogResult.OK;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

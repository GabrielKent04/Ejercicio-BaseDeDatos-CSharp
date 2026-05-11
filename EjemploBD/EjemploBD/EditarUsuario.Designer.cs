/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 11/5/2026
 * Time: 6:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EjemploBD
{
	partial class EditarUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbRol
			// 
			this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
									"Jugador",
									"Administrador"});
			this.cmbRol.Location = new System.Drawing.Point(30, 211);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(177, 21);
			this.cmbRol.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label3.Location = new System.Drawing.Point(28, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(420, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Tipo de rol";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label2.Location = new System.Drawing.Point(28, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(420, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "Contraseña";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label1.Location = new System.Drawing.Point(28, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(420, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nombre";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(30, 133);
			this.txtClave.MaxLength = 50;
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(177, 20);
			this.txtClave.TabIndex = 19;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(30, 58);
			this.txtNombre.MaxLength = 50;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(177, 20);
			this.txtNombre.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(128, 273);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 38);
			this.button1.TabIndex = 25;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// BtnEditar
			// 
			this.BtnEditar.AutoSize = true;
			this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnEditar.FlatAppearance.BorderSize = 0;
			this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEditar.ForeColor = System.Drawing.Color.White;
			this.BtnEditar.Location = new System.Drawing.Point(12, 273);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(101, 38);
			this.BtnEditar.TabIndex = 24;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = false;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// EditarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(246, 360);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnEditar);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "EditarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox cmbRol;
	}
}

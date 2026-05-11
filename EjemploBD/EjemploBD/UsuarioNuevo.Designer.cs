/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/5/2026
 * Time: 7:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EjemploBD
{
	partial class cmbRol
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
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.AutoSize = true;
			this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAgregar.FlatAppearance.BorderSize = 0;
			this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAgregar.ForeColor = System.Drawing.Color.White;
			this.BtnAgregar.Location = new System.Drawing.Point(12, 274);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(101, 38);
			this.BtnAgregar.TabIndex = 9;
			this.BtnAgregar.Text = "Guardar";
			this.BtnAgregar.UseVisualStyleBackColor = false;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
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
			this.button1.Location = new System.Drawing.Point(128, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 38);
			this.button1.TabIndex = 10;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(31, 56);
			this.txtNombre.MaxLength = 50;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(177, 20);
			this.txtNombre.TabIndex = 11;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(31, 131);
			this.txtClave.MaxLength = 50;
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(177, 20);
			this.txtClave.TabIndex = 12;
			this.txtClave.TextChanged += new System.EventHandler(this.TxtClaveTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label1.Location = new System.Drawing.Point(29, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(420, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label2.Location = new System.Drawing.Point(29, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(420, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "Contraseña";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.label3.Location = new System.Drawing.Point(29, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(420, 24);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tipo de rol";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Jugador",
									"Administrador"});
			this.comboBox1.Location = new System.Drawing.Point(31, 209);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(177, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// cmbRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(246, 360);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnAgregar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "cmbRol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UsuarioNuevo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BtnAgregar;
		
		void TxtClaveTextChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}

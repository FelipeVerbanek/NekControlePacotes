namespace NekClients.view
{
	partial class listCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvClientes
			// 
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(12, 70);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.Size = new System.Drawing.Size(598, 333);
			this.dgvClientes.TabIndex = 0;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Gadugi", 8.25F);
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnExcluir.Location = new System.Drawing.Point(507, 30);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnExcluir.Size = new System.Drawing.Size(103, 34);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Gadugi", 8.25F);
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnEditar.Location = new System.Drawing.Point(389, 30);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEditar.Size = new System.Drawing.Size(103, 34);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnNovo.FlatAppearance.BorderSize = 0;
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Gadugi", 8.25F);
			this.btnNovo.ForeColor = System.Drawing.Color.White;
			this.btnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnNovo.Location = new System.Drawing.Point(270, 30);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnNovo.Size = new System.Drawing.Size(103, 34);
			this.btnNovo.TabIndex = 7;
			this.btnNovo.Text = "Novo Cliente";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// listCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 415);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.dgvClientes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "listCliente";
			this.Text = "listCliente";
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNovo;
	}
}
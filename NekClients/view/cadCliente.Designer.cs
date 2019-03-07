namespace NekClients
{
	partial class Cliente
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
			this.label1 = new System.Windows.Forms.Label();
			this.rbFisca = new System.Windows.Forms.RadioButton();
			this.rbJuridica = new System.Windows.Forms.RadioButton();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.CNPJ = new System.Windows.Forms.Label();
			this.CPF = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNascimento = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEndereco = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// rbFisca
			// 
			this.rbFisca.AutoSize = true;
			this.rbFisca.Location = new System.Drawing.Point(158, 70);
			this.rbFisca.Name = "rbFisca";
			this.rbFisca.Size = new System.Drawing.Size(90, 17);
			this.rbFisca.TabIndex = 2;
			this.rbFisca.TabStop = true;
			this.rbFisca.Text = "Pessoa Fisica";
			this.rbFisca.UseVisualStyleBackColor = true;
			// 
			// rbJuridica
			// 
			this.rbJuridica.AutoSize = true;
			this.rbJuridica.Location = new System.Drawing.Point(33, 70);
			this.rbJuridica.Name = "rbJuridica";
			this.rbJuridica.Size = new System.Drawing.Size(99, 17);
			this.rbJuridica.TabIndex = 3;
			this.rbJuridica.TabStop = true;
			this.rbJuridica.Text = "Pessoa Juridica";
			this.rbJuridica.UseVisualStyleBackColor = true;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(30, 117);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(447, 20);
			this.txtNome.TabIndex = 4;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Location = new System.Drawing.Point(30, 173);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(128, 20);
			this.txtCnpj.TabIndex = 5;
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(30, 228);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(128, 20);
			this.txtCpf.TabIndex = 6;
			// 
			// CNPJ
			// 
			this.CNPJ.AutoSize = true;
			this.CNPJ.Location = new System.Drawing.Point(30, 154);
			this.CNPJ.Name = "CNPJ";
			this.CNPJ.Size = new System.Drawing.Size(34, 13);
			this.CNPJ.TabIndex = 7;
			this.CNPJ.Text = "CNPJ";
			// 
			// CPF
			// 
			this.CPF.AutoSize = true;
			this.CPF.Location = new System.Drawing.Point(27, 212);
			this.CPF.Name = "CPF";
			this.CPF.Size = new System.Drawing.Size(27, 13);
			this.CPF.TabIndex = 8;
			this.CPF.Text = "CPF";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Data Nascimento";
			// 
			// txtNascimento
			// 
			this.txtNascimento.Location = new System.Drawing.Point(30, 280);
			this.txtNascimento.Name = "txtNascimento";
			this.txtNascimento.Size = new System.Drawing.Size(100, 20);
			this.txtNascimento.TabIndex = 10;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSalvar.Location = new System.Drawing.Point(30, 329);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(121, 29);
			this.btnSalvar.TabIndex = 14;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCancelar.Location = new System.Drawing.Point(175, 329);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(121, 29);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEndereco
			// 
			this.btnEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnEndereco.FlatAppearance.BorderSize = 0;
			this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEndereco.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEndereco.ForeColor = System.Drawing.SystemColors.Control;
			this.btnEndereco.Location = new System.Drawing.Point(356, 70);
			this.btnEndereco.Name = "btnEndereco";
			this.btnEndereco.Size = new System.Drawing.Size(121, 29);
			this.btnEndereco.TabIndex = 16;
			this.btnEndereco.Text = "Cadastrar endereço";
			this.btnEndereco.UseVisualStyleBackColor = false;
			this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(27, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(252, 33);
			this.label3.TabIndex = 17;
			this.label3.Text = "Cadastro de cliente";
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(506, 379);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEndereco);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtNascimento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CPF);
			this.Controls.Add(this.CNPJ);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.rbJuridica);
			this.Controls.Add(this.rbFisca);
			this.Controls.Add(this.label1);
			this.Name = "Cliente";
			this.Text = "Cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbFisca;
		private System.Windows.Forms.RadioButton rbJuridica;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.Label CNPJ;
		private System.Windows.Forms.Label CPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNascimento;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEndereco;
		private System.Windows.Forms.Label label3;
	}
}
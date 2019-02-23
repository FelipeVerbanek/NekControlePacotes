namespace NekClients
{
	partial class listProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listProdutos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnNovo = new System.Windows.Forms.Button();
			this.DVG_Dados = new System.Windows.Forms.DataGridView();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DVG_Dados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnNovo.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnNovo, "btnNovo");
			this.btnNovo.ForeColor = System.Drawing.Color.White;
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// DVG_Dados
			// 
			this.DVG_Dados.AllowUserToAddRows = false;
			this.DVG_Dados.AllowUserToDeleteRows = false;
			this.DVG_Dados.AllowUserToOrderColumns = true;
			this.DVG_Dados.BackgroundColor = System.Drawing.Color.Gray;
			this.DVG_Dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DVG_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DVG_Dados.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DVG_Dados.DefaultCellStyle = dataGridViewCellStyle3;
			this.DVG_Dados.GridColor = System.Drawing.Color.White;
			resources.ApplyResources(this.DVG_Dados, "DVG_Dados");
			this.DVG_Dados.Name = "DVG_Dados";
			this.DVG_Dados.ReadOnly = true;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DVG_Dados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DVG_Dados.RowTemplate.Height = 25;
			this.DVG_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_Dados_CellContentClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnEditar, "btnEditar");
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Name = "label1";
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnExcluir, "btnExcluir");
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// listProdutos
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.DVG_Dados);
			this.Controls.Add(this.btnNovo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "listProdutos";
			this.Load += new System.EventHandler(this.listProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.DVG_Dados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.DataGridView DVG_Dados;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExcluir;
	}
}
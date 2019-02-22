namespace NekClients
{
	partial class Form1
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnProduto = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.panelCentral = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.btnSair);
			this.panel1.Controls.Add(this.btnProduto);
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(179, 454);
			this.panel1.TabIndex = 0;
			// 
			// btnSair
			// 
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnSair.Location = new System.Drawing.Point(3, 258);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(176, 49);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnProduto
			// 
			this.btnProduto.FlatAppearance.BorderSize = 0;
			this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProduto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProduto.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnProduto.Location = new System.Drawing.Point(3, 97);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(176, 49);
			this.btnProduto.TabIndex = 3;
			this.btnProduto.Text = "Pordutos";
			this.btnProduto.UseVisualStyleBackColor = true;
			this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
			// 
			// btnHome
			// 
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnHome.Location = new System.Drawing.Point(2, 42);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(176, 49);
			this.btnHome.TabIndex = 1;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			// 
			// panelCentral
			// 
			this.panelCentral.Location = new System.Drawing.Point(179, 0);
			this.panelCentral.Name = "panelCentral";
			this.panelCentral.Size = new System.Drawing.Size(638, 454);
			this.panelCentral.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 454);
			this.Controls.Add(this.panelCentral);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nek";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnProduto;
		public System.Windows.Forms.Panel panelCentral;
	}
}


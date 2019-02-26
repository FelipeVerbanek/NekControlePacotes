using NekClients.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekClients
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void AbrirFormInPanel(object formfilho)
		{
			if (this.panelCentral.Controls.Count > 0)

			{
				this.panelCentral.Controls.RemoveAt(0);
			}
			Form fh = formfilho as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.panelCentral.Controls.Add(fh);
			this.panelCentral.Tag = fh;
			fh.Show();
		}

		private void btnProduto_Click(object sender, EventArgs e)
		{
			//AbrirFormInPanel(new cadProduto());
			AbrirFormInPanel(new listProdutos() );
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnCliente_Click(object sender, EventArgs e)
		{
			AbrirFormInPanel(new listCliente());
		}
	}
}

using NekClients.classes;
using NekClients.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekClients.view
{
	public partial class CadEndereco : Form
	{
		public CadEndereco()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			ServiceEndereco servico = new ServiceEndereco();
			

			Endereco endereco = new Endereco(
				);
			
		}
	}
}

using NekClients.classes;
using NekClients.Entities;
using NekClients;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NekClients.view
{
	public partial class listCliente : Form
	{
		public listCliente()
		{
			InitializeComponent();
			RecuperaLista();
		}

		private void RecuperaLista()
		{

			ServiceCliente lstCliente = new ServiceCliente();

			List<Clientes> clientes = lstCliente.ListarClientes();
			
			dgvClientes.DataSource = null;
			dgvClientes.DataSource = clientes;
			dgvClientes.AutoResizeColumns();
			dgvClientes.AutoSizeColumnsMode =
			DataGridViewAutoSizeColumnsMode.AllCells;

		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.Show();
		}
	}
}

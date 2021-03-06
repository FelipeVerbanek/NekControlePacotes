﻿using NekClients.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NekClients.classes;
using NekClients.view;

namespace NekClients
{
	public partial class Cliente : Form
	{
		public int Id_cliente = 0;

		public Cliente()
		{
			InitializeComponent();
			
		
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			DateTime time = DateTime.Now;
			DateTime data_nascimento = DateTime.Parse(txtNascimento.Text);

			ServiceCliente service = new ServiceCliente();
			if (rbFisca.Checked == true && rbJuridica.Checked == false)
			{
				Clientes cliente = new Clientes(txtNome.Text, txtCpf.Text, data_nascimento, time);
				try
				{
					service.InsertClienteFisico(cliente);
					MessageBox.Show("Cliente cadastrado com sucesso!");
					this.Id_cliente = cliente.Id;

				}
				catch (Exception erro)
				{
					MessageBox.Show("Erro [" + erro + "]");
				}
			}
			else if (rbFisca.Checked == false && rbJuridica.Checked == true)
			{
				Clientes cliente = new Clientes(txtNome.Text, txtCnpj.Text, time);
				try
				{
					service.InsertClienteJuridico(cliente);
					MessageBox.Show("Cliente cadastrado com sucesso!");
				}
								catch (Exception erro)
				{
					MessageBox.Show("Erro [" + erro + "]");
				}
			}
		}

		private void btnEndereco_Click(object sender, EventArgs e)
		{
			if (this.Id_cliente > 0)
			{ 
				CadEndereco cadEndereco = new CadEndereco(this.Id_cliente);
				cadEndereco.Show();
			}
			else{
				MessageBox.Show("Favor salve as informações antes de acessar o cadastro de endereço!");

			}
		}
	}
}

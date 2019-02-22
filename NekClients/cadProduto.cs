using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NekClients
{
	public partial class cadProduto : Form
	{
		public cadProduto()
		{
			InitializeComponent();
			carregacbCategoria();


		}
		//FORMATAÇÃO DO CAMPO VALOR PARA R$
		private void txtValor_Leave(object sender, EventArgs e)
		{
			
		}


		//FORMATAÇÃO DO CAMPO VALOR PARA R$
		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0' || e.KeyChar > '9') &&
				(e.KeyChar != ',' && e.KeyChar != '.' &&
				e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
			{
				e.KeyChar = (Char)0;
			}else{
				if (e.KeyChar == '.' || e.KeyChar == ',')
				{
					if (!txtValor.Text.Contains(','))
					{
						e.KeyChar = ',';
					}
					else
					{
						e.KeyChar = (Char)0;
					}
				}
			}	
		}
		//FORMATAÇÃO DO CAMPO VALOR PARA R$	
		private void txtValor_Enter(object sender, EventArgs e)
			{
			String x = "";
			for (int i = 0; i <= txtValor.Text.Length - 1; i++)
			{
				if ((txtValor.Text[i] >= '0' &&
					txtValor.Text[i] <= '9') ||
					txtValor.Text[i] == ',')
				{
					x += txtValor.Text[i];
				}
			}
			txtValor.Text = x;
			txtValor.SelectAll();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			produtos produtos = new produtos();
			produtos.NomeProduto = txtProduto.Text;
			produtos.ValorProduto = txtValor.Text;
			produtos.Categoria = (int) cbCategoria.SelectedValue;

			Conexao conexao = new Conexao();
			produtoDAL dal = new produtoDAL(conexao);
			try { dal.insert(produtos);
				MessageBox.Show("Produto cadastrado com sucesso!");
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro [" + erro + "]");
			}


			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		public void carregacbCategoria()
		{
			Conexao conexao = new Conexao();
			CategoriaProduto catProduto = new CategoriaProduto(conexao);
			List<Categoria> categoria = catProduto.ListarCategoriasCombo();

			/* 
			  OBS: NA PROPRIEDADE cmbCategoria DataBindings o Text tem que estar (none)
			  DataSource (o que vai ser carregado) --> Aqui esta pegando a Lista de categorias, preenchidas 
			  com o select do  método ListarCategoriasCombo
			  DisplayMember = "nomeCategoria" -->  o campo que vai carregar da tablea (exibir no combo) tem que ser igual ao do SQL
			  cmbCategoria.ValueMember --> o valor que vai retornar pra programacao
			  SelectedValue = "idProduto"  --> gravar na FK da tabela Produto, e passa para o produto (inserir)           
			 */

			this.cbCategoria.DataSource = categoria;
			this.cbCategoria.DisplayMember = "nome";
			this.cbCategoria.ValueMember = "id_categoria";


		}

		private void cbCategoria_DropDown(object sender, EventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekClients {

	class produtos
	{
		private string nome;
		private string valor;
		private int id_categoria;
		private int codigo;

		public produtos()
		{
			this.nome = "";
			this.valor = "";
			this.id_categoria = 0;
		}

		public produtos(string nome, string valor, int id_categoria)
		{
			this.nome = nome;
			this.valor = valor;
			this.id_categoria = id_categoria;
		}

		public string NomeProduto {
			get { return this.nome; }
			private set { this.nome = value; }
		}

		public string ValorProduto {
			get { return this.valor ; }
			private set { this.valor = value; }
		}
		public int Categoria {
			get { return this.id_categoria; }
			private set { this.id_categoria = value; }
		}
		public int Codigo
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}

		public static bool ValidaCampos(string nomeProd, string valorProd)
		{
			if (String.IsNullOrWhiteSpace(nomeProd))
			{
				MessageBox.Show("Favor informe o nome do produto!");
				return false;
			}
			if (String.IsNullOrWhiteSpace(valorProd))
			{
				MessageBox.Show("Favor informe o valor do produto!");
				return false;
			}

			return true;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients{

	class produtoDAL
	{
		private Conexao objConexao;


		public produtoDAL(Conexao conexao)
		{
			this.objConexao = conexao;
		}

		public void insert(produtos produtos)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = "insert into produto (nome, valor, id_categoria) values " +
				"(@nome, @valor, @id_categoria);";
			cmd.Parameters.AddWithValue("@nome",produtos.NomeProduto);
			cmd.Parameters.AddWithValue("@valor", produtos.ValorProduto);
			cmd.Parameters.AddWithValue("@id_categoria", produtos.Categoria);
			objConexao.Conectar();
			cmd.ExecuteScalar();
			objConexao.Desconectar();
		}



	}
}

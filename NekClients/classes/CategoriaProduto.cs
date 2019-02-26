using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients
{

	class CategoriaProduto
{
		private Conexao objConexao;



		public CategoriaProduto(Conexao conexao)
		{
			this.objConexao = conexao;
		}

		public List<Categoria> ListarCategoriasCombo()
		{
			
			// select que vai ao banco e retorna a consulta já ordenada
			string _SQL = @"select 
                        id_categoria,nome
                        from categoria
                        order by id_categoria";
			//mandar instrucoes ao sql  (Command)

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = _SQL;
			this.objConexao.Conectar();
			SqlDataReader dr = cmd.ExecuteReader();
			List<Categoria> categorias = new List<Categoria>();
			// quando acabar as linhas que retornou da consulta, sai do While
			while (dr.Read())
			{
				Categoria cat = new Categoria();
				cat.id_categoria = dr.GetInt32(dr.GetOrdinal("id_categoria"));
				cat.nome = dr.GetString(dr.GetOrdinal("nome"));
				categorias.Add(cat);
			}

			cmd.Connection.Close();
			cmd.Dispose();
			this.objConexao.Desconectar();
			return categorias;

		}
	}
}

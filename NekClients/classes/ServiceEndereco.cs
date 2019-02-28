using NekClients.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients.classes
{
	class ServiceEndereco
	{
		private Conexao objConexao;

		public ServiceEndereco()
		{
			Conexao conexao = new Conexao();
			this.objConexao = conexao;
		}

		public void InsertClienteFisico(Endereco endereco)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = "insert into cliente (id_cliente, cidade, cep, uf, rua, numero, bairro, complemento) values " +
				"(@id_cliente, @cidade, @cep, @uf, @rua, @numero, @bairro, @complemento);";

			cmd.Parameters.AddWithValue("@id_cliente", endereco.Id_cliente);
			cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
			cmd.Parameters.AddWithValue("@cep", endereco.Cep);
			cmd.Parameters.AddWithValue("@uf", endereco.Uf);
			cmd.Parameters.AddWithValue("@rua", endereco.Rua);
			cmd.Parameters.AddWithValue("@numero", endereco.Numero);
			cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
			cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);

			objConexao.Conectar();
			cmd.ExecuteScalar();
			objConexao.Desconectar();
		}
	}
}

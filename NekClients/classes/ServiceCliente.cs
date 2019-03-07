using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekClients.Entities;

namespace NekClients.classes
	{

	class ServiceCliente
	{
		private Conexao objConexao;

		public ServiceCliente()
		{
			Conexao conexao = new Conexao();
			this.objConexao = conexao;
		}
		//LISTA OS CLIENTES PARA APARECER NO FORM DE LISTA DE CLIENTES
		public List<Clientes> ListarClientes()
		{
			String sql = @"select id_cliente, nome, cpf, cnpj, data_nacimento, data_cadastro from cliente";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = sql;
			this.objConexao.Conectar();

			SqlDataReader r = cmd.ExecuteReader();
			List<Clientes> LstCliente = new List<Clientes>();

			while (r.Read())
			{
				Clientes cliente = new Clientes();
				cliente.Id = r.GetInt32(r.GetOrdinal("id_cliente"));
				cliente.NomeCliente = r.GetString(r.GetOrdinal("nome"));
				if (!r.IsDBNull(r.GetOrdinal("cpf"))) cliente.Cpf = r.GetString(r.GetOrdinal("cpf"));
				if (!r.IsDBNull(r.GetOrdinal("cnpj"))) cliente.Cpf = r.GetString(r.GetOrdinal("cnpj"));
				if (!r.IsDBNull(r.GetOrdinal("data_nacimento"))) cliente.DataCadastro = r.GetDateTime(r.GetOrdinal("data_nacimento"));
				cliente.DataCadastro = r.GetDateTime(r.GetOrdinal("data_cadastro"));

				LstCliente.Add(cliente);

			}

			cmd.Connection.Close();
			cmd.Dispose();
			this.objConexao.Desconectar();

			return LstCliente;
		}

		internal static string RetornaNomeClient(int id_cliente)
		{
			throw new NotImplementedException();
		}

		//INSERT DO CADASTRO DE CLIENTE
		public void InsertClienteFisico(Clientes cliente)
		{

			cliente.Id = buscar_id();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = "insert into cliente (id_cliente, nome, cpf, data_nacimento, data_cadastro) values " +
				"(@id_cliente, @nome, @cpf, @data_nacimento, @data_cadastro);";
			cmd.Parameters.AddWithValue("@nome", cliente.NomeCliente);
			cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
			cmd.Parameters.AddWithValue("@data_nacimento", cliente.DataNascimento);
			cmd.Parameters.AddWithValue("@data_cadastro", cliente.DataCadastro);
			cmd.Parameters.AddWithValue("@id_cliente", cliente.Id);
			objConexao.Conectar();
			cmd.ExecuteScalar();
			objConexao.Desconectar();
		}

		//Autor: Felipe Verbanek
		//Data: 06/03/2019
		//insert client into database
		public void InsertClienteJuridico(Clientes cliente)
		{
			cliente.Id = buscar_id();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = "insert into cliente (id_cliente,nome, cnpj, data_cadastro) values " +
				"(@nome, @cnpj, @data_cadastro);";
			cmd.Parameters.AddWithValue("@nome", cliente.NomeCliente);
			cmd.Parameters.AddWithValue("@cnpj", cliente.Cnpj);
			cmd.Parameters.AddWithValue("@data_cadastro", cliente.DataCadastro);
			cmd.Parameters.AddWithValue("@id_cliente", cliente.Id);
			objConexao.Conectar();
			cmd.ExecuteScalar();
			objConexao.Desconectar();

		}

		//Autor: Felipe Verbanek
		//Data: 06/03/2019
		//Return last client code
		private int buscar_id()
		{
			int id;
			
			String sql = @"select max(id_cliente) as id from cliente";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = sql;
			this.objConexao.Conectar();

			SqlDataReader r = cmd.ExecuteReader();
			r.Read();
			id = r.GetInt32(r.GetOrdinal("id"));
			id += 1;
			objConexao.Desconectar();
			return id;
		}



	}
}

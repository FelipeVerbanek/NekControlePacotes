using NekClients.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		public void InsertEndereco(Endereco endereco)
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
		public static bool ValidaCampos( string cidade, string uf, string rua, string number, string bairro) {
			if (String.IsNullOrWhiteSpace(cidade))
			{
				MessageBox.Show("Favor informe o nome da cidade!");
				return false;
			}
			else if (String.IsNullOrWhiteSpace(uf))
			{
				MessageBox.Show("Favor informar a UF!");
				return false;
			}
			else if (String.IsNullOrWhiteSpace(rua))
			{
				MessageBox.Show("Favor informar a rua!");
				return false;
			}
			else if (String.IsNullOrWhiteSpace(number))
			{
				MessageBox.Show("Favor o número do endereço!");
				return false;
			}
			else if (String.IsNullOrWhiteSpace(bairro))
			{
				MessageBox.Show("Favor informar o bairro!");
				return false;
			}
			else
			{
				return true;
			}
		}

		public  string RetornaNomeClient(int id_cliente)
		{
			Conexao conexao = new Conexao();
			this.objConexao = conexao;
			String sql = @"select nome from cliente where id_cliente = " + id_cliente;
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = objConexao.ObjetoConexao;
			cmd.CommandText = sql;
			this.objConexao.Conectar();

			SqlDataReader r = cmd.ExecuteReader();
			r.Read();

			return r.GetString(r.GetOrdinal("nome"));

		}
	}
}

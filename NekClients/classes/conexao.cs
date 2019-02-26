using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients
{
	class Conexao
	{
		private String _stringConexao;
		private SqlConnection _conexao;
		private String dadosConexao;


		public Conexao()

		{
			this.dadosConexao =  "Data Source=FELIPE-PC;Initial Catalog=nek;Integrated Security=True";
			this._conexao = new SqlConnection();
			this._stringConexao = this.dadosConexao;
			this._conexao.ConnectionString = this.dadosConexao;
		}

		public String StringConexao
		{
			get { return this._stringConexao; }
			set { this._stringConexao = value; }
		}

		public SqlConnection ObjetoConexao
		{
			get { return this._conexao; }
			set { this._conexao = value; }

		}
		public void Conectar()
		{
			this._conexao.Open();
		}

		public void Desconectar()
		{
			this._conexao.Close();
		}

		public static implicit operator SqlConnection(Conexao v)
		{
			throw new NotImplementedException();
		}
	}
}

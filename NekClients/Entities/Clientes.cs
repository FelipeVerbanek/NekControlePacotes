using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients.Entities
{
	class Clientes
	{
		public int Id { get;  set; }
		public string NomeCliente { get;  set; }
		public string Cpf { get;  set; }
		public string Cnpj { get;  set; }
		public DateTime DataNascimento { get;  set; }
		public DateTime DataCadastro { get;  set; }

		public Clientes()
		{
		}

		public Clientes(string nomeCliente, string cpf, DateTime dataNascimento, DateTime dataCadastro)
		{
			NomeCliente = nomeCliente;
			Cpf = cpf;
			DataNascimento = dataNascimento;
			DataCadastro = dataCadastro;
		}

		public Clientes(string nomeCliente, string cnpj, DateTime dataCadastro)
		{
			NomeCliente = nomeCliente;
			Cnpj = cnpj;
			DataCadastro = dataCadastro;
		}
	}
}

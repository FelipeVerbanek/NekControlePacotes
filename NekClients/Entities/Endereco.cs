using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekClients.Entities
{
	class Endereco
	{
		public int Id_endereco { get; set; }
		public int Id_cliente { get; set; }
		public string Cidade { get; set; }
		public string Cep { get; set; }
		public string Uf { get; set; }
		public string Rua { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public string Complemento { get; set; }

		public Endereco()
		{
		}

		public Endereco(int id_cliente, string cidade, string cep, string uf, string rua, string numero, string bairro, string complemento)
		{
			Id_cliente = id_cliente;
			Cidade = cidade;
			Cep = cep;
			Uf = uf;
			Rua = rua;
			Numero = numero;
			Bairro = bairro;
			Complemento = complemento;
		}
	}
}

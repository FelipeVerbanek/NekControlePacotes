using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekClients
{
	public partial class listProdutos : Form
	{
		class ClsLista
		{
			public int id_produto { get; set; }
			public String categoria  { get; set; }         
			public String nome       { get; set; }
			public String valor      { get; set; }

		}

		class ClsRecupera
		{
			private Conexao objConexao;


			public ClsRecupera(Conexao conexao)
			{
				this.objConexao = conexao;
			}

			public  List<ClsLista> ListarProdutos()
			{
				String sql = @"select id_produto, 
										(select nome from categoria where id_categoria = a.id_categoria) as categoria,
										a.nome,
										a.valor from produto a";
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = objConexao.ObjetoConexao;
				cmd.CommandText = sql;
				this.objConexao.Conectar();

				SqlDataReader r = cmd.ExecuteReader();
				List<ClsLista> LstProdutos = new List<ClsLista>();

				while (r.Read())
				{
					ClsLista prod = new ClsLista();
					prod.id_produto = r.GetInt32(r.GetOrdinal("id_produto"));
					prod.categoria = r.GetString(r.GetOrdinal("categoria"));
					prod.nome = r.GetString(r.GetOrdinal("nome"));
					prod.valor = r.GetString(r.GetOrdinal("valor"));
					LstProdutos.Add(prod);
				}

				cmd.Connection.Close();
				cmd.Dispose();
				this.objConexao.Desconectar();

				return LstProdutos;
			}
		}

		public listProdutos()
		{
			InitializeComponent();
			recuperaLista();
		}


		private void btnNovo_Click(object sender, EventArgs e)
		{
			cadProduto cadProd = new cadProduto();
			cadProd.Show();
		}

		public void recuperaLista()
		{
			Conexao conexao = new Conexao();
			ClsRecupera listProduto = new ClsRecupera(conexao);
			List<ClsLista> produtos = listProduto.ListarProdutos();

			DVG_Dados.DataSource = null;
			DVG_Dados.DataSource = produtos;
			DVG_Dados.AutoResizeColumns();
			DVG_Dados.AutoSizeColumnsMode =
			DataGridViewAutoSizeColumnsMode.AllCells;
		}

		private void DVG_Dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void listProdutos_Load(object sender, EventArgs e)
		{

		}
	}
}

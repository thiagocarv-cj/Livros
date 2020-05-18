using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Livros
{
	public class ConexaoBanco
	{
		private const string sqlConn = // @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
		@"Data Source = .\SQLEXPRESS;Initial Catalog = livros; Persist Security Info=True;User ID = Thiago; Password=tina0105";

		private string pegasql = "";
		SqlConnection cnx = null;

		

		#region Métodos de conexão

		private bool Abrirconexao()
		{
			cnx = new SqlConnection(sqlConn);
			try
			{

				cnx.Open();
				return true;

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
				return false;
			}

		}

		private bool Fecharconexao()
		{
			if (cnx.State != ConnectionState.Closed)
			{
				cnx.Close();
				cnx.Dispose();
				return true;
			}
			else
			{
				cnx.Dispose();
				return false;
			}
		}

		#endregion


		// métodos de cadastro utilizando Array List

		#region Cadastros nas tabelas Discos, Amigos

		public bool CadastrarLivros(ArrayList p_cadDiscos)
		{
			SqlCommand cadastrarlivros = null;
			if (this.Abrirconexao())
			{
				try
				{
					cadastrarlivros = new SqlCommand("INSERT INTO " +
						"Cadastro (id , nome , ano, editora, resumo)"+
   "					 VALUES (@id , @nome, @ano , @editora)", cnx);
					cadastrarlivros.Parameters.Add(new SqlParameter("@id", p_cadDiscos[0]));
					cadastrarlivros.Parameters.Add(new SqlParameter("@nome", p_cadDiscos[1]));
					cadastrarlivros.Parameters.Add(new SqlParameter("@ano", p_cadDiscos[2]));
					cadastrarlivros.Parameters.Add(new SqlParameter("@editora", p_cadDiscos[3]));
					
					cadastrarlivros.ExecuteNonQuery();
					return true;
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					this.Fecharconexao();
				}
			}
			else
			{
				return false;
			}

		}
		#endregion

		#region Preenchimento dos comboboxs

		public List<string> prcombo_Categoria()
		{
			SqlCommand listarCategoria = null;

			List<string> comboCategoria = new List<string>();
			if (this.Abrirconexao())
			{
				try
				{
					listarCategoria = new SqlCommand("Select nome from Categoria", cnx);
					SqlDataReader dr = listarCategoria.ExecuteReader();

					while (dr.Read())
					{
						comboCategoria.Add(dr["nome"].ToString());
					}
					return comboCategoria;

				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					this.Fecharconexao();
				}
			}
			else
			{
				return null;
			}
		}

		#endregion

		public bool CadastrarCategorias(string p_CadCategoria)
		{
			SqlCommand cadastrarcategorias = null;
			if (this.Abrirconexao())
			{
				try
				{
					cadastrarcategorias = new SqlCommand("Insert Into Categoria (nome) values (@N)", cnx);
					cadastrarcategorias.Parameters.Add(new SqlParameter("@N", p_CadCategoria));
					
					cadastrarcategorias.ExecuteNonQuery();
					MessageBox.Show("Cadastro efetuado!");

					return true;
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					this.Fecharconexao();
				}
			}
			else
			{
				return false;
			}
		}
	}
}

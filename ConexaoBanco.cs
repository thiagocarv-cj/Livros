﻿using System;
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
						"Cadastro (id , nome , ano, editora, resumo)" +
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

		#region Preencher grids
		public DataTable PreencheGridCategorias()
		{
			SqlCommand pegaCategorias = null;

			if (this.Abrirconexao())
			{
				string sql = "select id, nome As [Categoria] from Categoria";
				try
				{
					pegaCategorias = new SqlCommand(sql, cnx);
					SqlDataAdapter adp = new SqlDataAdapter(pegaCategorias);
					DataTable dt = new DataTable();
					adp.Fill(dt);
					//pegaCategorias.ExecuteNonQuery();
					return dt;


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

		#region comandos insert


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

		#endregion

		#region comandos delete

		public bool DeletarCategorias(int p_ExcluiCategoria)
		{
			SqlCommand excluircategorias = null;
			if (this.Abrirconexao())
			{
				try
				{
					excluircategorias = new SqlCommand("Delete from Categoria where id = (@i)", cnx);
					excluircategorias.Parameters.Add(new SqlParameter("@i", p_ExcluiCategoria));

					excluircategorias.ExecuteNonQuery();
					
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

		#region alterações

		public bool AlterarCategorias(int p_idCategoria, string p_nomeCategoria)
		{
			SqlCommand alterarcategorias = null;
			if (this.Abrirconexao())
			{
				try
				{
					alterarcategorias = new SqlCommand("Update Categoria set nome = @n where id = @i", cnx);
					alterarcategorias.Parameters.Add(new SqlParameter("@i", p_idCategoria));
					alterarcategorias.Parameters.Add(new SqlParameter("@n", p_nomeCategoria));

					alterarcategorias.ExecuteNonQuery();

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

		#region Consultas

		public DataTable GridPesq(string nome)
		{
			SqlCommand dgv_Cat = null;

			if (this.Abrirconexao())
			{
				string sql = " Select id, nome as [Categoria] from Categoria where nome like @n";

				try
				{
					dgv_Cat = new SqlCommand(sql, cnx);
					dgv_Cat.Parameters.Add("@n", "%" + nome + "%");
					SqlDataAdapter adp = new SqlDataAdapter(dgv_Cat);
					DataTable dt = new DataTable();
					adp.Fill(dt);
					//dgvEmp.ExecuteNonQuery();
					return dt;
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
	}
}

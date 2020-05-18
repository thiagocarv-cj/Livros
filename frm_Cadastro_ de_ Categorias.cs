using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livros
{
	public partial class frm_Cadastro__de__Categorias : Form
	{
		public frm_Cadastro__de__Categorias()
		{
			InitializeComponent();
		}

		ConexaoBanco passa = new ConexaoBanco();
		int id;
		string texto;

		public void grava()
		{
			
			string lista;

			lista = txt_Categoria.Text;

			passa.CadastrarCategorias(lista);


		}

		private void btn_Alterar_Click(object sender, EventArgs e)
		{
			texto = txt_Categoria.Text;
			passa.AlterarCategorias(id, texto);
			if (passa.AlterarCategorias(1,""))
			{
				MessageBox.Show("Alterado com Sucesso");
				frm_Cadastro__de__Categorias_Load(e, e);
				btn_Cadastrar.Enabled = true;
				btn_Excluir.Enabled = true;
				txt_Categoria.Text = "";
				txt_Categoria.Focus();
			}
		}

		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			grava();
			frm_Cadastro__de__Categorias_Load(e, e);
		}

		public void pega_cell()
		{
			// vamos obter a linha da célula selecionada
			DataGridViewRow linhaAtual = dgv_Categorias.CurrentRow;

			// vamos exibir o índice da linha atual
			int indice = linhaAtual.Index;
			id = int.Parse(dgv_Categorias.Rows[indice].Cells[0].Value.ToString());
			texto = dgv_Categorias.Rows[indice].Cells[1].Value.ToString();

		}

		private void btn_Excluir_Click(object sender, EventArgs e)
		{
			pega_cell();
			passa.DeletarCategorias(id);		
			if(passa.DeletarCategorias(1))
			{
				MessageBox.Show("Excluido com Sucesso");
				frm_Cadastro__de__Categorias_Load(e, e);
				btn_Cadastrar.Enabled = true;
				btn_Alterar.Enabled = true;
				txt_Categoria.Text = "";
				txt_Categoria.Focus();
			}
		}

				

		private void frm_Cadastro__de__Categorias_Load(object sender, EventArgs e)
		{
			dgv_Categorias.DataSource = passa.PreencheGridCategorias();
			dgv_Categorias.Columns[0].Visible = false;
			dgv_Categorias.Columns[1].Width = 423;
		}

		private void dgv_Categorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(MessageBox.Show("Deseja excluir??", "O que deseja fazer",
				MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				pega_cell();
				txt_Categoria.Text = texto;
				btn_Alterar.Enabled = false;
				btn_Cadastrar.Enabled = false;
			}
			else
			{
				if (MessageBox.Show("Deseja alterar??", "O que deseja fazer",
				MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					pega_cell();
					txt_Categoria.Text = texto;
					btn_Excluir.Enabled = false;
					btn_Cadastrar.Enabled = false;
				}

			}
			

		}

		private void btn_Pesquisar_Click(object sender, EventArgs e)
		{
			dgv_Categorias.DataSource = passa.GridPesq(txt_Categoria.Text);
			dgv_Categorias.Columns[0].Visible = false;
			dgv_Categorias.Columns[1].Width = 423;
		}
	}
}

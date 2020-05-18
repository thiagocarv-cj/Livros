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

		public void grava()
		{
			
			string lista;

			lista = txt_Categoria.Text;

			passa.CadastrarCategorias(lista);


		}

		private void btn_Alterar_Click(object sender, EventArgs e)
		{

		}

		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			grava();
		}

		public void pega_cell()
		{
			// vamos obter a linha da célula selecionada
			DataGridViewRow linhaAtual = dgv_Categorias.CurrentRow;

			// vamos exibir o índice da linha atual
			int indice = linhaAtual.Index;
			id = int.Parse(dgv_Categorias.Rows[indice].Cells[0].Value.ToString());

		}

		private void btn_Excluir_Click(object sender, EventArgs e)
		{
			pega_cell();
			passa.DeletarCategorias(id);		
			if(passa.DeletarCategorias(1))
			{
				MessageBox.Show("Excluido com Sucesso");
			}
		}

				

		private void frm_Cadastro__de__Categorias_Load(object sender, EventArgs e)
		{
			dgv_Categorias.DataSource = passa.PreencheGridCategorias();
			dgv_Categorias.Columns[0].Visible = false;
			dgv_Categorias.Columns[1].Width = 423;
		}
	}
}

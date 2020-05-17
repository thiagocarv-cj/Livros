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
		int excluir = 0;
		string alterar = "";

		public void grava()
		{
			
			string lista;
			if (txt_Categoria.Text != "")
			{
				lista = txt_Categoria.Text;
				passa.CadastrarCategorias(lista);
			}
			else
			{
				MessageBox.Show("Digite uma categoria !");
			}

		}

		private void frm_Cadastro__de__Categorias_Load(object sender, EventArgs e)
		{
			dgvCategoria.DataSource = passa.GridCategoria();
			dgvCategoria.Columns[0].Visible = false;
			dgvCategoria.Columns[1].Width = 420;
		}

		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			grava();
			frm_Cadastro__de__Categorias_Load(e, e);
			txt_Categoria.Text = "";
			txt_Categoria.Focus();
			btn_Cadastrar.Visible = false;
			btn_Novo.Location = new Point(159,92);
			btn_Novo.Visible = true;
		}

		private void btn_Novo_Click(object sender, EventArgs e)
		{
			btn_Novo.Visible = false;
			btn_Cadastrar.Visible = true;
		}

		private void btn_Excluir_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Deseja Excluir a Categoria?", "Confirme sua Opção !", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				passa.ExcluirCategorias(excluir);
				btn_Alterar.Enabled = true;

				if (passa.ExcluirCategorias(1))
				{
					MessageBox.Show("Excluido com sucesso");
				}
			}
			
		}

		private void dgvCategoria_DoubleClick(object sender, EventArgs e)
		{
			// vamos obter a linha da célula selecionada
			DataGridViewRow linhaAtual = dgvCategoria.CurrentRow;

			// vamos exibir o índice da linha atual
			int indice = linhaAtual.Index;

			if (MessageBox.Show("Deseja excluir", "O que quer fazer ?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				txt_Categoria.Text = dgvCategoria.Rows[indice].Cells[1].Value.ToString();
				excluir = Convert.ToInt16(dgvCategoria.Rows[indice].Cells[0].Value);
				btn_Alterar.Enabled = false;
			}
			else
			{
				if (MessageBox.Show("Deseja alterar então", "O que quer fazer ?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					txt_Categoria.Text = dgvCategoria.Rows[indice].Cells[1].Value.ToString();
					excluir = Convert.ToInt16(dgvCategoria.Rows[indice].Cells[0].Value);
					btn_Excluir.Enabled = false;

				}
			}

			
		}

		private void btn_Alterar_Click(object sender, EventArgs e)
		{
			alterar = txt_Categoria.Text;
			if (MessageBox.Show("Deseja Alterar a Categoria?", "Confirme sua Opção !",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				passa.AlterarCategorias(excluir, alterar);
				btn_Excluir.Enabled = true;
			}

			frm_Cadastro__de__Categorias_Load(e,e);
		}
	}
}

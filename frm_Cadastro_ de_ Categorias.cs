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

		public void grava()
		{
			
			string lista;

			lista = txt_Categoria.Text;

			passa.CadastrarCategorias(lista);


		}

		private void button1_Click(object sender, EventArgs e)
		{
			grava();
			
		}
	}
}

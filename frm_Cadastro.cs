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
	public partial class frm_Cadastro : Form
	{
		public frm_Cadastro()
		{
			InitializeComponent();
		}

		public void passaValoresParaCombobox()
		{
			
			ConexaoBanco Categoria = new ConexaoBanco();
			cb_Categoria.DataSource = Categoria.prcombo_Categoria();
			cb_Categoria.DisplayMember = "Nome";
			cb_Categoria.Text = "N/C";
		}

		public void preenche()
		{
			ConexaoBanco passa = new ConexaoBanco();
			ArrayList lista = new ArrayList();

			lista.Add(txt_Nome.Text);
			lista.Add(txt_Ano.Text);
			lista.Add(txt_Editora.Text);
			lista.Add(rtxt_Resumo.Text);
			lista.Add(cb_Categoria.Text);

		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Sair_ini_Click(object sender, EventArgs e)
		{
			MessageBox.Show("entrou errado né!!");
			this.Close();
		}

		private void frm_Cadastro_Load(object sender, EventArgs e)
		{
			passaValoresParaCombobox();
		}
	}
}

using System;
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
	public partial class frm_Principal : Form
	{
		public frm_Principal()
		{
			InitializeComponent();
		}

		private void btn_Cadastro_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frm_Cadastro__de__Categorias frm = new frm_Cadastro__de__Categorias();
			frm.Show();
		}
	}
}

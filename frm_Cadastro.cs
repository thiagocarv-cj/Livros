﻿using System;
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

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Sair_ini_Click(object sender, EventArgs e)
		{
			MessageBox.Show("entrou errado né!!");
			this.Close();
		}
	}
}

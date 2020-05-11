namespace Livros
{
	partial class frm_Cadastro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gpb_Categoria = new System.Windows.Forms.GroupBox();
			this.btn_Proximo = new System.Windows.Forms.Button();
			this.gpb_Geral = new System.Windows.Forms.GroupBox();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.rtxt_Resumo = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Editora = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Ano = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Salvar = new System.Windows.Forms.Button();
			this.txt_Nome = new System.Windows.Forms.TextBox();
			this.gpb_Inicio = new System.Windows.Forms.GroupBox();
			this.btn_Sair_ini = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cb_Categoria = new System.Windows.Forms.ComboBox();
			this.gpb_Categoria.SuspendLayout();
			this.gpb_Geral.SuspendLayout();
			this.gpb_Inicio.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpb_Categoria
			// 
			this.gpb_Categoria.Controls.Add(this.cb_Categoria);
			this.gpb_Categoria.Controls.Add(this.btn_Proximo);
			this.gpb_Categoria.Location = new System.Drawing.Point(12, 113);
			this.gpb_Categoria.Name = "gpb_Categoria";
			this.gpb_Categoria.Size = new System.Drawing.Size(776, 79);
			this.gpb_Categoria.TabIndex = 0;
			this.gpb_Categoria.TabStop = false;
			this.gpb_Categoria.Text = "Categoria";
			// 
			// btn_Proximo
			// 
			this.btn_Proximo.Location = new System.Drawing.Point(306, 30);
			this.btn_Proximo.Name = "btn_Proximo";
			this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
			this.btn_Proximo.TabIndex = 2;
			this.btn_Proximo.Text = "Próximo";
			this.btn_Proximo.UseVisualStyleBackColor = true;
			// 
			// gpb_Geral
			// 
			this.gpb_Geral.Controls.Add(this.btn_Sair);
			this.gpb_Geral.Controls.Add(this.button3);
			this.gpb_Geral.Controls.Add(this.button2);
			this.gpb_Geral.Controls.Add(this.label4);
			this.gpb_Geral.Controls.Add(this.rtxt_Resumo);
			this.gpb_Geral.Controls.Add(this.label3);
			this.gpb_Geral.Controls.Add(this.txt_Editora);
			this.gpb_Geral.Controls.Add(this.label2);
			this.gpb_Geral.Controls.Add(this.txt_Ano);
			this.gpb_Geral.Controls.Add(this.label1);
			this.gpb_Geral.Controls.Add(this.btn_Salvar);
			this.gpb_Geral.Controls.Add(this.txt_Nome);
			this.gpb_Geral.Location = new System.Drawing.Point(12, 208);
			this.gpb_Geral.Name = "gpb_Geral";
			this.gpb_Geral.Size = new System.Drawing.Size(776, 250);
			this.gpb_Geral.TabIndex = 1;
			this.gpb_Geral.TabStop = false;
			this.gpb_Geral.Text = "Geral";
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(684, 212);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(75, 23);
			this.btn_Sair.TabIndex = 12;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(684, 113);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Visualizar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(684, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Editar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(332, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Resumo:";
			// 
			// rtxt_Resumo
			// 
			this.rtxt_Resumo.Location = new System.Drawing.Point(381, 33);
			this.rtxt_Resumo.Name = "rtxt_Resumo";
			this.rtxt_Resumo.Size = new System.Drawing.Size(271, 187);
			this.rtxt_Resumo.TabIndex = 7;
			this.rtxt_Resumo.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Editora:";
			// 
			// txt_Editora
			// 
			this.txt_Editora.Location = new System.Drawing.Point(64, 143);
			this.txt_Editora.Name = "txt_Editora";
			this.txt_Editora.Size = new System.Drawing.Size(187, 20);
			this.txt_Editora.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ano:";
			// 
			// txt_Ano
			// 
			this.txt_Ano.Location = new System.Drawing.Point(64, 105);
			this.txt_Ano.Name = "txt_Ano";
			this.txt_Ano.Size = new System.Drawing.Size(80, 20);
			this.txt_Ano.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome:";
			// 
			// btn_Salvar
			// 
			this.btn_Salvar.Location = new System.Drawing.Point(684, 39);
			this.btn_Salvar.Name = "btn_Salvar";
			this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
			this.btn_Salvar.TabIndex = 1;
			this.btn_Salvar.Text = "Salvar";
			this.btn_Salvar.UseVisualStyleBackColor = true;
			// 
			// txt_Nome
			// 
			this.txt_Nome.Location = new System.Drawing.Point(64, 66);
			this.txt_Nome.Name = "txt_Nome";
			this.txt_Nome.Size = new System.Drawing.Size(254, 20);
			this.txt_Nome.TabIndex = 0;
			// 
			// gpb_Inicio
			// 
			this.gpb_Inicio.Controls.Add(this.btn_Sair_ini);
			this.gpb_Inicio.Controls.Add(this.button5);
			this.gpb_Inicio.Controls.Add(this.button4);
			this.gpb_Inicio.Controls.Add(this.button1);
			this.gpb_Inicio.Location = new System.Drawing.Point(12, 12);
			this.gpb_Inicio.Name = "gpb_Inicio";
			this.gpb_Inicio.Size = new System.Drawing.Size(776, 79);
			this.gpb_Inicio.TabIndex = 2;
			this.gpb_Inicio.TabStop = false;
			this.gpb_Inicio.Text = "Começar";
			// 
			// btn_Sair_ini
			// 
			this.btn_Sair_ini.Location = new System.Drawing.Point(516, 32);
			this.btn_Sair_ini.Name = "btn_Sair_ini";
			this.btn_Sair_ini.Size = new System.Drawing.Size(102, 23);
			this.btn_Sair_ini.TabIndex = 3;
			this.btn_Sair_ini.Text = "Sair";
			this.btn_Sair_ini.UseVisualStyleBackColor = true;
			this.btn_Sair_ini.Click += new System.EventHandler(this.btn_Sair_ini_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(376, 32);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Imprimir";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(237, 32);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(102, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Lista de Livros";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(124, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Novo";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// cb_Categoria
			// 
			this.cb_Categoria.FormattingEnabled = true;
			this.cb_Categoria.Location = new System.Drawing.Point(37, 32);
			this.cb_Categoria.Name = "cb_Categoria";
			this.cb_Categoria.Size = new System.Drawing.Size(236, 21);
			this.cb_Categoria.TabIndex = 3;
			// 
			// frm_Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 462);
			this.Controls.Add(this.gpb_Inicio);
			this.Controls.Add(this.gpb_Geral);
			this.Controls.Add(this.gpb_Categoria);
			this.Name = "frm_Cadastro";
			this.Text = "Cadastro";
			this.Load += new System.EventHandler(this.frm_Cadastro_Load);
			this.gpb_Categoria.ResumeLayout(false);
			this.gpb_Geral.ResumeLayout(false);
			this.gpb_Geral.PerformLayout();
			this.gpb_Inicio.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gpb_Categoria;
		private System.Windows.Forms.Button btn_Proximo;
		private System.Windows.Forms.GroupBox gpb_Geral;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtxt_Resumo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Editora;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Ano;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Salvar;
		private System.Windows.Forms.TextBox txt_Nome;
		private System.Windows.Forms.GroupBox gpb_Inicio;
		private System.Windows.Forms.Button btn_Sair_ini;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cb_Categoria;
	}
}
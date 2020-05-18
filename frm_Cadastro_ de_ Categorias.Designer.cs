namespace Livros
{
	partial class frm_Cadastro__de__Categorias
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
			this.txt_Categoria = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Excluir = new System.Windows.Forms.Button();
			this.btn_Pesquisar = new System.Windows.Forms.Button();
			this.dgv_Categorias = new System.Windows.Forms.DataGridView();
			this.btn_Cadastrar = new System.Windows.Forms.Button();
			this.btn_Alterar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Categorias)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_Categoria
			// 
			this.txt_Categoria.Location = new System.Drawing.Point(145, 57);
			this.txt_Categoria.Name = "txt_Categoria";
			this.txt_Categoria.Size = new System.Drawing.Size(368, 20);
			this.txt_Categoria.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Categoria:";
			// 
			// btn_Excluir
			// 
			this.btn_Excluir.Location = new System.Drawing.Point(321, 92);
			this.btn_Excluir.Name = "btn_Excluir";
			this.btn_Excluir.Size = new System.Drawing.Size(75, 20);
			this.btn_Excluir.TabIndex = 2;
			this.btn_Excluir.Text = "Excluir";
			this.btn_Excluir.UseVisualStyleBackColor = true;
			this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
			// 
			// btn_Pesquisar
			// 
			this.btn_Pesquisar.Location = new System.Drawing.Point(402, 92);
			this.btn_Pesquisar.Name = "btn_Pesquisar";
			this.btn_Pesquisar.Size = new System.Drawing.Size(75, 20);
			this.btn_Pesquisar.TabIndex = 3;
			this.btn_Pesquisar.Text = "Pesquisar";
			this.btn_Pesquisar.UseVisualStyleBackColor = true;
			this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
			// 
			// dgv_Categorias
			// 
			this.dgv_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Categorias.Location = new System.Drawing.Point(87, 128);
			this.dgv_Categorias.Name = "dgv_Categorias";
			this.dgv_Categorias.RowHeadersVisible = false;
			this.dgv_Categorias.Size = new System.Drawing.Size(426, 150);
			this.dgv_Categorias.TabIndex = 4;
			this.dgv_Categorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Categorias_CellDoubleClick);
			// 
			// btn_Cadastrar
			// 
			this.btn_Cadastrar.Location = new System.Drawing.Point(159, 92);
			this.btn_Cadastrar.Name = "btn_Cadastrar";
			this.btn_Cadastrar.Size = new System.Drawing.Size(75, 20);
			this.btn_Cadastrar.TabIndex = 5;
			this.btn_Cadastrar.Text = "Cadastrar";
			this.btn_Cadastrar.UseVisualStyleBackColor = true;
			this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
			// 
			// btn_Alterar
			// 
			this.btn_Alterar.Location = new System.Drawing.Point(240, 92);
			this.btn_Alterar.Name = "btn_Alterar";
			this.btn_Alterar.Size = new System.Drawing.Size(75, 20);
			this.btn_Alterar.TabIndex = 6;
			this.btn_Alterar.Text = "Alterar";
			this.btn_Alterar.UseVisualStyleBackColor = true;
			this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
			// 
			// frm_Cadastro__de__Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 318);
			this.Controls.Add(this.btn_Alterar);
			this.Controls.Add(this.btn_Cadastrar);
			this.Controls.Add(this.dgv_Categorias);
			this.Controls.Add(this.btn_Pesquisar);
			this.Controls.Add(this.btn_Excluir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Categoria);
			this.Name = "frm_Cadastro__de__Categorias";
			this.Text = "Cadastro de Categorias";
			this.Load += new System.EventHandler(this.frm_Cadastro__de__Categorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Categorias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Categoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Excluir;
		private System.Windows.Forms.Button btn_Pesquisar;
		private System.Windows.Forms.DataGridView dgv_Categorias;
		private System.Windows.Forms.Button btn_Cadastrar;
		private System.Windows.Forms.Button btn_Alterar;
	}
}
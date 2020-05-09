namespace Livros
{
	partial class frm_Principal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Cadastro = new System.Windows.Forms.Button();
			this.btn_Procura = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Cadastro
			// 
			this.btn_Cadastro.Location = new System.Drawing.Point(155, 113);
			this.btn_Cadastro.Name = "btn_Cadastro";
			this.btn_Cadastro.Size = new System.Drawing.Size(75, 23);
			this.btn_Cadastro.TabIndex = 0;
			this.btn_Cadastro.Text = "Cadastro";
			this.btn_Cadastro.UseVisualStyleBackColor = true;
			this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
			// 
			// btn_Procura
			// 
			this.btn_Procura.Location = new System.Drawing.Point(462, 113);
			this.btn_Procura.Name = "btn_Procura";
			this.btn_Procura.Size = new System.Drawing.Size(75, 23);
			this.btn_Procura.TabIndex = 1;
			this.btn_Procura.Text = "Procura";
			this.btn_Procura.UseVisualStyleBackColor = true;
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(314, 184);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(75, 23);
			this.btn_Sair.TabIndex = 2;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = true;
			// 
			// frm_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 332);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Procura);
			this.Controls.Add(this.btn_Cadastro);
			this.Name = "frm_Principal";
			this.Text = "Principal";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Cadastro;
		private System.Windows.Forms.Button btn_Procura;
		private System.Windows.Forms.Button btn_Sair;
	}
}


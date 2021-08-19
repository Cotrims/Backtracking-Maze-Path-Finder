namespace apLabirintoBacktracking
{
    partial class frmLabirintoBacktracking
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.dgvLabirinto = new System.Windows.Forms.DataGridView();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(573, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(120, 51);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncontrar.Location = new System.Drawing.Point(699, 12);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(162, 51);
            this.btnEncontrar.TabIndex = 1;
            this.btnEncontrar.Text = "Encontrar caminhos";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // dgvLabirinto
            // 
            this.dgvLabirinto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLabirinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabirinto.ColumnHeadersVisible = false;
            this.dgvLabirinto.Enabled = false;
            this.dgvLabirinto.Location = new System.Drawing.Point(12, 88);
            this.dgvLabirinto.Name = "dgvLabirinto";
            this.dgvLabirinto.ReadOnly = true;
            this.dgvLabirinto.RowHeadersVisible = false;
            this.dgvLabirinto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLabirinto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLabirinto.Size = new System.Drawing.Size(397, 384);
            this.dgvLabirinto.TabIndex = 2;
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.AllowUserToAddRows = false;
            this.dgvCaminhos.AllowUserToDeleteRows = false;
            this.dgvCaminhos.AllowUserToResizeRows = false;
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.ColumnHeadersVisible = false;
            this.dgvCaminhos.Location = new System.Drawing.Point(418, 88);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.ReadOnly = true;
            this.dgvCaminhos.RowHeadersVisible = false;
            this.dgvCaminhos.Size = new System.Drawing.Size(443, 384);
            this.dgvCaminhos.TabIndex = 3;
            this.dgvCaminhos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminhos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Labirinto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caminhos encontrados";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // frmLabirintoBacktracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCaminhos);
            this.Controls.Add(this.dgvLabirinto);
            this.Controls.Add(this.btnEncontrar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frmLabirintoBacktracking";
            this.Text = "Caminhos em Labirinto ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.DataGridView dgvLabirinto;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}


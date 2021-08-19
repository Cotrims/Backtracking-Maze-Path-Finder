using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apLabirintoBacktracking
{
    class Labirinto
    {
        char[,] labirinto;
        int linhas;
        int colunas;

        //Construtor da classe Labirinto-monta a matriz do labirinto através do arquivo
        public Labirinto(string arquivo)
        {
            var leitor = new StreamReader(arquivo);

            colunas = int.Parse(leitor.ReadLine());
            linhas = int.Parse(leitor.ReadLine());

            labirinto = new char[linhas,colunas];

            for (int i = 0; i < linhas; i++)
            {
                char[] linha = leitor.ReadLine().ToCharArray();

                for (int j = 0; j < colunas; j++)
                    labirinto[i, j] = linha[j];
            }
            leitor.Close();
        }
        //Propriedades get e set da matriz Labirinto dessa classe
        public char this[int lin, int col]
        {
            get
            {
                if ((lin >= 0 && lin < linhas) && (col >= 0 && col < colunas))
                    return labirinto[lin, col];
                return default(char);
            }
            set
            {
                if ((lin >= 0 && lin < linhas) && (col >= 0 && col < colunas))
                    labirinto[lin, col] = value;
            }
        }
        //Construtor vazio
        public Labirinto() {}
        //Deixa o labirinto com as cores e arruma ele no DataGridView
        public void ParaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = colunas;
            dgv.RowCount = linhas;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (labirinto[i, j] == '#')
                        dgv.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;

                    if (labirinto[i, j] == 'I')
                        dgv.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightBlue;

                    if (labirinto[i, j] == 'S')
                        dgv.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Purple;

                    if (labirinto[i, j] == ' ')
                        dgv.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Empty;

                    dgv.Columns[j].Width = dgv.Width / colunas;
                }
                dgv.Rows[i].Height = dgv.Height / linhas;
            }
        }
            //Limpa o labirinto,deixando os caracteres "vazios"
        public void LimparLabirinto()
        {
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    if (labirinto[i, j].Equals('O'))
                        labirinto[i, j] = ' ';
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apLabirintoBacktracking
{
    class Movimento : IComparable<Movimento>
    {
        int lin, col, dir;

        public Movimento(int linha, int coluna, int direcao)
        {
            Linha = linha;
            Coluna = coluna;
            Direcao = direcao;
        }

        public int Linha 
        { 
            get => lin; 
            set
            {
                if (value > 0)
                    lin = value;
            }
        }

        public int Coluna
        {
            get => col;
            set
            {
                if (value > 0)
                    col = value;
            }
        }

        public int Direcao
        {
            get => dir;
            set
            {
                if (value > 0)
                    dir = value;
            }
        }

        public override string ToString()
        {
            return $"({lin},{col}) para {dir}";
        }

        public int CompareTo(Movimento mov)
        {
            return 0;
        }
    }
}

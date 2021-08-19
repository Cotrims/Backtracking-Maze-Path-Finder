
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace apLabirintoBacktracking
{
    public partial class frmLabirintoBacktracking : Form
    {
        Labirinto lab;
        PilhaLista<Movimento> movs;
        ArrayList caminhos;

        //Vetores para fazer a movimentação.
        int[] lin = new int[8] { -1, -1, 0, 1, 1, 1, 0, -1 };
        int[] col = new int[8] { 0, 1, 1, 1, 0, -1, -1, -1 };

        public frmLabirintoBacktracking()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Abre o arquivo e exibe do DataGridView do labirinto
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                lab = new Labirinto(dlgAbrir.FileName);
                lab.ParaDgv(dgvLabirinto);
            }

            dgvCaminhos.ClearSelection();
            dgvCaminhos.RowCount = 0;
            dgvLabirinto.ClearSelection();
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            if(lab == null) //Se o usuário não abriu um labirinto
            {
                MessageBox.Show("Abra um labirinto primeiro!");
                return;
            }

            //Variáveis que representam os caminhos
            int i = 1, j = 1, Inovo, Jnovo;

            movs = new PilhaLista<Movimento>(); //Pilha que representa o caminho atual
            caminhos = new ArrayList(); //ArrayList todos os caminhos encontrados

            int d = 0; //Direções
            for (;;)
            {
                if (d == 8) //Já verificou todas as posições
                {
                    if (movs.EstaVazia) //Se a pilha estiver vazia, significa que já voltamos para o início
                    {
                        if (caminhos.Count <= 0) //Não há caminhos no ArrayList
                            MessageBox.Show("Esse labirinto não tem saida");
                        else
                            ExibirCaminhos(); //Exibe os caminhos encontrados

                        lab.LimparLabirinto(); //Remove as marcas 'O' do labirinto

                        return; //Sai da função
                    }

                    VoltarCaminho(); //Volta um movimento
                    continue;
                }

                //Um movimento para a linha Inovo e coluna Jnovo na direcao d
                Inovo = i + lin[d];
                Jnovo = j + col[d];

                if (lab[Inovo, Jnovo].Equals(' ')) //Se há um caminho
                {
                    movs.Empilhar(new Movimento(i, j, d)); //Empilha a posição atual e a direção seguida

                    //Muda a posição e reinicia a direção
                    i = Inovo;
                    j = Jnovo;
                    d = 0;

                    lab[i, j] = 'O'; //Coloca uma marca no labirinto
                    try { dgvLabirinto[j, i].Style.BackColor = Color.DarkGray; } catch (Exception) { } //Pinta a célula

                    Thread.Sleep(50);
                    Application.DoEvents();
                }
                else
                    d++; //Caso não há um caminho, mudamos a direção

                if (lab[Inovo, Jnovo].Equals('S')) //Se chegou na saída
                {
                    PilhaLista<Movimento> copia = movs.Copia();
                    copia.Empilhar(new Movimento(i, j, d - 1));
                    caminhos.Add(copia); //Guarda todo o caminho feito + O ultimo movimento
                    VoltarCaminho(); 
                }
            }

            void VoltarCaminho()
            {
                Movimento mov = movs.Desempilhar(); //Retira o movimento da pilha

                lab[i, j] = ' '; //Remove a marca
                try { dgvLabirinto[j, i].Style.BackColor = Color.Empty; } catch (Exception) { } //Tira a cor da célula

                Thread.Sleep(50);
                Application.DoEvents();

                //Coloca os valores antigos
                i = mov.Linha;
                j = mov.Coluna;
                d = mov.Direcao + 1;
            }
        }

        private void ExibirCaminhos() //Exibe no dgvCaminhos, todos os caminhos encontrados
        {
            dgvCaminhos.RowCount = caminhos.Count;

            for (int i = 0; i < caminhos.Count; i++)
            {
                var caminho = ((PilhaLista<Movimento>)caminhos[i]).Copia();
                caminho.Inverter(); //Inverte a pilha para exibir do início até a saída

                int j = 0;
                while (!caminho.EstaVazia) //Exibe cada movimento
                {
                    if (j >= dgvCaminhos.ColumnCount)
                        dgvCaminhos.ColumnCount += 1;

                    dgvCaminhos.Columns[j].Width = 70;
                    dgvCaminhos.Rows[i].Cells[j++].Value = caminho.Desempilhar().ToString();
                }
            }
        }

        private void dgvCaminhos_CellClick(object sender, DataGridViewCellEventArgs e) //Exibe o caminho que o usuário selecionou no DgvCaminho
        {
            dgvCaminhos.ClearSelection();

            lab.ParaDgv(dgvLabirinto); //Limpa visualmente o labirinto

            var auxiliar = new PilhaLista<Movimento>();
            var caminho = ((PilhaLista<Movimento>)caminhos[e.RowIndex]).Copia();

            caminho.Inverter(); //Inverte a pilha para exibir do início até a saída
            caminho.Desempilhar(); //Pula o primeiro

            while (!caminho.EstaVazia)
            {
                Movimento mov = caminho.Desempilhar(); //Desempilha o movimento

                try { dgvLabirinto[mov.Coluna, mov.Linha].Style.BackColor = Color.DarkGray; } catch (Exception) { } //Pinta a célula
            }
        }
    }
}


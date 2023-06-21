using System.CodeDom;

namespace Jv
{
    public partial class formulario : Form
    {
        bool fin = true;
        bool jogar = true;
        int jog = 0;
        string[] t = new string[9];
        public formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Button botao = (Button)sender;
            int numeracao = botao.TabIndex;
            if(botao.Text == "")
            {
                if(jogar)
                {
                    botao.Text = "X";
                    t[numeracao] = botao.Text;
                    jog++;
                    jogar = !jogar;
                    jogadas(1);
                }
                else
                {
                    botao.Text = "O";
                    t[numeracao] = botao.Text;
                    jog++;
                    jogar = !jogar;
                    jogadas(2);
                }
            }
        }
        public void vencedor (int jogador)
        {
            fin = true;
            if(jogador == 1)
            {
                MessageBox.Show("Player X ganhou!!!");
            }
            else
            {
                MessageBox.Show("Player 0 ganhou!!!");
            }
        }
        public void jogadas (int checagemp)
        {
            string ajudinha = "";
            if(checagemp == 1)
            {
                ajudinha= "X";            }
            else
            {
                ajudinha= "O";
            }
            for(int hor = 0; hor < 8; hor += 3)
            {
                if(ajudinha == t[hor])
                {
                    if (t[hor] == t[hor + 1] && t[hor] == t[hor + 2])
                    {
                        vencedor(checagemp);
                        return;
                    }
                }
            }

            for (int ver = 0; ver < 3; ver++)
            {
                if (ajudinha == t[ver])
                {
                    if (t[ver] == t[ver + 3] && t[ver] == t[ver + 6])
                    {
                        vencedor(checagemp);
                        return;
                    }
                }
            }

            
                if (ajudinha == t[0])
                {
                    if (t[0] == t[4] && t[0] == t[8])
                    {
                        vencedor(checagemp);
                        return;
                    }
                }
            if (ajudinha == t[2])
            {
                if (t[2] == t[4] && t[2] == t[6])
                {
                    vencedor(checagemp);
                    return;
                }
            }
            if(jog == 9)
            {
                MessageBox.Show("Empate!!!");
                fin = true;
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}

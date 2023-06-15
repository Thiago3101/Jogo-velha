namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jogo jogo = new Jogo();

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button1.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button1.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button1.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button2.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button2.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button2.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button3.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button3.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaDiagonal(button3.Text, button5.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button3.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button1.Text, button2.Text, button3.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaDiagonal(button3.Text, button5.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button4.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button4.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button4.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button5.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {
                if (Jogo.jogador % 2 != 0)
                {
                    button5.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button5.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button6.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {
                if (Jogo.jogador % 2 != 0)
                {
                    button6.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button6.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button4.Text, button5.Text, button6.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button7.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button7.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaDiagonal(button3.Text, button5.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button7.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaDiagonal(button3.Text, button5.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button1.Text, button4.Text, button7.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button8.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button8.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button8.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button2.Text, button5.Text, button8.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (button9.Text != "")
            {
                label2.Text = "Casa já ocupada";
            }
            else
            {

                if (Jogo.jogador % 2 != 0)
                {
                    button9.Text = "X";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador X venceu";
                    }
                }
                else
                {
                    button9.Text = "O";
                    Jogo.jogador++;
                    if (jogo.VerificaHorizontal(button7.Text, button8.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaDiagonal(button1.Text, button5.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                    if (jogo.VerificaVertical(button3.Text, button6.Text, button9.Text) == true)
                    {
                        label1.Text = "Jogador O venceu";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            label1.Text = "";
            label2.Text = "";
        }
    }
}
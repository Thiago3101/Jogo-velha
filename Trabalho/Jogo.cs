public class Jogo
{
    public static int jogador;

    public bool VerificaHorizontal(string casa1, string casa2, string casa3)
    {
        if(casa1 == casa2 && casa2 == casa3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificaVertical(string casa1, string casa2, string casa3)
    {
        if (casa1 == casa2 && casa2 == casa3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificaDiagonal(string casa1, string casa2, string casa3)
    {
        if (casa1 == casa2 && casa2 == casa3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
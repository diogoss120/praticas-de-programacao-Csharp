using System;
/*Escreva um algoritmo que leia uma palavra a partir do teclado e uma letra
informada pelo usuário. O algoritmo deve contar o número de vezes em que esta
letra ocorre na palavra informada e apresentar a posição da letra na palavra. */
class Programa
{
    static void Main()
    {
        Palavra teste = new Palavra();
        teste.LerPalavra("Diogo Souza Santos");
        teste.LerLetra('o');
        teste.Analise();
        teste.Exibir();
        teste.PosicoesDaLetra();
    }
}
struct Palavra
{
    private string palavra;
    private int ocorrencia;
    private char letra;
    private string posicao;

    public void Analise()
    {
        for (int i = 0; i < this.palavra.Length; i++)
            if(this.palavra[i] == this.letra)
            {
                this.ocorrencia++;
                posicao += i + " ";
            }
    }
    public void LerPalavra(string palavra)
    {
        this.palavra = palavra;
    }
    public void LerLetra(char letra)
    {
        this.letra = letra;
    }
    public void Exibir()
    {
        Console.WriteLine("A letra '{0}' apareceu {1} na palavra {2} ", this.letra, this.ocorrencia, this.palavra);
    }
    public void PosicoesDaLetra()
    {
        Console.WriteLine("As posições que essa letra apareceu foram {0}", this.posicao);
    }
}


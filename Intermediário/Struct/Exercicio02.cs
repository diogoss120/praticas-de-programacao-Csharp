using System;
/*Escreva um algoritmo para cadastro de pessoas. No cadastro, as pessoas são
classificadas em físicas ou jurídicas. O algoritmo deve cadastrar e imprimir as
pessoas cadastradas.*/
class Programa
{
    static void Main()
    {
        PessoaFisica[] diogo1 = new PessoaFisica[3];
        PessoaJuridica[] diogo2 = new PessoaJuridica[3];
        Cadastro cadastrarPessoas = new Cadastro(diogo1, diogo2);
        cadastrarPessoas.PreencherVetordasPessoasFisicas();
        cadastrarPessoas.PreencherVetordasPessoasJuridicas();
        cadastrarPessoas.ImprimirPessoaF();
        cadastrarPessoas.ImprimirPessoaJ();
    }
}
struct Pessoa
{
    public string nome;
    public string dataNacimento;
}
struct PessoaFisica
{
    public Pessoa pessoa;
    public int cpf;
}
struct PessoaJuridica
{
    public Pessoa pessoa;
    public int cnpj;
}
struct Cadastro
{
    private PessoaFisica[] cadastroPessoaFisica;
    private PessoaJuridica[] cadastroPessoaJuridica;

    public Cadastro(PessoaFisica[] vet1, PessoaJuridica[] vet2)
    {
        this.cadastroPessoaFisica = vet1;
        this.cadastroPessoaJuridica = vet2;
    }

    public void PreencherVetordasPessoasFisicas()
    {
        for (int i = 0; ; i++)
        {
            Console.Write("Informe o nome da pessoa fisica {0}: ", i + 1);
            this.cadastroPessoaFisica[i].pessoa.nome = Console.ReadLine();
            Console.Write("Informe a data de nascimento da pessoa fisica{0}: ", i + 1);
            this.cadastroPessoaFisica[i].pessoa.dataNacimento = Console.ReadLine();
            Console.Write("Informe o cpf da pessoa fisica {0}: ", i + 1);
            this.cadastroPessoaFisica[i].cpf = int.Parse(Console.ReadLine());
            if (teste("fisica"))
                break;
        }
    }
    public void PreencherVetordasPessoasJuridicas()
    {
        for (int i = 0; ; i++)
        {
            Console.Write("Informe o nome da pessoa juridica {0}: ", i + 1);
            this.cadastroPessoaJuridica[i].pessoa.nome = Console.ReadLine();
            Console.Write("Informe a data de fundação da empresa {0}: ", i + 1);
            this.cadastroPessoaJuridica[i].pessoa.dataNacimento = Console.ReadLine();
            Console.Write("Informe o cnpj da pessoa juridica {0}: ", i + 1);
            this.cadastroPessoaJuridica[i].cnpj = int.Parse(Console.ReadLine());
            if (teste("juridica"))
                break;
        }
    }
    private bool teste(string msg)
    {
        int i;
        Console.Write($"Deseja informar mais alguma pessoa {msg}?\nDigite 1 se quiser informar, ou qualquer outro caracter para cancelar: ");
        try
        {
            i = int.Parse(Console.ReadLine());
            if (i != 1)
                return true;
            return false;
        }
       
        catch
        {
            return true;
        }
    }
    public void ImprimirPessoaF()
    {
        for (int i = 0; this.cadastroPessoaFisica[i].cpf > 0; i++)
            Console.WriteLine($"{cadastroPessoaFisica[i].pessoa.nome}, nasceu em {cadastroPessoaFisica[i].pessoa.dataNacimento} e possui o cpf: {cadastroPessoaFisica[i].cpf}");
    }
    public void ImprimirPessoaJ()
    {
        for (int i = 0; this.cadastroPessoaJuridica[i].cnpj > 0; i++)
            Console.WriteLine($"A empresa {this.cadastroPessoaJuridica[i].pessoa.nome}, foi fundada em {this.cadastroPessoaJuridica[i].pessoa.dataNacimento} e possui o cnpj: {this.cadastroPessoaJuridica[i].cnpj}");
    }
}
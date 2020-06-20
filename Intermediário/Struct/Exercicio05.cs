using System;
/*algoritmo em C# que permite o cadastro de alunos de uma escola.*/
class Programa
{
    static void Main()
    {
        Aluno[] teste = new Aluno[3];
        Cadastro cadastrar = new Cadastro(teste);
        cadastrar.cadastrarAluno();
        cadastrar.exibirCadastro();
        cadastrar.alunosAprovados();
    }
}
struct Cadastro
{
    Aluno[] alunos;
    public Cadastro(Aluno[] lista)
    {
        alunos = lista;
    }
    public void cadastrarAluno()
    {
        for (int i = 0; i < this.alunos.Length; i++)
            alunos[i].ler();
        Console.WriteLine();
    }
    public void exibirCadastro()
    {
        Console.WriteLine("Todos os alunos cadastrados: ");
        for (int i = 0; i < this.alunos.Length; i++)
            alunos[i].imprimir();
        Console.WriteLine();
    }
    public void alunosAprovados()
    {
        Console.WriteLine("Todos os alunos aprovados: ");
        for (int i = 0; i < this.alunos.Length; i++)
            if (alunos[i].avaliacao())
                alunos[i].imprimir();
        Console.WriteLine();
    }
}
struct Aluno
{
    string matricula;
    string nome;
    int nota;
    public void ler()
    {
        Console.Write("Informe o número da matrícula: ");
        this.matricula = Console.ReadLine();
        Console.Write("Informe o nome do aluno: ");
        this.nome = Console.ReadLine();
        Console.Write("Informe nota do aluno: ");
        this.nota = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public void imprimir()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Matrícula:  " + this.matricula);
        Console.WriteLine("Nota: " + this.nota);
    }
    public bool avaliacao()
    {
        if (this.nota >= 70)
            return true;
        else
            return false;
    }
}

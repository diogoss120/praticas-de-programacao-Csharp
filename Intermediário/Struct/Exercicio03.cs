using System;
/*Escreva um algoritmo que permita o cadastro de alunos de uma escola. */
namespace AplicativoDeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] aluno = new Aluno[2];
            Cadastro cadastrar = new Cadastro(aluno);
            cadastrar.CadastrarAlunos();
            Console.WriteLine("Cadastro Completo de cada aluno: \n");
            cadastrar.exibirCadastros();
            Console.WriteLine("Diciplinas Aprovadas e Reprovadas: \n");
            cadastrar.diciplinasAprovadas();
            cadastrar.diciplinasReprovadas();
        }
    }
    struct Cadastro
    {
        Aluno[] aluno;
        public Cadastro(Aluno[] aluno)
        {
            this.aluno = aluno;
        }
        public void CadastrarAlunos()
        {
            for (int i = 0; i < aluno.Length; i++)
            {
                aluno[i].Ler();
            }
            Console.Clear();
        }
        public void exibirCadastros()
        {
            for (int i = 0; i < aluno.Length; i++)
            {
                aluno[i].imprimirDados();
            }
        }
        public void diciplinasAprovadas()
        {
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine($"Diciplinas em que o aluno {this.aluno[i].nome} foi aprovado ");
                for (int j = 0; j < this.aluno[i].notas.Length; j++)
                {
                    if (this.aluno[i].notas[j] >= 70)
                    {
                        Console.Write($"{this.aluno[i].diciplinas = (Diciplina)(j)}: ");
                        Console.WriteLine($"{this.aluno[i].notas[j]}");
                    }
                }
            }
            Console.WriteLine();
        }
        public void diciplinasReprovadas()
        {
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine($"Diciplinas em que o aluno {this.aluno[i].nome} foi reprovado ");
                for (int j = 0; j < this.aluno[i].notas.Length; j++)
                {
                    if (this.aluno[i].notas[j] < 70)
                    {
                        Console.Write($"{this.aluno[i].diciplinas = (Diciplina)(j)}: ");
                        Console.WriteLine($"{this.aluno[i].notas[j]}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
    struct Aluno
    {
        string matricula;
        public string nome;
        Curso cursoAluno;
        public Diciplina diciplinas;
        public int[] notas;


        public void Ler()
        {
            Console.Write("Informe a matricula do aluno: ");
            this.matricula = Console.ReadLine();
            Console.Write("Informe o nome do aluno: ");
            this.nome = Console.ReadLine();
            escolherCurso();
            DiciplinasNotas();
            Console.WriteLine();
        }
        public void imprimirDados()
        {
            Console.WriteLine("Matricula: " + this.matricula);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Curso: " + this.cursoAluno);
            mostrarNotas();
            Console.WriteLine();
        }
        void DiciplinasNotas()
        {
            int indice = 4;
            this.notas = new int[indice];
            Console.WriteLine("Informe a nota da diciplina: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"{this.diciplinas = (Diciplina)(i)}: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }
        void mostrarNotas()
        {
            Console.WriteLine("Notas: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"{this.diciplinas = (Diciplina)(i)}: ");
                Console.WriteLine($"{notas[i]}");
            }
        }
        void escolherCurso()
        {
            Console.WriteLine("Escolha um Curso:\n0 - Administração\n1 - Contabilidade\n2 - Economia");
            int escolha = 0;
            do
            {
                try
                {
                    Console.Write("Digite um número: ");
                    escolha = int.Parse(Console.ReadLine());
                }
                catch
                {
                    escolha = 8;
                }
            } while (escolha < 0 || escolha > 2);
            switch (escolha)
            {
                case 0:
                    this.cursoAluno = Curso.Administração;
                    break;
                case 1:
                    this.cursoAluno = Curso.Contabilidade;
                    break;
                case 2:
                    this.cursoAluno = Curso.Economia;
                    break;
            }
        }
    }
    enum Curso { Administração, Contabilidade, Economia };
    enum Diciplina { Estatistica, Matemática, Política, Logística };
}
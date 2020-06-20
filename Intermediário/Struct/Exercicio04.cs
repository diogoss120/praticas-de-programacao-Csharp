using System;
/*algoritmo em C# para cadastro de veículos de uma agência. A agência vende carros e motos.*/
class Programa
{
    static void Main()
    {
        Veiculo[] carros = new Veiculo[1];
        Veiculo[] motos = new Veiculo[1];
        Cadastro cadastros = new Cadastro(carros, motos);
        cadastros.registros();
        cadastros.exibirVeiculos();
        cadastros.situacao();
    }
}
struct Cadastro
{
    Veiculo[] carros;
    Veiculo[] motos;
    public Cadastro(Veiculo[] carros, Veiculo[] motos)
    {
        this.carros = carros;
        this.motos = motos;
    }
    public void registros()
    {
        registrarCarro();
        registrarMoto();
    }
    public void exibirVeiculos()
    {
        exibirCarro();
        exibirMoto();
    }
    public void situacao()
    {
        Vendido();
        emEstoque();
    }
    void registrarCarro()
    {
        Console.WriteLine("Cadastro de Carros");
        for (int i = 0; i < carros.Length; i++)
            this.carros[i].lerDados();
    }
    void registrarMoto()
    {
        Console.WriteLine("Cadastro de Motos");
        for (int i = 0; i < motos.Length; i++)
            this.motos[i].lerDados();
    }
    void exibirCarro()
    {
        Console.WriteLine("Lista de carros");
        for (int i = 0; i < carros.Length; i++)
            carros[i].exibirVeiculo();
    }
    void exibirMoto()
    {
        Console.WriteLine("Lista de motos");
        for (int i = 0; i < motos.Length; i++)
            motos[i].exibirVeiculo();
    }
    void Vendido()
    {
        Console.WriteLine("Todos os veículos vendidos");
        for (int i = 0; i < carros.Length; i++)
            if (carros[i].resposta())
                carros[i].exibirVeiculo();
        for (int i = 0; i < motos.Length; i++)
            if (motos[i].resposta())
                motos[i].exibirVeiculo();
    }
    void emEstoque()
    {
        Console.WriteLine("Todos os veículos em estoque");
        for (int i = 0; i < carros.Length; i++)
            if (!carros[i].resposta())
                carros[i].exibirVeiculo();
        for (int i = 0; i < motos.Length; i++)
            if (!motos[i].resposta())
                motos[i].exibirVeiculo();
    }
}
struct Veiculo
{
    private int numeroChassi;
    private int ano;
    private string modelo;
    private string marca;
    private string cor;
    private bool vendido;
    public void lerDados()
    {
        Console.Write("Modelo do veículo: ");
        this.modelo = Console.ReadLine();
        Console.Write("Marca do veículo: ");
        this.marca = Console.ReadLine();
        Console.Write("Chassi do veículo: ");
        this.numeroChassi = int.Parse(Console.ReadLine());
        Console.Write("Ano do veículo: ");
        this.ano = int.Parse(Console.ReadLine());
        Console.Write("Cor do veículo: ");
        this.cor = Console.ReadLine();
        int p = 0;
        Console.WriteLine("O veículo foi vendido?\nSe sim digite: 1\nSe não digite 2");
        do
        {
            Console.Write("Informe um número: ");
            p = int.Parse(Console.ReadLine());
        } while (p < 1 || p > 2);
        if (p == 1)
            vendido = true;
        else
            vendido = false;
        Console.WriteLine();
    }
    public void exibirVeiculo()
    {
        Console.WriteLine("Modelo: " + this.modelo);
        Console.WriteLine("Marca: " + this.marca);
        Console.WriteLine("Chassi: " + this.numeroChassi);
        Console.WriteLine("Ano: " + this.ano);
        Console.WriteLine("Cor: " + this.cor);
        Console.WriteLine();
    }
    public bool resposta()
    {
        return vendido;
    }
}
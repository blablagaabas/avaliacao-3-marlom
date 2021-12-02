using System;

class Program {
  public static void Main (string[] args) {

    string tipo;
    string nome = null;
    int    aval = 0;
    string desc = null;
    float  valor= 0f;

    Cos Cosmetic = new Cos(nome, valor, aval, desc);
    Console.WriteLine ("Seja bem Vindo ao CosmeticUCl, Deseja Cadastrar ou Pesquisar um cosmético?");
    tipo = Console.ReadLine();

    if(tipo == "Cadastrar" || tipo == "cadastrar" || tipo == "CADASTRAR")
    {   
        Console.WriteLine ("Qual o Nome do Cosmético que Deseja Cadastrar?");
        nome = Console.ReadLine();
        Console.WriteLine ("Qual o Valor do Cosmético que deseja Cadastrar?");
        valor = float.Parse(Console.ReadLine());
        Console.WriteLine ("Qual a Avaliação do cosmético que deseja cadastrar?");
        aval = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite uma breve descrição do cosmético que deseja cadastrar");
        desc = Console.ReadLine();
    
        Cosmetic.AdicionarProduto(nome, valor, aval, desc);
        
    }else
    {
        Console.WriteLine ("Qual o Nome do Cosmético que Deseja Cadastrar?");
        nome = Console.ReadLine();
        Cosmetic.RetornarProdutos(nome);
    }

  }
}
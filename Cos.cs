using System;
using System.Collections.Generic;

class Cos
{
    private string desc {get; set;}
    private float valor {get; set;}
    private int    aval {get; set;}
    private string nome {get; set;}
    private List<Cos> comestico;
   

    public Cos(string nome, float valor, int aval, string desc)
    {
        this.valor =  valor;
        this.nome  =  nome;
        this.desc  = desc;
        this.aval  = aval;
        cosmetico = new List<Cos>();
        
    }
    public Cos()
    {
      
    }

    public void AdicionarProduto(string nome1, float valor1, int aval1, string desc1)
    {
        Console.WriteLine("até aqui tudo bem");
        comestico.Add(valor1);
        comestico.Add(nome1);
        comestico.Add(aval1);
        comestico.Add(desc1);
    }

    public void RetornarProdutos(string nome)
    {
        
 
    } 
    

}
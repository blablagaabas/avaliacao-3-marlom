using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cosmeticos
{
    private List<Produto> Produtos;

    public Cosmeticos()
    {
        Produtos = new List<Produto>();
    }

    public bool Inserir(Produto cosmetico)
    {
        bool resultado = true;
        try
        {
        }
        catch(Exception erro)
        {
            resultado = false;
        }
        return resultado;
    }
}
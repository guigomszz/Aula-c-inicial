// See https://aka.ms/new-console-template for more information


using System;

namespace Aulacinicial;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");


        Carro carro1 = new Carro();

        Carro carro2 = new Carro("Eu sou carro 2");
        
        Carro carro3 = new Carro();;


        Console.Read();
        Console.WriteLine(carro1.DigaSeuNome("Carro 1"));
        Console.WriteLine(carro2.DigaSeuNome());
        Console.WriteLine(carro2.DigaADataDoSeuNascimento);
        Console.WriteLine(carro3.DigaSeuNome("Carro 3"));
    }
}

    //FORMA
    class Carro
    {
    private string nome;

    public Carro(string Nome)
    {
        nome = Nome;
    }

    public DateTime DigaADataDoSeuNascimento()
    { 
        return DateTime.Now;
    }

    public Carro()
    {
        

    }

    public string DigaSeuNome()
    {
        return nome;
    }
    public string DigaSeuNome(String Nome)
        {
            return Nome;
        }
     }



using System;
using System.Globalization;


namespace vinicius_pereira_180076_classes
{
    static void Main(string[] args)
    {
        //pedindo a quantidade de produto pra inserir
        Console.WriteLine("Insira a quantidade: ");
        int n = int.Parse(Console.ReadLine());
        Produto[] vect = new Produto[n];
        for (int i = 0; i < n; i++)
        {
            //inserindo nome dos produtos
            Console.WriteLine("Insira o nome: ");
            string name = Console.ReadLine();
            //inserindo o preço dos produtos
            Console.WriteLine("Insira o preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vect[i] = new Produto { Name = name, Price = price };
        }

        double sum = 0.0;



        for (int i = 0; i < n; i++)
        {
            sum += vect[i].Price;
        }

        //conta pra achar a média
        double m = sum / n;

        //mostrando o resultado
        Console.WriteLine("A média do preço dos produtos inseridas é = " + m);
        Console.ReadKey();

    }
}


        
    

    


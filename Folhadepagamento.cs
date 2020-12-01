using System;
using System.Collections.Generic;
using System.Globalization;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionário> tema = new List<Funcionário>(); //lista de funcionários
            Console.Write("Entre com número de funcionários: "); //Entrada da quantidade de usuários
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= n; i++) //Repetir para cada funcionario
            {
                Console.WriteLine("Funcionário #" + i + " data:");
                Console.Write("Tercerizado (s/n)? "); //Ver se é tercerizado
                string terc = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine(); //Entrada do nome
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine()); //Entrada das horas
                if (terc == "s") //Tercerizar
                {
                    Console.Write("Adicional: "); //valor do adicional
                    double adicional = double.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: "); //valor por hora
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Funcionário temp1 = new Tercerizado(nome, horas, valor, adicional); //Upcasting para funcionário
                    tema.Add(temp1); //Adiciona funcionário na lista
                }
                else //Não tercerizado
                {
                    Console.Write("Valor por hora: "); //Valor por hora
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Funcionário temp = new Funcionário(nome, horas, valor); //Cria funcionário
                    tema.Add(temp); //Adicionar funcionário na lista
                }
            }
            Console.WriteLine("Pagamentos:"); //Imprimir o valor de pagamento dos funcionários
            foreach (Funcionário obj in tema)
            {
                Console.WriteLine(obj.Nome + " - R$ " + obj.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
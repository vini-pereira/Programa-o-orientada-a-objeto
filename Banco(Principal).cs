using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TarefaBanco
{
    class Program
    {


        static void Main(string[] args)
        {

            //Pedir dados da conta
            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("\nHaverá deposito inicial? (s/n): ");
            string decisao = Console.ReadLine();


            //se ação de iniciar com um depósito for sim
            if (decisao == "s")
            {
                Console.Write("\nEntre com o valor de depósito inicial: ");
                double valorIn = double.Parse(Console.ReadLine());

                Console.Write("\nDados da conta: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + valorIn);
                //entrar um valor pra depósito
                Console.Write("\nEntre com um valor para depósito: ");
                int quantDep = int.Parse(Console.ReadLine());

                double d = quantDep + valorIn;
                double totalDep = d;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalDep);
                //entrando um valor pra saque
                Console.Write("\nEntre com um valor para saque: ");
                int quantSaq = int.Parse(Console.ReadLine());

                double s = totalDep - quantSaq;
                double totalSaq = s;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalSaq);
                Console.ReadKey();
            }
            //se a ação de iniciar com um depósito for não
            if (decisao == "n")
            {
                double T = 0;
                double total = T;

                Console.Write("\nDados da conta: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + total);
                //entrar com valor pra depósito
                Console.Write("\nEntre com um valor para depósito: ");
                int quantDep = int.Parse(Console.ReadLine());

                double d = quantDep + total;
                double totalDep = d;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalDep);
                //entrando um valor pra saque
                Console.Write("\nEntre com um valor para saque: ");
                int quantSaq = int.Parse(Console.ReadLine());

                double s = totalDep - quantSaq;
                double totalSaq = s;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalSaq);
                Console.ReadKey();
            }

        }
    }
}



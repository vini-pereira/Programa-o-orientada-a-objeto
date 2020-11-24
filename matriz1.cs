using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir os valores da matriz:");
            int n = int.Parse(Console.ReadLine());//criar uma variavel n e recebendo valor do usuario

            int[,] mat = new int[n, n];//criar uma matriz de inteiros aberto para que o usuario coloque o valor

            for (int i = 0; i < n; i++) //atribuir um tamanho pro for estabelecendo limite e fazend ele sair do lugar
            {
                string[] values = Console.ReadLine().Split(" ");//input os elementos para dentro da matriz utilizando split para alinhar na matriz
                for (int j = 0; j < n; j++)//variável da coluna atribuindo 0 e um contador para sair do lugar 
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal Principal:"); //imprimir os valores na tela
            for (int i = 0; i < n; i++) //passa pela matriz e identifca os itens que tem que aparecer
            {
                Console.WriteLine(mat[i, i] + " ");//percorer toda linha para imprimir a diagonal

            }

            Console.WriteLine(); // imprimir informação vazia

            int count = 0;// contador para identificar se o valor e menor que 0
            for (int i = 0; i < n; i++) //percorrer  linha
            {
                for (int j = 0; j < n; j++) //percorrer coluna 
                {
                    if (mat[i, j] < 0)// numeros da matriz precisam ser menor que 0
                    {
                        count++;
                    }
                }
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaLista
{
    class Program
    {


        static void Main(string[] args)
        {
            //Criar a lista de strings
            List<string> list = new List<string>();
            //Adicionar elementos na lista de strings
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Ohata"); list.Add("Eliney"); list.Add("Andre");
            //Adicionar um elemento na posição sugerida
            list.Insert(2, "Lucas");
            //Realizar um looping de leitura dos elementos inseridos
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //quantidade de elementos tem na minha lista
            Console.WriteLine("\n\nQntde elementos na Lista: " + list.Count);
            //Encontrar o primeiro elemento que inicia com a letra A, com uma função lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro elemento que começa com a letra A: " + s1);
            //Encontrar o último elemento que inicia com a letra A, com uma função lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro elemento que começa com a letra A: " + s2);
            //Buscaando elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nPrimeira posição de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("\nÚltima posição de 'A': " + pos2);
            //Buscaando todos os nomes com 5 caracteres
            Console.WriteLine("\n\n\nElementos com 5 caracteres: ");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach (string obj in list2)
            {
                //Remover Andre da lista
                list.Remove("Andre");
                Console.WriteLine("================================\n\n");
                Console.WriteLine(obj);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nAndre foi removido.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Removeendo determinado elemento da lista que começa com a letra W
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("\n\n+++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido o elemento que começa com W.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Removeer nome da posição 3
            list.RemoveAt(3);
            Console.WriteLine("\n\n+++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido o elemento da posição 3.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Removeer nomes da lista a partir da posição (1) e quantos elementos (2)
            list.RemoveRange(1, 2);
            Console.WriteLine("\n\n++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido 2 elementos a partir da posição 1.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

    }
}

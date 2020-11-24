using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TarefaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir o numero dos funcionarios registrados
            Console.Write("Quantos funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            //lista
            List<Funcionario> lista = new List<Funcionario>();

            //usar o for pra repetir o pedido dos dados dos funcionarios de acordo com o número de funcionários pra registro
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nFuncionário #" + (i + 1) + ":");
                //Dados do ID
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                //Dados do Nome
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                //Dados do salário
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Insert(i, new Funcionario(id, nome));
                lista[i].Salario = salario;
            }

            //definir por ID, o funcionário que receberá aumento
            Console.Write("\nId do funcionário que receberá aumento: ");
            string idAumento = Console.ReadLine();


            List<Funcionario> lista2 = lista.FindAll(x => x.Id.ToString("000") == idAumento);



            //condições se existe ou não o número indicado pro aumento no banco de registros


            if (lista2 == null)
            {
                Console.WriteLine("O funcionário de ID " + lista2[0].Id.ToString("000") + " não existe!");

                Console.ReadKey();
            }

            else
            {
                Console.Write("Porcentagem de aumento de salário: ");
                lista2[0].AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("\nLista atualizada de funcionários da Bravo: ");
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();
        }
    }
}
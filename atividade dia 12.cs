using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tarefa1210
{
    class Program
    {
        static void Main(string[] args)
        {
            // quantidade de pessoas
            Console.WriteLine("Número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];


            //com FOR, vai repetir a pergunta de acordo com o número de pessoas
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Altura da pessoa: " + i);
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //declarando
            double sum = 0.0;

            //com o FOR pra verificar todas as informações descritas antes
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            //Calculando media
            double m = sum / n;

            // resultado
            Console.WriteLine("A média de altura das pessoas inseridas é = " + m);
            Console.ReadKey();

        }
    }
}
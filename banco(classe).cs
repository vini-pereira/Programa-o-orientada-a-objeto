using System.Globalization;
namespace TarefaBanco
{
    internal class Conta
    {

        public string Nome;

        public int NumConta;

        public double ValorIn;

        public int QuantDep;

        public int QuantSaq;

        public string Decisao;

        public Conta(string nome, int numConta, double valorIn, int quantDep, int quantSaq, string decisao)

        {
            Nome = nome;
            NumConta = numConta;
            ValorIn = valorIn;
            QuantDep = quantDep;
            QuantSaq = quantSaq;
            Decisao = decisao;

        }
    }
}

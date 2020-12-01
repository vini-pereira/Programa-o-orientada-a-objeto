using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Polimorfismo
{
    class ProdutoI : ProdutoC
    {
        public double taxa;
        public ProdutoI(string Nome, double Preco, double Taxa) : base(Nome, Preco) //parametros que a classe vai receber
        {
            taxa = Taxa;
        }
        public double precoTotal() //Calcular o preço total somando o preço com a taxa
        {
            return preco + taxa;
        }
        public override string etiqueta() //Etiqueta do produto importado
        {
            return nome
                + " - R$ " + preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxa: " + taxa.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaDePagamento
{
    class Tercerizado : Funcionário
    {
        public double Adicional { get; set; } //Declaração das variaveis e capsulamento
        public Tercerizado()
        {
            //Construto padrão
        }
        public Tercerizado(string nome, int horas, double valor, double adicional) : base(nome, horas, valor) //Construto com parametros
        {
            Adicional = adicional;
        }
        public override double Pagamento() //Calcula o pagamento do funcionário tercerizado
        {
            return Horas * Valor + Adicional * 1.1;
        }
    }
}
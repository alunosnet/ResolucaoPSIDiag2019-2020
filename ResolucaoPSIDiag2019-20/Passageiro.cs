using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Passageiro : Ligeiro
    {
        int LotacaoMaxima;
        int NumeroOcupantes;

        public Passageiro()
        {
        }

        public Passageiro(DateTime dataHoraEntrada, string matricula, string marca, string modelo,int lotacaoMaxima,int numeroOcupantes) 
            : base(dataHoraEntrada, matricula, marca, modelo)
        {
            LotacaoMaxima = lotacaoMaxima;
            NumeroOcupantes = numeroOcupantes;
        }
        public override string ToString()
        {
            return base.ToString() + " - " +LotacaoMaxima+" - " +NumeroOcupantes;
        }
        internal override void Preencher()
        {
            base.Preencher();
            Console.WriteLine("Qual a lotação:");
            LotacaoMaxima= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nº de ocupantes:");
            NumeroOcupantes =int.Parse(Console.ReadLine());
        }
    }
}

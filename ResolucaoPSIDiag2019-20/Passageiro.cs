using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Passageiro : Ligeiro
    {
        int LotacaoMaxima;
        int NumeroOcupantes;

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
    }
}

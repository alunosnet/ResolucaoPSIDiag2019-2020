using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Mercadoria : Ligeiro
    {
        float PesoMaximo;
        string TipoMercadoria;

        public Mercadoria()
        {
        }

        public Mercadoria(DateTime dataHoraEntrada, string matricula, string marca, string modelo, float pesoMaximo, string tipoMercadoria)
            : base(dataHoraEntrada, matricula, marca, modelo)
        {
            this.PesoMaximo = pesoMaximo;
            TipoMercadoria = tipoMercadoria;
        }

        public override string ToString()
        {
            return base.ToString() + " -" + PesoMaximo + " " + TipoMercadoria;
        }
        internal override void Preencher()
        {
            base.Preencher();
            Console.WriteLine("Qual o peso máximo:");
            PesoMaximo = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tipo de mercadoria:");
            TipoMercadoria = Console.ReadLine();
        }
    }
}

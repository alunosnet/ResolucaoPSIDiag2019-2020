using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Ligeiro
    {
        DateTime DataHoraEntrada;
        string Matricula;
        string Marca;
        string Modelo;

        public Ligeiro(DateTime dataHoraEntrada, string matricula, string marca, string modelo)
        {
            DataHoraEntrada = dataHoraEntrada;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public Ligeiro()
        {
        }

        ~Ligeiro()
        {
            Console.WriteLine("Acabou o ligeiro");
        }
        public override string ToString()
        {
            return this.Matricula+"-"+ this.Marca + " - " + this.Modelo;
        }
        public string GetMatricula()
        {
            return Matricula;
        }

        public DateTime GetEntradaSaida()
        {
            return DataHoraEntrada;
        }

        public string GetMarca()
        {
            return Marca;
        }

        internal virtual void Preencher()
        {
            //data hora
            DataHoraEntrada = DateTime.Now;
            //matricula
            Console.WriteLine("Indique a matrícula:");
            Matricula = Console.ReadLine();
            //marca
            Console.WriteLine("Indique a marca:");
            Marca = Console.ReadLine();
            //modelo
            Console.WriteLine("Indique o modelo:");
            Modelo = Console.ReadLine();
        }
    }
}

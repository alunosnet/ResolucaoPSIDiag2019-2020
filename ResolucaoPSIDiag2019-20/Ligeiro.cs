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
        ~Ligeiro()
        {
            Console.WriteLine("Acabou o ligeiro");
        }
        public override string ToString()
        {
            return this.Marca + " - " + this.Modelo;
        }
    }
}

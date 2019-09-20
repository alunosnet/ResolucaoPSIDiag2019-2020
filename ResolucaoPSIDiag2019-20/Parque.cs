using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Parque
    {
        List<Ligeiro> Veiculos = new List<Ligeiro>();
        const int LOTACAOPARQUE = 300;
        /// <summary>
        /// Dar entrada do veículo
        /// </summary>
        /// <returns>True ou false para o caso do parque estar
        /// cheio</returns>
        public bool Entrar(Ligeiro novo)
        {
            //testar lotação
            if (Veiculos.Count == LOTACAOPARQUE)
                return false;   //dar erro

            //guardar veículo na lista
            Veiculos.Add(novo);
            return true;
        }
        public bool Sair(String matricula)
        {
            foreach(Ligeiro l in Veiculos)
            {
                if(l.GetMatricula()==matricula)
                {
                    //calcular duração do estacionamento
                    TimeSpan duracao = DateTime.Now - l.GetEntradaSaida();
                    Console.WriteLine("Esteve {0} minutos estacionado", duracao.TotalMinutes);
                    //apagar da lista
                    Veiculos.Remove(l);
                    return true;
                }
            }
            //matricula não existe
            return false;
        }
        public void Estado()
        {
            Console.WriteLine("{0} lugares livres", LOTACAOPARQUE - Veiculos.Count);
            Console.WriteLine("{0} lugares ocupados", Veiculos.Count);

        }

        public bool Procurar(string marca)
        {
            bool encontra = false;
            foreach(Ligeiro l in Veiculos)
            {
                if (l.GetMarca().ToLower() == marca.ToLower())
                {
                    Console.WriteLine(l.ToString());
                    encontra = true;
                }
            }

            return encontra;
        }

        public void Listar()
        {
            foreach (Ligeiro l in Veiculos)
                Console.WriteLine(l.ToString());
        }
    }
}

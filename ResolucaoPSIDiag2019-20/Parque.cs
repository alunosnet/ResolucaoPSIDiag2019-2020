using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class Parque
    {
        List<Ligeiro> Veiculos = new List<Ligeiro>();
        const int LotacaoParque = 300;
        /// <summary>
        /// Dar entrada do veículo
        /// </summary>
        /// <returns>True ou false para o caso do parque estar
        /// cheio</returns>
        public bool Entrar(Ligeiro novo)
        {
            //testar lotação
            if (Veiculos.Count == LotacaoParque)
                return false;   //dar erro

            //guardar veículo na lista
            Veiculos.Add(novo);
            return true;
        }
        public bool Sair(String matricula)
        {

        }
    }
}

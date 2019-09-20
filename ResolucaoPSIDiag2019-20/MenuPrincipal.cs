using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class MenuPrincipal
    {
        static Parque Parque = new Parque();

        public static void MainLoop()
        {
            int op;
            do
            {
                MostrarMenu();
                op = LerOpcao();
                switch (op)
                {
                    case 1: Entrada();
                        break;
                    case 2: Saida();
                        break;
                    case 3: Estado();
                        break;
                    case 4: Procurar();
                        break;
                    case 5: Listar();
                        break;
                }
                Console.WriteLine("----------------------------");
            } while (op != 6);
        }

        private static void Listar()
        {
            Console.WriteLine("Lista de veículos no parque");
            Parque.Listar();
            
        }

        private static void Procurar()
        {
            Console.WriteLine("Qual a marca a procurar:");
            string marca = Console.ReadLine();
            if(Parque.Procurar(marca)==false)
                Console.WriteLine("Não existem veículos dessa marca");
        }

        private static void Estado()
        {
            Console.WriteLine("Estado do parque");
            Parque.Estado();
        }

        private static void Saida()
        {
            Console.WriteLine("Qual a matricula do veículo a sair:");
            string matricula = Console.ReadLine();
            if (Parque.Sair(matricula) == false)
                Console.WriteLine("Matrícula não encontrada.");

        }

        private static void Entrada()
        {
            string tipo;
            Console.WriteLine($"Indique o tipo de veículo:" +
                $"(L)igeiro; (M)ercadoria; (P)assageiro");
            tipo = Console.ReadLine().ToLower();
            Ligeiro novo=null;
            if (tipo == "l")
                novo = new Ligeiro();
            if (tipo == "m")
                novo = new Mercadoria();
            if (tipo == "p")
                novo = new Passageiro();

            if (novo != null)
            {
                novo.Preencher();

                //TODO:Validar a entrada
                Parque.Entrar(novo);
            }
        }

        private static int LerOpcao()
        {
            Console.WriteLine("Escolha uma opção:");
            while (true)
            {
                int op;
                int.TryParse(Console.ReadLine(), out op);
                if (op >= 1 && op <= 6) return op;
            }
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("1.Entrar");
            Console.WriteLine("2.Sair");
            Console.WriteLine("3.Estado");
            Console.WriteLine("4.Procurar");
            Console.WriteLine("5.Listar");
            Console.WriteLine("6.Terminar");
        }
    }
}

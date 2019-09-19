using System;
using System.Collections.Generic;
using System.Text;

namespace ResolucaoPSIDiag2019_20
{
    class MenuPrincipal
    {
        internal static void MainLoop()
        {
            do
            {
                MostrarMenu();
                int op = LerOpcao();
                switch (op)
                {

                }
            } while (op != 6);
        }
    }
}

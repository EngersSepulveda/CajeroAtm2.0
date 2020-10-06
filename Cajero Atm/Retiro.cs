using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Atm
{
    class Retiro
    {
        public void Retirando()
        {
            Metodos_de_retiro metodos_De_Retiro = new Metodos_de_retiro();
            Console.Clear();
            Console.WriteLine("Por favor inserte el monto que desea retirar");
            int retirar = Convert.ToInt32(Console.ReadLine());
            int retiro = VariableRetiro.MetodoRetiro.OpcionRetiro;
            
            

            if (retiro == 1)
            {
                metodos_De_Retiro.Dosymil(retirar);
            }

            else if (retiro == 2)
            {
                metodos_De_Retiro.Cincoycien(retirar);
            }

            else if (retiro == 3)
            {
                metodos_De_Retiro.Eficiente(retirar);
            }
        }
    }
}

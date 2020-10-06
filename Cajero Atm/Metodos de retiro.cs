using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Atm
{

    class Metodos_de_retiro
    {


        
        Menucajero menucajero = new Menucajero();
        Retiro retiro = new Retiro();


        public void Dosymil(int dispensando)
        {
            
            if (dispensando % 100 == 0)
            {
                int Mil = dispensando / 1000;
                dispensando %= 1000;
                int Doscientos = dispensando / 200;
                dispensando %= 200;

                
                  Console.WriteLine("se han retirado " + Mil + " billetes de mil");
                  Console.WriteLine("se han retirado " + Doscientos + " billetes de doscientos");
                  Console.WriteLine();
                  Console.WriteLine("Por davor presione unna tecla para ir al menu principal");
                  Console.ReadKey();
                  Console.Clear();
                  menucajero.MenuPrincipal();
            }

            Console.Clear();
            Console.WriteLine("El monto insertado no es valido, debe ser igual o mayor que 200 y multiplo de 200nPor favor seleccione el metodo de retiro adecuado");
            Console.ReadKey();
            menucajero.MenuPrincipal();

        }

        public void Cincoycien(int dispensando)
        {
            if (dispensando % 100 == 0)
            {
                int Quinientos = dispensando / 500;
                dispensando %= 500;
                int Cien = dispensando / 100;
                dispensando %= 100;

                Console.WriteLine("se han retirado " + Quinientos + " billetes de quinientos");
                Console.WriteLine("se han retirado " + Cien + " billetes de cien");
                Console.WriteLine();
                Console.WriteLine("Por davor presione unna tecla para ir al menu principal");
                Console.ReadKey();
                Console.Clear();
                menucajero.MenuPrincipal();
            }

            Console.Clear();
            Console.WriteLine("El monto insertado no es valido, debe ser igual o mayor que 200 y multiplo de 200nPor favor seleccione el metodo de retiro adecuado");
            Console.ReadKey();
            menucajero.MenuPrincipal();
        }

        public void Eficiente(int dispensando)
        {
            if (dispensando % 100 == 0)
            {
                int Mil = dispensando / 1000;
                dispensando %= 1000;
                int Quinientos = dispensando / 500;
                dispensando %= 500;
                int Doscientos = dispensando / 200;
                dispensando %= 200;
                int Cien = dispensando / 100;
                dispensando %= 100;

                Console.WriteLine("se han retirado " + Mil + " billetes de mil");
                Console.WriteLine("se han retirado " + Quinientos + " billetes de quinientos");
                Console.WriteLine("se han retirado " + Doscientos + " billetes de doscientos");
                Console.WriteLine("se han retirado " + Cien + " billetes de cien");
                Console.WriteLine("Por davor presione unna tecla para ir al menu principal");
                Console.ReadKey();
                Console.Clear();
                menucajero.MenuPrincipal();
            }

            Console.Clear();
            Console.WriteLine("El monto insertado no es valido, debe ser igual o mayor que 200 y multiplo de 200nPor favor seleccione el metodo de retiro adecuado");
            Console.ReadKey();
            menucajero.MenuPrincipal();
        }
    }
}

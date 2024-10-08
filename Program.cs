using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio250824
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear dos cliente, que hagan dos compras y dos pagos y ver el saldo 
            //instanciacion del objeto 
            Persona ObjetoGabriela  = new Persona(888, "Abrego", "Gabriela", 2002, "femenino", "12345", 5000);
            Persona ObjetoJenyfer = new Persona(999, "Ramirez", "Jenyfer", 2002, "femenino", "5678", 4500);

            ObjetoGabriela.Comprar(250);
            ObjetoGabriela.Comprar(750);
            ObjetoGabriela.Pagar(600);
            Console.WriteLine("El saldo de Gabriela es:");
            ObjetoGabriela.Saldo();

            ObjetoJenyfer.Comprar(500);
            ObjetoJenyfer.Comprar(700);
            ObjetoJenyfer.Pagar(1000);
            Console.WriteLine("El saldo de Jenyfer es:");
            ObjetoJenyfer.Saldo();

            Console.ReadKey();
        }
    }
}

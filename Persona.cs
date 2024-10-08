using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio250824
{
    class Persona
    {
        //declaracion de las variables 
        private int ID = 0;
        private string Apellidos = "";
        private string Nombres = "";
        private int AñosNac = 0;
        private string Genero = "";
        private string NIT = "";
        private int Deuda = 0;
        private int limite = 0;

        //creacion del constructor
        public Persona ( int I, string Ap, string Nom, int AN, string Gn, string Nt, int Lim)
        {
            this.ID = I;
            this.Apellidos = Ap;
            this.Nombres = Nom;
            this.AñosNac = AN;
            this.Genero = Gn;
            this.NIT = Nt;
            this.limite = Lim; 
        }
        //creación de los metodos. 
        //creación del metodo de compra 
        public void Comprar (int precio)
        {
            if ((Deuda + precio) <= limite)
            {
                Deuda = Deuda + precio;
            } else
            {
                Console.WriteLine("Error, Se execede el limite de credito.");
                Console.WriteLine("Su saldo es de : {0}", Deuda);
                Console.WriteLine("Su limite es: {0}", limite);
            }
        }
        //creación del metodo de pagar 
        public void Pagar (int pago)
        {
            if ((Deuda-pago) >= 0)
            {
                Deuda = Deuda - pago;
            }
            
        }
        //creación del método ver saldo
        public void Saldo ()
        {
            Console.WriteLine("Su saldo es:" + Deuda );
        }
        //Creación del método ver la info del cliente 
        public void VerInfo ()
        {
            Console.WriteLine("Nombre:" + Nombres);
            Console.WriteLine("Apellido: {0}", Apellidos);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Año de nacimiento:{0}", AñosNac);
            Console.WriteLine("Género: {0}", Genero);
            Console.WriteLine("NIT: {0}", NIT);

        }
    }
}

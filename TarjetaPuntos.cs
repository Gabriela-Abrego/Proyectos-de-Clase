using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaPuntosEjercicio080924
{
    class TarjetaPuntos
    {
        //Creacion de la clase 
        //declaración de variables 
        private string No_Cuenta = "";
        private string Nombre_Completo = "";
        private int Cantidad_Puntos = 0;
        private int Saldo = 0;

        //creación del constructor 

        public TarjetaPuntos(string NoCt, string NomCompl)
        {
            this.No_Cuenta = NoCt;
            this.Nombre_Completo = NomCompl;
        }
        //creación del metodo MODIFICAR 
        //lo unico que puede modificar el usuario es su nombre porque lo demás esta condicionado segun las acciones de compras
        //y canjeo de los puntos. 
       public void Modificar (string Nomb)
        {
            this.Nombre_Completo = Nomb;

        }
        //creación del metodo Eliminar 
        public void Eliminar (string NCTA)
        {
            Nombre_Completo = "";
            Cantidad_Puntos = 0;
            Saldo = 0;
            Console.WriteLine("Su cuenta ha sido eliminada con éxito!!!");

        }
        //creación del metodo Verpuntos 
        public void VerPuntos ()
        {
            Console.WriteLine("Sus puntos acumulados son: {0}", Cantidad_Puntos);
        }
        //creación del metodo Ver Información 
        public void VerInformación ()
        {
            Console.WriteLine("Su nombre es: {0}", Nombre_Completo);
            Console.WriteLine("Su No. de cuenta es: {0}", No_Cuenta);
            Console.WriteLine("Su cantidad de puntos acumulados es: {0}", Cantidad_Puntos);
            Console.WriteLine("Su saldo es: {0}", Saldo);
        }
        //creacion del metodo comprar
        public void Comprar ( int monto_compra)
        {
            //incremento de saldo en quetzales dependiendo de la compra 
            Saldo = Saldo + monto_compra;
            //incremento de puntos sobre compra son 3 por cada 50
            int operacionpuntos = ((monto_compra / 50) * 3);
            Cantidad_Puntos = Cantidad_Puntos + operacionpuntos;
        }
        //metodo ver cuenta para hacer busqueda 
        public string VERCUENTA ()
        {
            return No_Cuenta;
        }
    }
}

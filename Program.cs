using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaPuntosEjercicio080924
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion del vector 
            TarjetaPuntos [] ListadoTarjeta = new TarjetaPuntos [25];
            //guarda la elección del menu que haga el cliente.
            int eleccion = 0;
            //datos para crear la cuenta 
            string Nombre = "";
            string Nocuentas = "";
            //esta variable es el contador que lleva el registro de la posiciones del vector
            int posiciones = 0;
            //para ir recorriendo las posiciones y buscando los no. de cuentas. 
            int  Var2 = -1;

            //Menú
            do
            {
                Console.WriteLine("_______________________________________________________________");

                Console.WriteLine("Bienvenido a Tu Tarjeta de Puntos");
                Console.WriteLine("A continuación se presenta un menú");
                Console.WriteLine("Por favor elija la opcion que más se adecua a sus nececidades.");
                Console.WriteLine("1. Crear");
                Console.WriteLine("2. Modificar");
                Console.WriteLine("3. Eliminar"); 
                Console.WriteLine("4. Compras");
                Console.WriteLine("5. Ver Tarjeta");
                Console.WriteLine("6. ver Listado de Tarjetas");
                Console.WriteLine("por favor ingrese su eleción:");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("¡Gracias!");

                if (eleccion ==1)
                {
                    //el usuario a elegido crear cuenta 
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la creacion de tu Tarjeta de puntos:");
                    Console.WriteLine("Por favor Proporciona los datos que se te piden ");
                    Console.WriteLine("Ingrese su nombre:");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su numero de cuenta ");
                    Nocuentas = Console.ReadLine();
                    //asignar espacio en el vector 
                    ListadoTarjeta [posiciones] = new TarjetaPuntos(Nocuentas,Nombre);
                    posiciones++;
                }
                else if (eleccion ==2)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la opcion Modificar de tu Tarjeta de puntos:");
                    Console.WriteLine("Ingrese su No. de cuenta por favor:");
                    Nocuentas = Console.ReadLine();
                    //1. buscar la pocisión
                    for (int i = 0; i < posiciones; i++)
                    {
                        if (ListadoTarjeta[i].VERCUENTA()==Nocuentas)
                        {
                            Var2 = i;
                        }
                    }
                    //mostrar la información original 
                    Console.WriteLine("");
                    Console.WriteLine("La información ingresada anteriormente es: ");
                    ListadoTarjeta[Var2].VerInformación();
                    //ingreso de información nueva 
                    //el usuario solo puede modificar su nombre. 
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nuevo nombre que aparecera en su tarjeta de puntos:");
                    Nombre = Console.ReadLine();
                    //se llama al método correpondiente a la acción modificar  
                    ListadoTarjeta[Var2].Modificar(Nombre);

                    //mostramos la nueva informacion. 
                    ListadoTarjeta[Var2].VerInformación();
                }
                else if (eleccion ==3)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la Opcion Eliminar de tu Tarjeta de puntos:");
                    Console.WriteLine("Ingrese su No. de cuenta por favor:");
                    Nocuentas = Console.ReadLine();
                    //1. buscar la pocisión
                    for (int i = 0; i < posiciones; i++)
                    {
                        if (ListadoTarjeta[i].VERCUENTA() == Nocuentas)
                        {
                            Var2 = i;
                        }
                    }
                    //se llama al metodo eliminar 
                    ListadoTarjeta[Var2].Eliminar(Nocuentas);
                }
                else if (eleccion ==4)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la opción de comprar de tu Tarjeta de puntos:");
                    Console.WriteLine("Por favor ingrese el monto de su compra:");
                    int MontoCompra = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < posiciones; i++)
                    {
                        if (ListadoTarjeta[i].VERCUENTA() == Nocuentas)
                        {
                            Var2 = i;
                        }
                    }
                    //se llama al metodo de compra 
                    ListadoTarjeta[Var2].Comprar(MontoCompra);
                }
                else if (eleccion == 5)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la opción Ver tarjeta de tu Tarjeta de puntos:");
                    //se llama al metodo ver cuenta donde podemos ver toda la informacion del usuario. 
                    for (int i = 0; i < posiciones; i++)
                    {
                        if (ListadoTarjeta[i].VERCUENTA() == Nocuentas)
                        {
                            Var2 = i;
                        }
                    }
                    ListadoTarjeta[Var2].VerInformación();
                }
                else if (eleccion ==6)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Bienvenido a la opción ver Listado de Tarjetas de puntos:");
                    for (int j = 0; j < posiciones; j++)
                    {
                        Console.WriteLine(ListadoTarjeta[j].VERCUENTA());
                    }
                }
            } while (eleccion <=6);
            Console.WriteLine("La opción ingresada no se encuentra en el menú.");
            Console.ReadKey();
            
        }
    }
}

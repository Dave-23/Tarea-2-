using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Banco
{
    class Program
    {
     
        static int option = 0;
        static bool depositar = false;
        static int deposito = 0;
        static int saldo = 0;
        static int retiro = 0;
        static int seleccion = 0;
        static int monedas = 0;
        static int tipodeCompra = 531;
        static int tipodeVenta = 544;
        static int monto = 0;
        static int tipodeCambio = 0;
        static int cinco = 5;
        static int diez = 10;
        static int venticinco = 25;
        static int cincuenta = 50;
        static int cien = 100;
        static int quinientos = 500;
        static int contcinco = 0;
        static int contdiez = 0;
        static int contventicinco = 0;
        static int contcincuenta = 0;
        static int contcien = 0;
        static int contquinientos = 0;





        static void depositar_dinero()
        {
        
            {

                Console.WriteLine("Ingrese el monto a depositar");
                deposito = int.Parse(Console.ReadLine());
                if (deposito > 0)
                {
                    saldo = saldo + deposito;
                    Console.WriteLine("El monto depositado es de: ¢" + deposito);
                    Console.WriteLine("El saldo disponible es de: ¢" + saldo);
                    depositar = true;
                }
                else
                {
                    depositar = false;
                }
            }
        }
        static void retitrar_dinero()
        {
            while (depositar == true && saldo > 0)
            {
                Console.WriteLine("El monto disponible es de: ¢" + saldo);
                Console.WriteLine();
                Console.WriteLine("Ingrese el monto que desea retirar: ");
                retiro = int.Parse(Console.ReadLine());
                if ((retiro % 2) == 0 && retiro <= saldo)
                {
                    saldo = saldo - retiro;
                    Console.WriteLine("Transaccion exitosa, su retiro de "+retiro+ " ha sido procesado");
                    Console.WriteLine("El saldo disponible es de: " + saldo);
                    Console.WriteLine("Desea realizar otro retiro");
                    Console.WriteLine("1.Si\n2.No");
                    seleccion = int.Parse(Console.ReadLine());
                    
                    if (seleccion == 1)
                    {
                        depositar = true;
                    }
                    else if (seleccion == 2)
                    {
                        depositar = false;
                    }
                    else
                    {
                        Console.WriteLine("Debe digitar el 1 o el 2 para indicar si desea continuar o terminar el retiro");
                    }
                   

                }
                else
                {
                    Console.WriteLine("El cajero solo dispensa billetes de: ¢20 000, ¢10 000, ¢5000 , ¢2000");
                    Console.WriteLine("Debe solicitar un monto igual o inferior al saldo que tiene disponible");
                    Console.WriteLine("Ingrese nuevamente el monto a retirar");
                }





            }
            Console.ReadKey();
        }
        static void recibir_monedas()
        {
            int total=0; 
            while(monedas <= 50){
            Console.WriteLine("Ingrese la monedas que desea depositar: ");
            deposito = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite que moneda desea depositar: ");
            Console.WriteLine("1.5\n2.10\n3.25\n4.50\n5.100\n6500.");
            seleccion = int.Parse(Console.ReadLine());
            monedas++;
            if (seleccion == 1)
            {
                cinco++;
                contcinco++;
                
            }
            else if (seleccion == 2)
            {
                diez++;
                contdiez++;
                
            }
            else if (seleccion == 3)
            {
                venticinco++;
                contventicinco++;
            }
            else if (seleccion == 4)
            {
                cincuenta++;
               contcincuenta++;
            }
            else if (seleccion == 5)
            {
                cien++;
                contcien++;
            }
            else if (seleccion == 6)
            {
                quinientos++;
                contquinientos++;
            }
            else
            {
                Console.WriteLine("Digite una opcion valida.");
            }
            }
            total = cinco + diez + venticinco + cincuenta + cien + quinientos;
            Console.WriteLine("El total de todas las monedas depositadas es de: "+ total);
            saldo = saldo + total;
            Console.WriteLine("Se depositaron" + contcinco+ "de cinco");
            Console.WriteLine("El total de todas las monedas depositadas es de: " + contdiez + "de diez");
            Console.WriteLine("El total de todas las monedas depositadas es de: " + contventicinco + "de Veinti Cinco");
            Console.WriteLine("El total de todas las monedas depositadas es de: " + contcincuenta + "de Cincuenta");
            Console.WriteLine("El total de todas las monedas depositadas es de: " + contcien + "de Cien");
            Console.WriteLine("El total de todas las monedas depositadas es de: " + contquinientos + "de Quinientos");





            Console.ReadKey();
        }
        static void indicar_tipodecambio()
        {
            DateTime thisDay = DateTime.Today;
            if (seleccion == 1)
            {
                Console.WriteLine("Ingrese el monto en Colones que desea cambiar a Dolares : ");
                monto = int.Parse(Console.ReadLine());
                tipodeCambio = monto / tipodeVenta;
                Console.WriteLine("El tipo de cambio del dia es de: "+tipodeVenta);
                Console.WriteLine("La conversion de Colones a Dolares para el monto que se indico es de: $"+tipodeCambio);
                Console.WriteLine(thisDay.ToString("D"));


            }
            else if (seleccion == 2)
            {
                Console.WriteLine("Ingrese el monto en Dolares que desea cambiar a Colones : ");
                monto = int.Parse(Console.ReadLine());
                tipodeCambio = monto * tipodeCompra;
                Console.WriteLine("El tipo de cambio del dia es de: "+tipodeCompra);
                Console.WriteLine("La conversion de Colones a Dolares para el monto que se indico es de: ¢" + tipodeCambio);
                Console.WriteLine(thisDay.ToString("D"));
            }
            else
            {
                Console.WriteLine("Seleccione uno opcion valida.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("*************Cajero Banco Estado*****************");
                Console.WriteLine("----------------Menu Principal-------------------");
                Console.WriteLine("1. Deposito de dinero.");
                Console.WriteLine("2. Retiro de Dinero.");
                Console.WriteLine("3. Recibo de monedas.");
                Console.WriteLine("4. Consulta tipo de cambio.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Seleccione una opción");
                try
                {
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            {
                                Console.Clear();
                                depositar_dinero();

                                Console.ReadKey();

                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                retitrar_dinero();

                                Console.ReadKey();


                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                recibir_monedas();
                                seleccion = int.Parse(Console.ReadLine());

                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("Seleccione que tipo de cambio desea recibir");
                                Console.WriteLine("1.Colones - Dolares'\n2.Dolares - Colones");
                                seleccion = int.Parse(Console.ReadLine());
                                indicar_tipodecambio();
                                break;
                            }
                        case 5:
                            {
                                //Salir
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Seleccione una opción válida..");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Antes de ingresar la opcion 2 debe depositar dinero en su cuenta. ");
                }
            } while (option != 5);
        }
    }
}

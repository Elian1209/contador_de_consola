using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        public int calculador(int pre_h, int pre_p, int pre_b, int ham, int pa, int beb)
        {
            return (pre_h * ham) + (pre_p * pa) + (pre_b * beb);
        }
        static void Main(string[] args)
        {
            int cant_h, cant_p, cant_b, cant_a, cant_f, cant_m;
            int pagar;
            int errores = 0;
            string linea;
            int precio_h = 1000;
            int precio_p = 1500;
            int precio_b = 500;
            int precio_a = 2000;
            int precio_f = 1500;
            int precio_m = 1000;
            string clave;
            string opciones;
            string usuario;
            int login;
            int contador = 0;
            Console.WriteLine("introduzca el usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Introduzca la clave");
            clave = Console.ReadLine();
            ServiceReference1.Service1Client servicionexterno = new ServiceReference1.Service1Client();
            login = servicionexterno.Autorizacion(usuario, clave);
            while (login == 0)
            {
                errores = errores + 1;
                if (errores == 3)
                {
                    Console.WriteLine(" maximo de intentos superados se reiniciara el sistema");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("contraseña incorrecta, vuelve a intentar");
                Console.WriteLine("introduzca el usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Introduzca la clave");
                clave = Console.ReadLine();
                login = servicionexterno.Autorizacion(usuario, clave);
            }
            while (login == 1)
            {
                Console.WriteLine("ha ingresado al sitema de la soda");
                Console.WriteLine("cantidad de hamburguesas:");
                linea = Console.ReadLine();
                cant_h = int.Parse(linea);
                Console.WriteLine("cantidad de papas:");
                linea = Console.ReadLine();
                cant_p = int.Parse(linea);
                Console.WriteLine("cantidad de bebidas:");
                linea = Console.ReadLine();
                cant_b = int.Parse(linea);
                Console.WriteLine();
                pagar = (cant_h * precio_h) + (cant_p * precio_p) + (cant_b * precio_b);
                contador = contador + pagar;
                Console.WriteLine("el monto a pagar es igual a: " + pagar);
                Console.WriteLine(" precione A si desea ver el monto total de productos comprados o R reiniciar o S para salir");
                opciones = Console.ReadLine();
                {
                    while (opciones == "A")
                    {
                        Console.WriteLine("El total vendido es de: " + contador);
                        Console.WriteLine(" precione R si desea ver el monto total de productos comprados o S salir");
                        opciones = Console.ReadLine();
                    }
                    if (opciones == "R")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        if (opciones == "S")
                        {
                            break;//forzar la salida del buckle                                   
                        }
                        else
                        {
                            if (opciones != "A" && opciones != "S")
                            {
                                Console.WriteLine("La tecla es incorrecta favor volver a seleccionar");
                                Console.ReadLine();
                                Console.WriteLine(" precione A si desea ver el monto total de productos comprados o R reiniciar o S para salir");
                                opciones = Console.ReadLine();
                            }
                        }
                    }

                }
            }
            while (login == 2)
            {
                Console.WriteLine("ha ingresado al sitema del supermercado");
                Console.WriteLine("cantidad de paquetes de arroz:");
                linea = Console.ReadLine();
                cant_a = int.Parse(linea);
                Console.WriteLine("cantidad de paquetes de frijoles:");
                linea = Console.ReadLine();
                cant_f = int.Parse(linea);
                Console.WriteLine("cantidad de paquetes de masa:");
                linea = Console.ReadLine();
                cant_m = int.Parse(linea);
                Console.WriteLine();
                pagar = (cant_a * precio_a) + (cant_f * precio_f) + (cant_m * precio_m);
                contador = contador + pagar;
                Console.WriteLine("el monto a pagar es igual a: " + pagar);
                Console.WriteLine(" precione A si desea ver el monto total de productos comprados o S para salir");
                opciones = Console.ReadLine();
                login = servicionexterno.Autorizacion(usuario, clave);
                {
                    while (opciones == "A")
                    {
                        Console.WriteLine("El total vendido es de: " + contador);
                        Console.WriteLine(" precione R si desea ver el monto total de productos comprados o S salir");
                        opciones = Console.ReadLine();
                    }
                    if (opciones == "R")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        if (opciones == "S")
                        {
                            break;//forzar la salida del buckle
                        }

                        else
                        {
                            if (opciones != "A" && opciones != "S")
                            {
                                Console.WriteLine("La tecla es incorrecta favor volver a seleccionar");
                                Console.ReadLine();
                                Console.WriteLine(" precione A si desea ver el monto total de productos comprados o R reiniciar o S para salir");
                                opciones = Console.ReadLine();
                                login = servicionexterno.Autorizacion(usuario, clave);
                            }
                        }
                    }
                }

            } 
            Console.WriteLine("Gracias por utilizar nuestro servicio");
            Console.ReadLine();
        }
    }
           

}
                



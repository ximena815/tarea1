using System;

namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bienvenido a casa 1 ;3");

            Random aleatorio = new Random();
            string respuesta = "s";
            int dado1 = 0, total = 0, tiroA = 0, dadoes = 2, vidas = 3, unos = 0;
            Console.WriteLine("tines " + vidas + "vidas");
            while (respuesta == "s" && total < 100 && vidas != 0)
            {
                while (dadoes > 0 && respuesta == "s")
                {
                    Console.WriteLine("tienes dados especiales: " + dadoes);
                    Console.WriteLine("¿tirar el dado especial?");
                    respuesta = Console.ReadLine();
                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("¿Deseas tirar el dado especial otra vez? (s/n)");
                        respuesta = Console.ReadLine();
                    }

                    if (respuesta == "s")
                    {
                        dado1 = aleatorio.Next(1, 13);
                        Console.WriteLine("tu dado es: " + dado1);
                        total += dado1;
                        dadoes--;
                    }
                    else
                    {
                        Console.WriteLine("tienes dados especiales: " + dadoes);
                        break;
                    }
                    if (dado1 == 1) //consecutivos 1s
                    {
                        unos++;
                        Console.WriteLine("1s cosecutivos: " + unos);
                        if (unos % 2 == 0)
                        {
                            vidas--;
                            Console.WriteLine("tines " + vidas + "vidas");
                            unos = 0;
                            total -= 10;
                            Console.WriteLine("tu total actual es: " + total);
                        }
                    }
                    if (dado1 == 6 && tiroA == 6 && vidas < 3) //consecutivos 6s
                    {
                        vidas++;
                        Console.WriteLine("tines " + vidas + "vidas");
                    }
                    tiroA = dado1;

                }
                //----------------------------------------------------------------
                Console.WriteLine("¿tirar el dado?");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.WriteLine("¿Deseas tirar el dado otra vez? (s/n)");
                    respuesta = Console.ReadLine();
                }

                if (respuesta == "s")
                {
                    dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("tu dado es: " + dado1);
                    total += dado1;
                    Console.WriteLine("tu total actual es: " + total);
                    if (dado1 == 1) //consecutivos 1s
                    {
                        unos++;
                        Console.WriteLine("1s cosecutivos: " + unos);
                        
                    }
                    if (unos == 2)
                    {
                        vidas--;
                        Console.WriteLine("tines " + vidas + "vidas");
                        unos = 0;
                        total -= 10;
                        Console.WriteLine("tu total actual es: " + total);
                    }
                    if (dado1 == 6 && tiroA == 6 && vidas < 3) //consecutivos 6s
                    {
                        vidas++;
                        Console.WriteLine("tines " + vidas + "vidas");
                    }

                    tiroA = dado1;
                    //ganar-perder
                    if (vidas == 0)
                    {
                        Console.WriteLine("Se quedo sin vidas mijo");
                        break;
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("no me lo creo ganaste");
                        respuesta = "n";
                        Console.ForegroundColor = ConsoleColor.Green;
                        string pajarito =
                          "\n  ^ ^" +
                          "\n (O,O)" +
                          "\n (   )" +
                          "\n  T T";
                        Console.WriteLine(pajarito);

                    }

                }
                else
                {
                    Console.WriteLine("le estan saliendo como plumas mijo");
                    Console.WriteLine("te falto " + (100 - total));
                    break;
                }

            }
                    

        }
    }
}

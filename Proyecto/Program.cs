using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculo();
            

        }

        public static void Calculo()
        {
            string[] palabras = new string[] { "PIEDRA", "TIJERA", "PAPEL" };
            Random r = new Random();
            int contadorPartidas = 0;
            int contadorVictorias = 0;
            int contadorDerrotas = 0;
            int contadorEmpates = 0;
            Console.WriteLine("Ingrese piedra, papel o tijera, en el formato que desee.");
            Console.WriteLine("Para finalizar el programa escriba STOP");
            string choice = Console.ReadLine();
            string valorDelUsuario = choice.ToUpper();

            while (valorDelUsuario != "STOP")
            {

                contadorPartidas++;
            string valorMaquina;
            valorMaquina = palabras[r.Next(0, 3)];
            Console.WriteLine("Programa: ");
            Console.WriteLine(valorMaquina);



            switch (valorDelUsuario)
            {


                case "PIEDRA":
                    if (valorMaquina == valorDelUsuario)
                    {
                        Console.WriteLine("\nEMPATE. Ambos han elegido el mismo elemento");
                            contadorEmpates++;

                    }
                    else if (valorMaquina == palabras[1])
                    {
                        Console.WriteLine("\nGANASTE");
                            contadorVictorias++;
                    }
                    else if(valorMaquina == palabras[2])
                    {
                        Console.WriteLine("\nPERDISTE");
                            contadorDerrotas++;
                    }
                    Console.WriteLine(" ");
                    break;


                case "PAPEL":
                    if (valorMaquina == valorDelUsuario)
                    {
                        Console.WriteLine("\nEMPATE. Ambos han elegido el mismo elemento");
                            contadorEmpates++;
                    }
                    else if (valorMaquina == palabras[1])
                    {
                        Console.WriteLine("\nPERDISTE");
                            contadorDerrotas++;
                    }
                    else if (valorMaquina == palabras[0])
                    {
                        Console.WriteLine("\nGANASTE");
                            contadorVictorias++;
                    }
                    Console.WriteLine(" ");
                    break;
                    

                case "TIJERA":
                    if(valorMaquina == valorDelUsuario)
                    {
                        Console.WriteLine("\nEMPATE. Ambos han elegido el mismo elemento");
                            contadorEmpates++;
                    }
                    else if (valorMaquina == palabras[0])
                    {
                        Console.WriteLine("\nPERDISTE");
                            contadorDerrotas++;
                    }
                    else if (valorMaquina == palabras[2])
                    {
                        Console.WriteLine("\nGANASTE");
                            contadorVictorias++;
                    }
                    Console.WriteLine(" ");
                    break;

                    default:
                    Console.WriteLine("Has ingresado un dato que no esta entre lo sugerido");
                    Console.WriteLine("Se finalizará el programa mostrando los resultados al momento");
                        contadorPartidas--;
                    valorDelUsuario = "STOP";
                    break;
            }
                Console.WriteLine("Ingrese piedra, papel o tijera, en el formato que desee.");
                Console.WriteLine("Para finalizar el programa escriba STOP");
                choice = Console.ReadLine();
                valorDelUsuario = choice.ToUpper();

            }

            Console.WriteLine($"\nCantidad de partidas: {contadorPartidas}");
            Console.WriteLine($"Victorias del usuario: {contadorVictorias}");
            Console.WriteLine($"Derrotas del usuario: {contadorDerrotas}");
            Console.WriteLine($"Empates del usuario: {contadorEmpates}");


        }
    }
}

using System;
using System.Threading;

namespace JuegoXO
{
      class JugarXO
    {
        static char[] matriz = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private int jugador = 1;
        private int posicion;
        private bool opcion = true;

        public  void jugar()
        {
            do
            {

                Console.Clear();
               

                Console.WriteLine("Bienvenido al juego de equis y cero......");

                if (jugador % 2 == 0)
                {
                    Console.WriteLine("Es el turno del jugador O");
                }
                else
                {
                    Console.WriteLine("Es el turno del Jugador X");
                }
                pizarra();
                posicion = int.Parse(Console.ReadLine());


                if (matriz[posicion] != 'X' && matriz[posicion] != 'O')
                {
                    if (jugador % 2 == 0)
                    {
                        matriz[posicion] = 'O';
                    }
                    else
                    {
                        matriz[posicion] = 'X';
                    }
                    if (RevisarGanador())
                    {
                        jugador++;
                    }
                    else
                    {
                        Console.Clear();
                        pizarra();
                    }

                }
                else
                {
                    Console.WriteLine("Lo siento este lugar ya está Marcado, selecciones otro Lugar.........!");
                    Console.WriteLine("Por favor espere 2 segundos.......!!");
                    Thread.Sleep(2500);

                    
                }



                opcion = RevisarGanador();






            } while (opcion);

            if (jugador % 2 == 0)
            {
                Console.WriteLine("El jugador O es el ganador");
            }
            else
            {
                Console.WriteLine("El jugador X es el ganador");
            }
        }

        public  bool RevisarGanador()
        {
            if (matriz[1] == matriz[2] && matriz[2] == matriz[3])
            {
                return false;
            }
            else if (matriz[1] == matriz[4] && matriz[4] == matriz[7])
            {
                return false;
            }
            else if (matriz[7] == matriz[8] && matriz[8] == matriz[9])
            {
                return false;
            }
            else if (matriz[3] == matriz[6] && matriz[6] == matriz[9])
            {
                return false;
            }
            else if (matriz[1] == matriz[5] && matriz[5] == matriz[9])
            {
                return false;
            }
            else if (matriz[7] == matriz[5] && matriz[5] == matriz[3])
            {
                return false;
            }
            else if (matriz[2] == matriz[5] && matriz[5] == matriz[8])
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public  void pizarra()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", matriz[1], matriz[2], matriz[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", matriz[4], matriz[5], matriz[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", matriz[7], matriz[8], matriz[9]);
            Console.WriteLine("     |     |     ");

        }

    }
}

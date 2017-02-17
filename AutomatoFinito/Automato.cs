using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatoFinito
{
    class Automato
    {
        public static void Main(string[] args)
        {
            //Variaveis 
            string cadeia;
            bool check = false;
            bool estadoFinal = false;
            int contador = 1;
            int[] digito = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] status = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] hexa = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] sinal = new char[2] { '-', '+' };

            //Ver se a cadeia não é vazia ou nulla
            do
            {
                Console.Out.WriteLine("Digite a cadeia");
                cadeia = Console.ReadLine();
                if (String.IsNullOrEmpty(cadeia))
                {
                    Console.Out.WriteLine("Cadeia Nula ou Vazia");
                    Console.Out.WriteLine("Escrever nova Cadeia");
                    cadeia = Console.ReadLine();
                }
                 else
                {
                        check = true;
                }
            } while (check== false);
            //Transforma a cadeia em um Array de char
            char[] cadeiaSeparada = cadeia.ToCharArray();


            while (contador < cadeiaSeparada.Length )
            {

                switch (contador)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    default:
                        break;
                }

            }

            if (estadoFinal)
            {
                Console.Out.WriteLine("Cadeia Aceita");
            }
            else
            {
                Console.Out.WriteLine("Cadeia não Aceita");
            }

        }
    }
}

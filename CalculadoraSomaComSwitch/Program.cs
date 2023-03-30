using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSomaComSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcao = true;

            
            int inicial, valorfinal, soma,saida;
            
            Console.WriteLine("Vamos realizar a soma dos valores até que escolha encerrar o programa ok? ");
            
                while (opcao == true)
            {
                
                Console.WriteLine("Digite um valor inicial para soma");
                inicial = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor que deseja somar ao valor inicial: ");
                valorfinal = int.Parse(Console.ReadLine());
                soma = inicial + valorfinal;

                Console.WriteLine("Os valores digitados são {0} e {1} totalizando o valor final de => {2}", inicial, valorfinal, soma);

                Console.WriteLine("Deseja sair do programa ? 1 p/ Sim e 2 p/ Não ");
                saida = int.Parse(Console.ReadLine()); 
                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Obrigado por participar!");
                        opcao = false;

                        break;
                    case 2:
                        Console.WriteLine("Continuar soma...");
                        opcao = true;

                        break;
                    default: 
                        Console.WriteLine("Opção inválida reinicie o programa");
                        break;

                }
            }
        }
    }
}

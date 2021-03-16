using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int jogadas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= jogadas  ; i++) //insira a variavel correta
            {   
                if(i > 100) return;
                string[] jogadores = Console.ReadLine().Split(" ");
                string sheldon = jogadores[0].ToLower();
                string raj = jogadores[1].ToLower();
                
                switch (sheldon)
                {
                    case "pedra":
                        switch (raj)
                        {
                            case "lagarto":
                            case "tesoura":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "pedra":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "papel":
                        switch (raj)
                        {
                            case "pedra":
                            case "spock":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "papel":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "tesoura":
                        switch (raj)
                        {
                            case "papel":
                            case "lagarto":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "tesoura":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "lagarto":
                        switch (raj)
                        {
                            case "spock":
                            case "papel":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "lagarto":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "spock":
                        switch (raj)
                        {
                            case "tesoura":
                            case "pedra":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "spock":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

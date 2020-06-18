using System;
using eDaemon.Entities;

namespace eDaemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Character playerCharacter;

            Console.WriteLine("Criação de personagem para Daemon");
            Console.WriteLine("Escolha uma classe: ");
            Console.WriteLine("1 - Tanque (FR 15, DEX 14, AGI 14, CONS 18, INT 10, WILL 10, PER 9, CAR 11)");
            Console.WriteLine("2 - Arqueiro (FR 12, DEX 17, AGI 16, CONS 11, INT 10, WILL 12, PER 14, CAR 9)");
            int classChoice = int.Parse(Console.ReadLine());

            switch (classChoice)
            {
                case 1:
                    playerCharacter = new Character(15, 14, 14, 18, 10, 10, 9, 11);
                    break;
                case 2:
                    playerCharacter = new Character(12, 17, 16, 11, 10, 12, 14, 9);
                    break;
                default:
                    Console.WriteLine("escolha inválida.");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("Personagem escolhido: ");
            
        }
    }
}

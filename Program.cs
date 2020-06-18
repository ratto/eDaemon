using System;
using eDaemon.Entities;

namespace eDaemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int fr, dex, agi, cons, intel, will, per, car;
            string name;

            Console.WriteLine("Criação de personagem para Daemon");
            Console.WriteLine("Nome do personagem:");
            name = Console.ReadLine();

            Console.WriteLine("Escolha uma classe: ");
            Console.WriteLine("1 - Tanque (FR 15, DEX 14, AGI 14, CONS 18, INT 10, WILL 10, PER 9, CAR 11)");
            Console.WriteLine("2 - Arqueiro (FR 12, DEX 17, AGI 16, CONS 11, INT 10, WILL 12, PER 14, CAR 9)");
            int classChoice = int.Parse(Console.ReadLine());

            switch (classChoice)
            {
                case 1:
                    fr = 15;
                    dex = 14;
                    agi = 14;
                    cons = 18;
                    intel = 10;
                    will = 10;
                    per = 9;
                    car = 11;
                    break;
                case 2:
                    fr = 12;
                    dex = 17;
                    agi = 16;
                    cons = 11;
                    intel = 10;
                    will = 12;
                    per = 14;
                    car = 9;
                    break;
                default:
                    fr = 15;
                    dex = 14;
                    agi = 14;
                    cons = 18;
                    intel = 10;
                    will = 10;
                    per = 9;
                    car = 11;
                    break;
            }

            PlayerCharacter playerCharacter = new PlayerCharacter(name, fr, dex, agi, cons, intel, will, per, car);
            Console.WriteLine();

            Console.WriteLine("Personagem escolhido: ");
            Console.WriteLine();
            Console.WriteLine(playerCharacter.ToString());
        }
    }
}

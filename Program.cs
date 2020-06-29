using System;
using System.Globalization;
using System.Collections.Generic;
using eDaemon.Entities.Character;
using eDaemon.Entities.GameWorld.Items;
using eDaemon.Services;

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
            Console.WriteLine("3 - Mago (FR 9, DEX 13, AGI 12, CONS 10, INT 18, WILL 16, PER 12, CAR 11)");
            Console.WriteLine();
            int classChoice = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
                case 3:
                    fr = 9;
                    dex = 13;
                    agi = 12;
                    cons = 10;
                    intel = 18;
                    will = 16;
                    per = 12;
                    car = 11;
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

            PlayerCharacter playerCharacter = new PlayerCharacter(name, 19, fr, dex, agi, cons, intel, will, per, car);

            Console.WriteLine("Personagem escolhido: ");
            Console.WriteLine();
            Console.WriteLine(playerCharacter.ToString());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pontos de perícia: " + ((playerCharacter.Intelligence * 5) + (playerCharacter.Age * 10)));
            Console.WriteLine("--------------------------");

            playerCharacter.CombatSkills.Add(new CombatSkill("Briga", playerCharacter.getMod(playerCharacter.Agility), playerCharacter.getMod(playerCharacter.Agility)));
            playerCharacter.CombatSkills.Add(new CombatSkill("Arcos", playerCharacter.getMod(playerCharacter.Dexterity), 0));
            playerCharacter.CombatSkills.Add(new CombatSkill("Escudos", 0, playerCharacter.getMod(playerCharacter.Constitution)));
            playerCharacter.CombatSkills.Add(new CombatSkill("Espadas", playerCharacter.getMod(playerCharacter.Dexterity), playerCharacter.getMod(playerCharacter.Dexterity)));

            Console.WriteLine("PERÍCIAS DE COMBATE");
            foreach(CombatSkill skill in playerCharacter.CombatSkills)
            {
                Console.WriteLine(skill.ToString());
            }

            Console.WriteLine("--------------------------");

            playerCharacter.CommonSkills.Add(new Skill("Esquiva", playerCharacter.getMod(playerCharacter.Agility)));
            playerCharacter.CommonSkills.Add(new Skill("Observação", playerCharacter.getMod(playerCharacter.Perception)));
            playerCharacter.CommonSkills.Add(new Skill("Intimidação", playerCharacter.getMod(playerCharacter.useGreaterMod(playerCharacter.Charisma, playerCharacter.Constitution))));
            
            Console.WriteLine("PERÍCIAS");
            foreach(Skill skill in playerCharacter.CommonSkills)
            {
                Console.WriteLine(skill.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("ITENS");

            List<Damage> weaponDamageList = new List<Damage>();
            Damage weaponDamage = new Damage(DamageType.Cinetic, 1, 10);
            weaponDamageList.Add(weaponDamage);
            weaponDamage = new Damage(DamageType.Fire, 1, 7);
            weaponDamageList.Add(weaponDamage);
            List<DamageType> weaponDamageTypeList1 = new List<DamageType>();
            weaponDamageTypeList1.Add(DamageType.Fire);
            Weapon fireLongSword = new Weapon(0142, "Espada Longa", weaponDamageTypeList1, -5, weaponDamageList);
            Console.WriteLine(fireLongSword.ToString());

            List<Damage> secondWeaponDamageList = new List<Damage>();
            weaponDamage = new Damage(DamageType.Cinetic, 3, 8);
            secondWeaponDamageList.Add(weaponDamage);
            weaponDamage = new Damage(DamageType.Cold, 2, 5);
            secondWeaponDamageList.Add(weaponDamage);
            int[] reach = { 80, 200 };

            List<DamageType> weaponDamageTypeList2 = new List<DamageType>();
            weaponDamageTypeList2.Add(DamageType.Cold);

            Weapon frostLongBow = new Weapon(0315, "Arco Longo", weaponDamageTypeList2, -9, reach, secondWeaponDamageList);
            Console.WriteLine(frostLongBow.ToString());

            List<Damage> protectionIndexList = new List<Damage>();
            Damage protectionIndex = new Damage(DamageType.Cinetic, 3);
            protectionIndexList.Add(protectionIndex);
            protectionIndex = new Damage(DamageType.Wind, 2);
            protectionIndexList.Add(protectionIndex);

            List<DamageType> ipType = new List<DamageType>();
            ipType.Add(DamageType.Wind);

            Armor galeChainShirt = new Armor(8214, "Cota de Malha", ipType, -4, -3, protectionIndexList);

            /*
            List<DamageType> armorDamageTypeList1 = new List<DamageType>();
            armorDamageTypeList1.Add(DamageType.Wind);
            */
            // Armor galeChainShirt = new Armor(2310, "do Vendaval", "Cota de Malha", -4, -3, new List<Damage>(protectionIndexList));
            Console.WriteLine(galeChainShirt.ToString());
        }
    }
}

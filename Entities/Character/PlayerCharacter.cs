using System.Text;

namespace eDaemon.Entities.Character
{
    class PlayerCharacter : Character
    {
        private string _name;
        private int _age;

        public PlayerCharacter(string name, int age, int strength, int dexterity, int agility, int constitution, int intelligence, int willPower, int perception, int charisma) : base(strength, dexterity, agility, constitution, intelligence, willPower, perception, charisma)
        {
            _name = name;
            _age = age;
        }

        public string getName()
        {
            return _name;
        }

        public int getAge()
        {
            return _age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_name);
            sb.AppendLine("Idade: " + _age);
            sb.AppendLine("--------------------------");
            sb.AppendLine("Força " + Strength + " / " + getMod(Strength));
            sb.AppendLine("Destreza " + Dexterity + " / " + getMod(Dexterity));
            sb.AppendLine("Agilidade " + Agility + " / " + getMod(Agility));
            sb.AppendLine("Constituição " + Constitution + " / " + getMod(Constitution));

            sb.AppendLine("Inteligência " + Intelligence + " / " + getMod(Intelligence));
            sb.AppendLine("Força de Vontade " + WillPower + " / " + getMod(WillPower));
            sb.AppendLine("Percepção " + Perception + " / " + getMod(Perception));
            sb.AppendLine("Carisma " + Charisma + " / " + getMod(Charisma));

            sb.AppendLine("--------------------------");
            sb.AppendLine("HP " + _hpTotal + " / " + _hpCurrent);

            return sb.ToString();
        }
    }
}

namespace eDaemon.Entities.Character
{
    class Skill
    {
        public string name;
        public int score;

        public Skill()
        {
        }

        public Skill(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return name + " " + score;
        }
    }
}

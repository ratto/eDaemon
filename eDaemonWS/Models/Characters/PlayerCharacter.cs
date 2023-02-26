namespace eDaemonWS.Models.Characters
{
    public class PlayerCharacter : Character
    {
        public string? Name { get; set; }
        public short Age { get; set; }
        public short Level { get; set; }
        public short ConstitutionMod { get; set; }
        public short StrengthMod { get; set; }
        public short DexterityMod { get; set; }
        public short AgilityMod { get; set; }
        public short IntelligenceMod { get; set; }
        public short WillPowerMod { get; set; }
        public short PerceptionMod { get; set; }
        public short CharismaMod { get; set; }
    }
}

namespace Creatures.BestiaryC0
{
    internal class GiantFireBeetle : Creatures
    {
        readonly Dices dice = new();
        public GiantFireBeetle()
        {
            Name = "Giant Fire Beetle";
            Type = ba;
            Size = s;
            Alignment = ud;
            HitPoints = 4 + dice.Roll(dice.d6 + 1);
            Attributes = [8, 10, 12, 1, 7, 3];
            ArmorClass = 13;
            Speed = "30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "blindsight 30ft, passive Perception 8";
            Actions = [
                @"
Bite. Melee Weapon Attack:+ 1 to hit, re ach 5 ft., one target.
Hit: 2 (1d6 - 1), slashing damage."
                ];
            Abilities = [
                @"
Illumination. The beetle sheds bright light in a 10-foot radius
and dim light for an additional 10 feet."                
            ];
        }
    }
}
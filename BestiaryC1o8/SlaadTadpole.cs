namespace Creatures.BestiaryC1o8
{
    internal class SlaadTadpole : Creatures
    {
        readonly Dices dice = new();
        public SlaadTadpole()
        {
            Name = "Slaad Tadpole";
            Type = ab;
            Size = t;
            Alignment = cn;
            HitPoints = 10 + dice.RollMultiple(dice.d4, 4);
            Attributes = [7, 15, 10, 3, 5, 3];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            DamageResistances = "acid, cold, fire, lighting, thunder";
            Skills = "Stealth +4";
            Senses = "darkvision 60ft, passive Perception 7";
            Languages = "understands Slaad but can't speak";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5ft, one target.
Hit: 4 (1d4 + 2) piercing damage."
                ];
            Abilities = [
                @"                
                Magic Resistance. The Slaad had advantage on saving throws"
            ];
        }
    }
}
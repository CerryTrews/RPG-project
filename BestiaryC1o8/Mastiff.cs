namespace Base.BestiaryC1o8
{
    internal class Mastiff : Creature
    {

        public Mastiff()
        {
            Name = "Mastiff";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 5 + Roll(8) + 1;
            Attributes = [13, 14, 12, 3, 12, 7];
            ArmorClass = 12;
            Speed = "40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
            @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 4 (1d6 + 1) piercing damage. If the target is a creature,
it must succeed on a DC 11 Strength saving throw or be knocked prone."
            ];
            Abilities = [
                @"                
Keen Hearing and Smell. The mastiff has advantage on Wisdom 
(Perception ) checks that rely on hearing or smell."
            ];
            Attacks =
            [
                new(AttackList.Bite, DamageTypes.Piercing,RangeTypes.Melee, "1d6 + 1")

            ];
        }
    }
}
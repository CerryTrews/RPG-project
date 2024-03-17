using Creatures.CombatAttributes;

namespace Creatures.BestiaryC0
{
    internal class Eagle : Creature
    {

        public Eagle()
        {
            Name = "Eagle";
            Type = Types.Beast;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 3 + Roll(6);
            Attributes = [6, 15, 10, 2, 14, 7];
            ArmorClass = 12;
            Speed = "10ft, fly 60ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Actions = [
                @"
Talons. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 4 (1d4 + 2) slashing damage."
                ];
            Abilities = [

                @"
Keen Sight. The eagle has advantage on Wisdom (Perception) checks that rely on sight."

                ];
            Attacks = new List<Attack>
            {
                new Attack {AtkName = AttackList.Talons, Types = DamageTypes.Slashing, Range = Range.Melee, Dice = "1d4 + 2"}
            };
        }
    }
}
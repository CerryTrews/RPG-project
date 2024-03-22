using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Stirge : Creature
    {

        public Stirge()
        {
            Name = "Stirge";
            Type = Types.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 2 + Roll(4);
            AttributeValue = [4, 16, 11, 2, 8, 6];
            ArmorClass = 14;
            Speed = "10ft, fly 40ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "darkvision 60ft, passive Perception 9";
            Actions = [
                @"
Blood Drain. Melee Weapon Attack: +5 to hit, reach 5ft, one creature.
Hit: 5 (1d4 + 3) piercing damage, and the stirge attaches to the target.
While attached, the stirge doesn`t attack. Instead, at the start of each
of the stirge`s turns, the target loses 5 (1d4 + 3) hit points due to
blood loss.
The stirge can detach itself by spending 5ft of its movement. It does so
after it drains 10 hit points of blood from the target or the target dies.
A creature, including the target, can use its actions to detach the stirge."
                ];

            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Attacks = [
                new(AttackList.BloodDrain, DamageTypes.Piercing, RangeTypes.Melee, "1d4 + 3", 5, 5, DamageTypes.Bleed, "1d4 + 3", 10, AttributeName.Constitution )
                ];
        }
    }
}
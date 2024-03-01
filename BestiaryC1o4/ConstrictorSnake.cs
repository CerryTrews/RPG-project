﻿namespace Creatures.BestiaryC1o4
{
    internal class ConstrictorSnake : Creatures
    {

        public ConstrictorSnake()
        {
            Name = "Constrictor Snake";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 13 + RollMultiple(10, 2) + 2;
            ArmorClass = 12;
            Speed = "30ft, swim 30ft";
            Attributes = [15, 14, 12, 1, 10, 3];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "blindsight 10ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 5 (1d6 + 2) piercing damage.",
@"
Constrict: Melee Weapon Attack: +4 1 ,reach 5 ft, one
creature. Hit: 6 (1d8 + 2) bludgeoning damage and the
target is grappled (escape DC 14). Until this grapple ends,
the creature is restrained, and the snake can't constrict
another target."
                ];
        }
    }
}

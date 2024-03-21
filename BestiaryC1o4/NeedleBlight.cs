﻿namespace Base.BestiaryC1o4
{
    internal class NeedleBlight : Creature
    {

        public NeedleBlight()
        {
            Name = "Needle Blight";
            Type = Types.Plant;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 11 + RollMultiple(8, 2) + 2;
            Attributes = [12, 12, 13, 4, 8, 3];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            ConditionImmunities = "blinded, deafened";
            Senses = "blindsight 60ft, (blind beyond this radius), passive Perception 9.";
            Languages = "Uderstands Common but can`t speak";
            Actions = [
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 6 (2d4+1) piercing damage.",
            @"
Needles. Ranged Weapon Attack: +3 to hit, range 30/60ft,
one target.
Hit: 8 (2d6 + 1) piercing damage."
];
        }
    }
}

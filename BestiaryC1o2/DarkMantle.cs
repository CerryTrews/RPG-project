﻿namespace Base.BestiaryC1o2
{
    internal class DarkMantle : Creature
    {

        public DarkMantle()
        {
            Name = "Darkmantle";
            Type = Types.Monstruosity;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 22 + RollMultiple(6, 5) + 5;
            ArmorClass = 11;
            Speed = "10ft, fly 30ft";
            Attributes = [16, 12, 13, 2, 10, 5];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Stealth +3";
            Senses = "blindsight 60ft, passive Perception 10";
            Actions = [
                @"
Crush. Melee Weapon Attack: +5 to hit, reach 5 ft, one creature.
Hit: 6 (ld6 + 3) bludgeoning damage, and the darkmantle
attaches to the target. If the target is Medium or smaller and
the darkmantle has advantage on the attack roll, it attaches by
engulfing the target's head, and the target is also blinded and
unable to breathe while the darkmantle is attached in this way.
While attached to the target, the darkmantle can attack no
other creature except the target but has advantage on its attack
rolls. The darkmantle's speed also becomes 0, it can't benefit
from any bonus to its speed, and it moves with the ta rget.
A creature can detach the darkmantle by making a successfu l
DC l3 Strength check as an action. On its turn, the darkmantle
can detach itselffrom the target by using 5 feet of movement.",
                @"
Darkness Aura (1/Day). A 15-foot radius of magical darkness
extends out from the darkmantle, moves with it, and spreads
around corners. The darkness lasts as long as the darkmantle
mai ntains concentration, up to 10 min utes (as if concentrating
on a spell). Darkvision can't penetrate this darkness , and no
natural light can illuminate it. If any of the darkness overlaps
with an area of light created by a spell of 2nd level or lower, the
spell creating the light is dispelled."
                ];
            Abilities = [
                @"
Echolocation. The darkmantle can't use its blindsight
whi le deafened.",
                @"
False Appearance. While the darkmantle remains motionless, it
is indistinguishable from a cave formation such as a stalactite
or stalagmite."
                ];
        }
    }
}

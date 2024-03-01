﻿namespace Creatures.BestiaryC1
{
    internal class KuoToaWhip : Creatures
    {

        public KuoToaWhip()
        {
            Name = "Kuo-Toa Whip";
            Type = hu;
            Size = m;
            Alignment = ne;
            HitPoints = 65 + RollMultiple(8, 10) + 20;
            ArmorClass = 11;
            Speed = "30ft, swim 30ft";
            Attributes = [14, 10, 14, 12, 14, 11];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +6, Religion +4";
            Senses = "darkvision 120ft, passive Perception 16";
            Languages = "Undercommon";
            Actions = [
                @"
Multiattack. The kuo-toa makes two attacks: one with its bite
and one with its pincer staff.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 4 (ld4 + 2) piercing damage.",
                @"
Pincer Staff. Melee Weapon Attack: +4 to hit, reach 10ft.,
one target. Hit: 5 (1 6 + 2) piercing damage. If the target is
a Medium or smaller creature, it is grappled (escape DC 14).
Until this grapple ends, the kuo-toa can't use its pincer staff on
another target."
                ];
            Abilities = [
                @"
Amphibious. The kuo-toa can breathe air and water.",
                @"
Otherworldly Perception. The kuo-toa can sense the presence
of any creature within 30 feet of it that is invisible or on the
Ethereal Plane. It can pinpoint such a creature that is moving.",
                @"
Slippery. The kuo-toa has advantage on ability checks and
saving throws made to escape a grapple.",
                @"
Sunlight Sensitivity. While in sunlight, the kuo-toa has
disadvantage on attack rolls, as well as on Wisdom
(Perception) checks that rely on sight.",
                @"
Spellcasting. The kuo-toa is a 2nd-level spellcaster. Its
spellcasting abil ity is Wisdom (spell save DC 12, +4 to hit
with spell attacks). The kuo-toa has the following cleric
spells prepared:
Cantrips (at will): sacred flame, thaumaturgy
1st level (3 slots): bane, shield of faith"
                ];
        }
    }
}

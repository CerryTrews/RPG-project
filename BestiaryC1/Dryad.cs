﻿namespace Creatures.BestiaryC1
{
    internal class Dryad : Creature
    {

        public Dryad()
        {
            Name = "Dryad";
            Type = Types.Fey;
            Size = Sizes.Medium;
            Alignment = Alignments.Neutral;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 16;
            Speed = "30ft";
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +4, Stealth +5";
            Senses = "darkvision 60ft, passive Perception 14";
            Languages = "Elvish, Sylvan";
            Actions = [
                @"
Club. Melee Weapon Attack: +2 to hit (+6 to hit with shillelagh),
reach 5 ft., one target. Hit: 2 (1 4) bludgeoning damage, or 8
(1d8 + 4) bludgeoning damage with shillelagh.",
                @"
Fey Charm. The dryad targets one humanoid or beast that she
can see within 30 feet of her. If the target can see the dryad, it
must succeed on a DC 14 Wisdom saving throw or be magically
charmed. The charmed creature regards the dryad as a trusted
friend to be heeded and public. Although the target isn't
under the dryad's control, it takes the dryad's requests or
actions in the most favorable way it can .
Each time the dryad or its allies do anything harmful to the
target, it can repeat the saving throw, ending the effect on itself
on a success. Otherwise, the effect lasts 24 hours or until the
dryad dies, is on a different plane of existence from the target,
or ends the effect as a bonus action. If a target 's saving throw
is successful, the target is immune to the dryad's Fey Charm
for the next 24 hours.
The dryad can have no more than one humanoid and up to
three beasts charmed at a time."
                ];
            Abilities = [
                @"
Innate Spellcasting. The dryad's innate spellcasting ability is
Charisma (spell save DC 14). The dryad can innately cast the
following spells, requiring no material components:
At will: druidcraft
3fday each: entangle, goodberry
1fday each: barkskin, pass without trace, shillelagh",
                @"
Magic Resistance. The dryad has advantage on saving throws
against spells and other magical effects.",
                @"
Speak with Beasts and Plants. The dryad can communicate
with beasts and plants as if they shared a language.",
                @"
Tree Stride. Once on her turn, the dryad can use 10 feet of her
movement to step magically into one living tree within her
reach and emerge from a second living tree within 60 feet of
the first tree, appearing in an unoccupied space within 5 feet of '
the second tree. Both trees must be large or bigger."
                ];
        }
    }
}

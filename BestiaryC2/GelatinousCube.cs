﻿namespace Creatures.BestiaryC2
{
    internal class GelatinousCube : Creature   
    {
        public GelatinousCube()
        {
            Name = "Gelatinous Cube";
            Type = Types.Ooze;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 84 + RollMultiple(10, 8) + 40;
            ArmorClass = 6;
            Speed = "15";
            Attributes = [14, 3, 20, 1, 6, 1];
            ChallengeLevel = "2";
            Experience = 450;
            ConditionImmunities = "blinded, charmed, deafened, exhaustion, frightened, prone";
            Senses = "blindsight 60ft (blind beyoned this radius), passive Perception 8";
            Actions = [
                @"
Pseudopod. Melee Weapon Attack: +4 to hit, reach 5 ft., one
creature. Hit: 10 (3d6) acid damage.",
                @"
Engulf The cube moves up to its speed. Whi le doing so, it can
enter Large or smaller creatures' spaces. Whenever the cube
enters a creature's space, the creature must make a DC 12
Dexterity saving throw.
On a successful save, the creature can choose to be pushed 5
feet back or to the side of the cube. A creature that chooses not
to be pushed suffers the consequences of a failed saving throw.
On a failed save, the cube enters the creature's space, and
the creature takes 10 (3d6) acid damage and is engulfed. The
engulfed creature can't breathe, is restrained, and takes 21
(6d6) acid damage at the start of each of the cube's turns.
When the cube moves, the engulfed creature moves with it.
An engulfed creature can try to escape by taking an action
to make a DC 12 Strength check. On a success, the creature
escapes and enters a space of its choice within 5 feet
of the cube."
                ];
            Abilities = [
                @"
Ooze Cube. The cube takes up its entire space. Other creatures
can enter the space, but a creature that does so is subjected to
the cube's Engulf and has disadvantage on the saving throw.
Creatures inside the cube can be seen but have total cover.
A creature within 5 feet of the cube can take an action to
pull a creature or object out of the cube. Doing so requires a
successful DC 12 Strength check, and the creature making the
attempt takes 10 (3d6) acid damage.
The cube can hold only one Large creature or up to four
Medium or smaller creatures inside it at a time.
Transparent. Even when .the cube is in plain sight, it take.s a
successful DC 15 Wisdom (Perception) check to spot a ctibe
that has neither moved nor attacked. A creature tbat tries to
enter the cube's space while unaware of the cube is surprisel1l
by the cube."
                ];
        }
    }
}

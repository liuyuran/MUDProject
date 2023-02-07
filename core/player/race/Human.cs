using System;
using MUDProject.core.enums;

namespace MUDProject.core.player.race
{
    public class Human: IRace
    {
        public string GetPlayerName(Player from, Player to, Name name)
        {
            // TODO 如何称呼对方？
            switch (from.RelationshipManager.WithPlayer(to))
            {
                case Relationship.Stranger:
                    return $"{name.FamilyName}{name.PersonName}";
                default:
                    return $"{name.FamilyName}{name.SafeName}";
            }
        }

        public string GetRaceName(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "人类男性";
                case Gender.Female:
                    return "人类女性";
                case Gender.InterSex:
                case Gender.Asexual:
                default:
                    return "身形模糊的人类";
            }
        }

        public string GetDimension()
        {
            return "位";
        }
    }
}
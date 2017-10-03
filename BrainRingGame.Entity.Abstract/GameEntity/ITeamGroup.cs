using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface ITeamGroup : INumericEntity
    {
        List<IGroupTeam> TeamsInGroup { get; set; }
        List<ITeamAnsvers> TeamAnsvers { get; set; }
    }
}
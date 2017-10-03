using System;
using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class TeamGroup : NumericEntity, ITeamGroup
    {
        public List<IGroupTeam> TeamsInGroup { get; set; }
        public List<ITeamAnsvers> TeamAnsvers { get; set; }
    }
}
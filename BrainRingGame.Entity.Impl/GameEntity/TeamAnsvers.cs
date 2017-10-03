using System;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Abstract.GameEntity.Base;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class TeamAnsvers : NumericEntity, ITeamAnsvers
    {
        public INumericEntity TeamEntityId { get; set; }
        public INumericEntity QuestionEntityId { get; set; }
    }
}
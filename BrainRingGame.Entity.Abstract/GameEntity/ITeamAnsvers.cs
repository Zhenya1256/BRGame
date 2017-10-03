using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface ITeamAnsvers : INumericEntity
    {
        INumericEntity TeamEntityId { get; set; }
        INumericEntity QuestionEntityId { get; set; }
    }
}
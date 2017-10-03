using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IGroupTeam : ITeam, INumericEntity
    {
        int Place { get; set; }
        double Points { get; set; }
    }
}
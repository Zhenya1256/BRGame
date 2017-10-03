using System.Drawing;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface ITeam : INumericEntity
    {
        string Name { get; set; }
        Color TeamColor { get; set; }
        bool IsExisting { get; set; }
        TeamType TeamType { get; set; }
    }
}
using System;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class GroupTeam : Team, IGroupTeam  
    {
        public int Place { get; set; }
        public double Points { get; set; }
    }
}
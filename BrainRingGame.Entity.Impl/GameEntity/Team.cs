using System;
using System.Drawing;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class Team : NumericEntity, ITeam
    {
        public string Name { get; set; }
        public Color TeamColor { get; set; }
        public bool IsExisting { get; set; }
        public TeamType TeamType { get; set; }
    }
}
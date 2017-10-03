using System;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity.Base
{
    [Serializable]
    public class NumericEntity : INumericEntity
    {
        public int Id { get; set; }

        public void SetNumeric(int val)
        {
            Id = val;
        }
    }
}
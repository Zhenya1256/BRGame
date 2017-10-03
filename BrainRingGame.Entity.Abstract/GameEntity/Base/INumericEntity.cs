namespace BrainRingGame.Entity.Abstract.GameEntity.Base
{
    public interface INumericEntity
    {
        int Id { get; set; }
        void SetNumeric(int val);
    }
}
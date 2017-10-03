using System.IO;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface ISubStage : INumericEntity, IBaseEntityWithChild<IQuestionTopic>
    {
        ITeamGroup TeamInformation { get; set; }
        StageState StageState { get; set; }

        MemoryStream Image { get; set; }
        string ArchivePath { get; set; }
    }
}
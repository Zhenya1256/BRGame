using System.Collections.Generic;

namespace BrainRingGame.Entity.Abstract.Component
{

    public interface IStageComponent 
    {
        IFileData CurrentComponentFileData { get; set; }
        List<IStageComponent> SubComponents { get; set; }
        IStageComponent PrevStage { get; set; }
    }
}
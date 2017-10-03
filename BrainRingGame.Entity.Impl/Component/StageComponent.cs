using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.Component;

namespace BrainRingGame.Entity.Impl.Component
{

    public class StageComponent : IStageComponent 
    {
        public IFileData CurrentComponentFileData { get; set; }
        public List<IStageComponent> SubComponents { get; set; }
        public IStageComponent PrevStage { get; set; }
    }
}
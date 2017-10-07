using System.Collections.Generic;

namespace BrainRingGame.Entity.Abstract.Common.Config
{
    public class GameStageConfigSection
    {
        public int StageCount { get; set; }
        public List<StageItemConfig> StageItems { get; set; }
        //GameStageConfigSection
    }
}
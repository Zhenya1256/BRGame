using System.Collections.Generic;

namespace BrainRingGame.Entity.Abstract.Common.Config
{
    public class StageItemConfig
    {
        public int StageNumber { get; set; }
        public int SubStageCount { get; set; }
        public UploadConfiguration UploadConfiguration { get; set; }
        public List<SubStageItemConfig> SubStageItems { get; set; }
    }
}
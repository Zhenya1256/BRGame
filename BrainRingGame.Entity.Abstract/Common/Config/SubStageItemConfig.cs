using System.Collections.Generic;

namespace BrainRingGame.Entity.Abstract.Common.Config
{
    public class SubStageItemConfig
    {
        public int TopicsCount { get; set; }
        public int QuestionsCount { get; set; }
        public UploadConfiguration UploadConfiguration { get; set; }
        public UploadConfiguration UploadTopicConfiguration { get; set; }
        public DrawConfig DrawConfig { get; set; }
        public DrawConfig DrawTopicConfigItem { get; set; }
        public List<QuestionConfigItem> QuestionConfigItems { get; set; }
        public bool IsSingleQuestionType { get; set; }
        
    }
}
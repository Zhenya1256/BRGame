namespace BrainRingGame.Entity.Abstract.Common.Config
{
    public class QuestionConfigItem
    {
        public UploadConfiguration UploadConfiguration { get; set; }
        public int QuestionPointsType { get; set; }
        public int CurrentPointsTypeCount { get; set; }
        public DrawConfig DrawConfig { get; set; }
    }
}
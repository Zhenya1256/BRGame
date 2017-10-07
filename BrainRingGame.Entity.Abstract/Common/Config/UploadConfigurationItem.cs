namespace BrainRingGame.Entity.Abstract.Common.Config
{
    public class UploadConfigurationItem
    {
        public int UploadItemType { get; set; }
        //Detected the item shud be at archive
        public bool MustExist { get; set; }
    }
}
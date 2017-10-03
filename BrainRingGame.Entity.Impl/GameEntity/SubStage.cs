using System;
using System.IO;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class SubStage : BaseEntityWithChild<IQuestionTopic>, ISubStage
    {
        [NonSerialized]
        private MemoryStream _image;
        public ITeamGroup TeamInformation { get; set; }
        public StageState StageState { get; set; }
        public string ArchivePath { get; set; }
        public MemoryStream Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
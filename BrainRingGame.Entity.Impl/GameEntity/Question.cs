using System;
using System.IO;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class Question : NumericEntity, IQuestion
    {
        [NonSerialized]
        private MemoryStream _fileContent;
        public string Text { get; set; }
        public QuestionType QuestionType { get; set; }
        public QuestionState QuestionState { get; set; }
        public string FilePath { get; set; }
        public MemoryStream FileContent
        {
            get { return _fileContent; }
            set { _fileContent = value; }
        }
    }

}
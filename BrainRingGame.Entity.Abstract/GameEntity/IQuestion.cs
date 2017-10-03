using System;
using System.IO;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IQuestion : INumericEntity
    {
        string Text { get; set; }
        
        QuestionType QuestionType { get; set; }
        QuestionState QuestionState { get; set; }
        string FilePath { get; set; }
        MemoryStream FileContent { get; set; }
    }
    
}
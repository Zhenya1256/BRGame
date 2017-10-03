using System.IO;

namespace BrainRingGame.Entity.Abstract.Component
{
    public interface IFileData
    {
        MemoryStream CurrentComponent { get; set; }
        IDrawFileData DrowFileData { get; set; }
    }
}
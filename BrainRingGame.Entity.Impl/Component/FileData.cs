using System.IO;
using BrainRingGame.Entity.Abstract.Component;

namespace BrainRingGame.Entity.Impl.Component
{
    public class FileData : IFileData
    {
        public MemoryStream CurrentComponent { get; set; }
        public IDrawFileData DrowFileData { get; set; }
    }
}
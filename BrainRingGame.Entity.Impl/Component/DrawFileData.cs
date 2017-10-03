using System.Drawing;
using System.IO;
using BrainRingGame.Entity.Abstract.Component;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.Entity.Impl.Component
{
    public class DrawFileData : IDrawFileData
    {
        public string Text { get; set; }
        //posibly null look to the type
        public MemoryStream Image { get; set; }

        public Color TextColor { get; set; }
        public DrawFileComponentType DrawFileComponentType { get; set; }
    }
}
using System.Drawing;
using System.IO;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.Entity.Abstract.Component
{
    public interface IDrawFileData
    {
        string Text { get; set; }
        //posibly null look to the type
        MemoryStream Image { get; set; }

        Color TextColor { get; set; }
        DrawFileComponentType DrawFileComponentType { get; set; }
    }
}
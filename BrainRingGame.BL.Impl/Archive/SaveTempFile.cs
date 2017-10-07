using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Impl.Common.Results;
using SharpCompress.Reader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.BL.Impl.Archive
{
    public delegate void Mydelegate(string path);

    public class SaveTempFile
    {
        public IResult CreateDirectory(string name)
        {
            string tempPath = Path.GetTempPath();
            IResult result = new Result { Success = true };


            string pathArchiv = tempPath + name;

            using (Stream stream = File.OpenRead(GameEntityHolder.PathToArchive))
            {
                IReader reader = ReaderFactory.Open(stream);

                while (reader.MoveToNextEntry())
                {
                    if (reader.Entry.IsDirectory)
                    {
                        Directory.CreateDirectory(pathArchiv + reader.Entry.FilePath);
                    }

                }
            }

            using (Stream stream = File.OpenRead(GameEntityHolder.PathToArchive))
            {
                IReader reader = ReaderFactory.Open(stream);

                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        Mydelegate del= CreateFile;
                        IAsyncResult asyncResult;
                        string path = pathArchiv + reader.Entry.FilePath;
                        asyncResult = del.BeginInvoke(path, null, null);
                        del.EndInvoke(asyncResult);

                    }
                }
            }

            using (Stream stream = File.OpenRead(GameEntityHolder.PathToArchive))
            {
                IReader reader = ReaderFactory.Open(stream);

                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        string path = pathArchiv + reader.Entry.FilePath;
                      //  MemoryStream streamFile = new MemoryStream();
                        reader.WriteEntryTo(path);

                      

                    }
                }
            }

            return result;
        }

        private void CreateFile(string path)
        {
            File.Create(path);
        }

    }
}

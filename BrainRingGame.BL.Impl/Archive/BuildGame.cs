using BrainRingGame.Entity.Abstract.Common.Config;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.Common.Results;
using BrainRingGame.Entity.Impl.GameEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.BL.Impl.Archive
{
    public class BuildGame
    {
        private GameStageConfigSection configSection;

        public BuildGame(GameStageConfigSection configSection)
        {
            this.configSection = configSection;
        }

        public void Build(string pathArchiv)
        {
            SubStageFile(pathArchiv);
            QuestionTopicFile(pathArchiv);
            QuestionFile(pathArchiv);
        }

        public IResult SubStageFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
              (pathArchiv).ToList();
            IDataResult<MemoryStream> result =
                new DataResult<MemoryStream>() { Success = false };
            List<IStage> listStages = new List<IStage>();

            foreach (var stage in configSection.StageItems)
            {
                IStage currentStage = new Stage();

                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                currentStage.Name = stage.StageNumber.ToString();
                currentStage.StageNumber = stage.StageNumber;

                int i = 0;
                List<ISubStage> listSubStages = new List<ISubStage>();

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetFiles
                        (substatages[i]).ToList();
                    }

                    string pathImage = topicThems[0];

                    ISubStage sub = new SubStage();
                    sub.ArchivePath = pathArchiv;
                    sub.Image = SaveImageFile(pathImage);
                    listSubStages.Add(sub);
                    i++;
                }

                currentStage.ChildItemss = listSubStages;
                listStages.Add(currentStage);
            }
            Game game = new Game();
            game.ChildItemss = listStages;
            GameEntityHolder.Game = game;
            GameEntityHolder.PathToArchive = pathArchiv;
            // GameEntityHolder.Game.ChildItemss[0].ChildItemss[0].ChildItemss[0].
            return result;
        }

        public IResult QuestionTopicFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
            (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            int nomerStage = 0;

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;
                int nomerSubStsages = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

                    List<IQuestionTopic> listQuestionTopic =
                     new List<IQuestionTopic>();

                    for (int k = 0; k < subStage.TopicsCount; k++)
                    {
                        List<string> questions = new List<string>();

                        if (topicThems.Count - 1 >= k)
                        {
                            questions = Directory.GetDirectories
                            (topicThems[k]).ToList();
                        }
                 

                        foreach (var s in questions)
                        {
                            List<string> topicQuestion =
                                Directory.GetFiles(s).ToList();
                            IQuestionTopic questionTopic = new QuestionTopic();
                            
                            foreach (var format in topicQuestion)
                            {
                                if (format.Contains(".txt"))
                                {
                                    questionTopic.Text = SaveTextFile(format);
                                }
                                else
                                {
                                    questionTopic.Image = SaveImageFile(format);
                                }

                            }

                            listQuestionTopic.Add(questionTopic);
                        }
                    

                    }
                    GameEntityHolder.Game.ChildItemss[nomerStage].
                        ChildItemss[nomerSubStsages].ChildItemss = listQuestionTopic;

                    i++;
                    nomerSubStsages++;
                }

                nomerStage++;
            }

            return result;
        }

        public IResult QuestionFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
           (pathArchiv).ToList();
            Result result = new Result() { Success = true };
            int nomerStage = 0;

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;
                int nomerSubStage = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }
                    int nomerTopic = 0;
                    for (int k = 0; k < subStage.TopicsCount; k++)
                    {
                        List<string> questions = new List<string>();
                        List<string> sf = topicThems;

                        if (topicThems.Count - 1 >= k)
                        {
                            questions = Directory.GetDirectories
                            (topicThems[k]).ToList();
                        } 

                        foreach (var s in questions)
                        {
                            List<IQuestion> listQuestion = new List<IQuestion>();
                            List<string> topicQuestion =
                                Directory.GetDirectories(s).ToList();

                            List<string> files = 
                                Directory.GetFiles(topicQuestion[0]).ToList();
                            IQuestion question = new Question();

                            foreach(var ques in files)
                            {
                                if (ques.Contains(".txt"))
                                {
                                    question.Text = SaveTextFile(ques);
                                }
                                else
                                {
                                    question.FileContent = SaveImageFile(ques);                            
                                    question.FilePath = ques;
                                }                       
                            }                           

                            listQuestion.Add(question);

                            GameEntityHolder.Game.ChildItemss[nomerStage].
                ChildItemss[nomerSubStage].ChildItemss[nomerTopic].ChildItemss = listQuestion;
                            nomerTopic++;
                        }
                    }

                    i++;
                    nomerSubStage++;
                }

                nomerStage++;
            }

            return result;
        }

        private MemoryStream SaveImageFile(string path)
        {
            MemoryStream streamImage = new MemoryStream();


            using (System.IO.FileStream fs =
            new System.IO.FileStream(path, FileMode.Open))
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fs))
                {

                    while (!sr.EndOfStream)
                    {
                        Int32 b = sr.Read();
                        streamImage.WriteByte((Byte)b);
                    }
                }
            }
                

                return streamImage;
        }

        private string SaveTextFile(string path)
        {
            string content = null;

            using (StreamReader sr = new StreamReader(path))
            {
                 content = sr.ReadToEnd();

            }

            return content;
        }
    }
}

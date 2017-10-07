using BrainRingGame.Entity.Abstract.Common.Config;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Impl.Common.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.BL.Impl.Archive
{
    public class ValidataArchive
    {
        private GameStageConfigSection configSection;

        public ValidataArchive(GameStageConfigSection configSection)
        {
            this.configSection = configSection;
        }

        #region ValidateDirectory

        public IResult Stage(string pathArchiv)
        {
            List<string> list = Directory.GetDirectories(pathArchiv).ToList();

            if (list.Count == configSection.StageCount)
            {
                return new Result
                {
                    Success = true
                };
            }

            return new Result
            {
                Success = false,
                Message = "Немає стейджів"

            };
        }

        public IResult SubStage(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
                (pathArchiv).ToList();

            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                         (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                if (substatages.Count != stage.SubStageCount)
                {
                    //MessageHolder
                    result.Message += stage.StageNumber.ToString();
                    result.Success = false;
                }


            }

            return result;
        }

        public IResult SubStageItemTopics(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
                 (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

                    if (topicThems.Count != subStage.TopicsCount)
                    {
                        //MessageHolder
                        result.Message += "substage";
                        result.Success = false;
                    }

                    i++;
                }
            }

            return result;
        }

        public IResult SubStageItemQuestion(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
                (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }
                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();
                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

                    for (int k = 0; k < subStage.TopicsCount; k++)
                    {
                        List<string> questions = new List<string>();

                        if (topicThems.Count - 1 >= k)
                        {
                            questions = Directory.GetDirectories
                            (topicThems[k]).ToList();
                        }
                        //в кожній темі
                        if (questions.Count != subStage.TopicsCount)
                        {
                            //MessageHolder
                            result.Message += "substage";
                            result.Success = false;
                        }
                    }

                    i++;
                }
            }

            return result;
        }

        public IResult Question(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
               (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

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
                                Directory.GetDirectories(s).ToList();

                            if (topicQuestion.Count == 0)
                            {
                                result.Success = false;
                                result.Message = "question";
                            }
                        }

                    }
                    i++;
                }
            }

            return result;

        }

        public List<IResult> ValidateDirectory(string pathArchiv)
        {
            List<IResult> listResult = new List<IResult>();
            IResult result = Stage(pathArchiv);
            listResult.Add(result);
            result = SubStage(pathArchiv);
            listResult.Add(result);
            result = SubStageItemTopics(pathArchiv);
            listResult.Add(result);
            result = SubStageItemQuestion(pathArchiv);
            listResult.Add(result);
            result = Question(pathArchiv);
            listResult.Add(result);

            return listResult;
        }

        #endregion

        #region ValidteFile

        public IResult SubStageFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
              (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetFiles
                        (substatages[i]).ToList();
                    }

                    if (topicThems.Count != 1)
                    {
                        //MessageHolder
                        result.Message += stage.StageNumber + " Sub " + (i + 1) + "  // ";
                        result.Success = false;

                        return result;
                    }
                    if (!ValidateImage(topicThems[0]))
                    {
                        //MessageHolder
                        result.Message = stage.StageNumber + " Sub " + (i + 1) + "Картинка";
                        result.Success = false;

                        return result;
                    }

                    i++;
                }
            }

            return result;
        }

        public IResult SubStageItemQuestionFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
              (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }
                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();
                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

                    for (int k = 0; k < subStage.TopicsCount; k++)
                    {
                        List<string> questions = new List<string>();

                        if (topicThems.Count - 1 >= k)
                        {
                            questions = Directory.GetFiles
                            (topicThems[k]).ToList();
                        }
                        //в кожній темі
                        if (questions.Count != 1)
                        {
                            //MessageHolder
                            result.Message += "substage";
                            result.Success = false;
                        }
                    }

                    i++;
                }
            }

            return result;
        }

        public IResult QuestionTopicFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
            (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

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

                            result = ValideTxtorImage(topicQuestion);

                            if (!result.Success)
                            {
                                return result;
                            }
                        }

                    }
                    i++;
                }
            }

            return result;
        }

        public IResult QuestionFile(string pathArchiv)
        {
            List<string> stagesArchiv = Directory.GetDirectories
           (pathArchiv).ToList();
            Result result = new Result() { Success = true };

            foreach (var stage in configSection.StageItems)
            {
                List<string> substatages = new List<string>();

                if (stagesArchiv.Count >= stage.StageNumber)
                {
                    substatages = Directory.GetDirectories
                   (stagesArchiv[stage.StageNumber - 1]).ToList();
                }

                int i = 0;

                foreach (var subStage in stage.SubStageItems)
                {
                    List<string> topicThems = new List<string>();

                    if (substatages.Count - 1 >= i)
                    {
                        topicThems = Directory.GetDirectories
                        (substatages[i]).ToList();
                    }

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
                                Directory.GetDirectories(s).ToList();

                            List<string> files = Directory.GetFiles(topicQuestion[0]).ToList();

                            result = ValidateImageMp3Txt(files);

                            if (!result.Success)
                            {
                                result.Message += "  " + stage.StageNumber + "  sub  " + (i + 1) + "top" + (k + 1);
                                return result;
                            }
                        }

                    }

                    i++;
                }
            }

            return result;
        }

        public List<IResult> ValidateFiles(string pathArchiv)
        {
            List<IResult> listResult = new List<IResult>();
            IResult result = SubStageFile(pathArchiv);
            listResult.Add(result);
            result = QuestionTopicFile(pathArchiv);
            listResult.Add(result);
            result = QuestionFile(pathArchiv);
            listResult.Add(result);

            return listResult;
        }

        #endregion

        #region ValidateHelp

        private bool ValidateImage(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }

        private Result ValideTxtorImage(List<string> topicQuestion)
        {
            Result result = new Result() { Success = true };

            if (topicQuestion.Count != 0 && topicQuestion.Count < 3)
            {
                result.Success = false;
                result.Message = "question";

                return result;
            }
            foreach (var format in topicQuestion)
            {
                if (!format.Contains(".txt"))
                {
                    if (!ValidateImage(format))
                    {
                        result.Success = false;
                        result.Message = "image";

                        return result;
                    }
                }
            }
            int txt = 0;
            foreach (var format in topicQuestion)
            {
                if (format.Contains(".txt"))
                {
                    txt++;
                }
            }

            if (txt == 2)
            {
                result.Success = false;
                result.Message = "image";

                return result;
            }

            return result;

        }
     
        private Result ValidateImageMp3Txt(List<string> topicQuestion)
        {
            Result result = new Result() { Success = true };

            if (topicQuestion.Count == 0)
            {
                result.Success = false;
                result.Message = "EmtyFileContent1";

                return result;
            }
            bool isTxt = false;
            bool isImage = false;
            bool isMp3 = false;

            foreach (var s in topicQuestion)
            {
                if (s.Contains(".txt"))
                {
                    isTxt = true;
                }
                else if (s.Contains(".mp3"))
                {
                    isMp3 = true;
                }
                else
                {
                    isImage = true;
                }
            }

            if(!isTxt && isImage)
            {
                result.Success = false;
                result.Message = "AddText";

                return result;
            }
            

            return result;
        }

        #endregion

    }
}

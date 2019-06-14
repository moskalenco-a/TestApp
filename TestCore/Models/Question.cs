using System;
using System.Xml.Serialization;

namespace TestCore
{
    [Serializable]
    [XmlInclude(typeof(OneAnswerQuestion))]
    [XmlInclude(typeof(MultipleAnswerQuestion))]
    [XmlInclude(typeof(CustomAnswerQuestion))]
    public class Question
    {
        public string Text { get; set; }

        public virtual bool CheckAnswer(object ans)
        {
            return false;
        }
    }
}
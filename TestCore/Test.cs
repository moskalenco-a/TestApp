using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace TestCore
{
    public class Test
    {
        private List<Question> questions;
        private List<bool> correctAnswers;
        private int current = 0;

        public void LoadFromFile(string path)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                questions = (List<Question>)serializer.Deserialize(stream);
            }
            correctAnswers = Enumerable.Repeat(false, questions.Count).ToList();
        }

        public Question CurrentQuestion
        {
            get
            {
                return questions[current];
            }
        }

        public int CurrentQuestionIndex
        {
            get
            {
                return current + 1;
            }
        }

        public void Prev()
        {
            if (current != 0)
                --current;
        }

        public void Next()
        {
            if (current != questions.Count - 1)
                current++;
        }
    }
}
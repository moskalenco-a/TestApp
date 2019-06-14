using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TestCore
{
    public class QuestionCollection
    {
        private List<Question> questions = new List<Question>();

        public void Add(Question question)
        {
            questions.Add(question);
        }

        public void RemoveAt(int index)
        {
            questions.RemoveAt(index);
        }

        public int Count
        {
            get { return questions.Count; }
        }

        public Question this[int index]
        {
            get
            {
                return questions[index];
            }
            set
            {
                questions[index] = value;
            }
        }

        public void LoadFromFile(string path)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                questions = (List<Question>)serializer.Deserialize(stream);
            }
        }

        public void SaveToFile(string path)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = File.Open(path, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, questions);
            }
        }
    }
}
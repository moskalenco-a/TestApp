using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestCore;

namespace PlayTest
{
    public class Test
    {
        private QuestionCollection collection;
        private List<bool> correct;
        private int current;


        public Test(QuestionCollection collection)
        {
            this.collection = collection;
            correct = Enumerable.Repeat(false, collection.Count).ToList();
            current = 0;
        }

        public Test(string path)
        {
            collection = new QuestionCollection();
            collection.LoadFromFile(path);
            correct = Enumerable.Repeat(false, collection.Count).ToList();
            current = 0;
        }

        public Question Current
        {
            get
            {
                return collection[current];
            }
        }

        public void Next()
        {
            if (current != collection.Count - 1)
                current++;
        }

        public void Prev()
        {
            if (current != 0)
                current--;
        }

        public bool IsLast
        {
            get
            {
                return current == collection.Count - 1;
            }
        }

        public void CheckCurrentQuestion(object userAnswer)
        {
            correct[current] = Current.CheckAnswer(userAnswer);
        }

        public int QuestionCount()
        {
            return collection.Count;
        }

        public int GetCorrectCount()
        {
            //var debug = correct.Select(x => x ? 1 : 0).ToList();
            //MessageBox.Show(string.Join("", debug));
            return correct.Where(x => !!x).Count();
        }

        public int GetCurrentIndex
        {
            get => current;
        }
    }
}
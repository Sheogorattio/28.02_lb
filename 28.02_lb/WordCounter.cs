using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02_lb
{
    public class WordCounter
    {
        string[] text;
        SortedList<string, int> wordCounter;
        public WordCounter(string text)
        {
            this.text = text.Split();
        }
        public void Count()
        {
            foreach (string word in text) {
                for(int i = 0; i < wordCounter.Count; i++)
                {
                    if (wordCounter.ContainsKey(word))
                    {
                        wordCounter[word]++;
                    }
                    else
                    {
                        wordCounter.Add(word, 1);
                    }
                }
            }
        }
        public void Result()
        {
            foreach(var i  in wordCounter)
            {
                Console.WriteLine(i.Key + "\t"+ i.Value);
            }
        }
    }
}

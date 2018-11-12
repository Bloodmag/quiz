using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quiz
{
    public class Dictionary
    {
        public Dictionary()
        {
            words = new List<Word>();
        }
        public Dictionary(string s)
        {
            name = s;
            words = new List<Word>();
        }

        public string name;
        public List<Word> words;


        public bool ReadFromFile(string filename)//read file conents
        {
            Word w;
            string[] lines;
            try
            {
                lines = System.IO.File.ReadAllLines(filename);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            foreach(string str in lines)
            {
                if (str.Contains("-"))//simple dumb check
                {
                    w.en = str.Substring(0, str.IndexOf('-') - 1);
                    w.en.Trim();
                    w.ru = str.Substring(str.IndexOf('-') + 1);
                    w.ru.Trim();
                    words.Add(w);
                }
            }
            return true;
        }
    }
}

using MultiDictionarySystem.Data;
using MultiDictionarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionaryEnglishDbContext data = new MultiDictionaryEnglishDbContext();

            Word word = new Word();
            word.Word = "Hesadasdello";
            word.Translations = new HashSet<Translation>();
            data.EnglishWords.Add(word);
            data.SaveChanges();

            foreach (var item in data.EnglishWords)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(data.EnglishWords.Count());
        }
    }
}

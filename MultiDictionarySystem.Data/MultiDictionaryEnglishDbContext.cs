
namespace MultiDictionarySystem.Data
{
    using MultiDictionarySystem.Models;
    using System;
    using System.Data.Entity;

    public class MultiDictionaryEnglishDbContext : DbContext
    {
        public IDbSet<Word> EnglishWords { get; set; }
    }
}

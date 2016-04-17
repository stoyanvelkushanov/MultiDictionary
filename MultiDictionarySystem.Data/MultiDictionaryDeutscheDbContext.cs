using MultiDictionarySystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDictionarySystem.Data
{
    public class MultiDictionaryDeutscheDbContext : DbContext
    {
        public IDbSet<Word> DeutscheWords { get; set; }
    }
}

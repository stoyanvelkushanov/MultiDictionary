
namespace MultiDictionarySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Translation
    {
        public Translation()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Translated { get; set; }
    }
}

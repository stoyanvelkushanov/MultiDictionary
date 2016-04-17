
namespace MultiDictionarySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Word
    {
        public Word()
        {
            this.Id = Guid.NewGuid();
            this.Translations = new HashSet<Translation>();
        }

        public Guid Id { get; set; }

        public string Original { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Translation tr in Translations)
            {
                sb.Append(tr.Translated + ",");
            }

            if (sb.Length > 1)
            {
                sb.Length--;
            }

            return sb.ToString();
        }
    }
}

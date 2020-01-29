using System.Collections.Generic;

namespace HaikuCatalog
{
    public class Haiku
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public List<string> Lines { get; set; }
    }
}
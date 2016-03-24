using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSystem.Src.RatingData
{
    public class Comment
    {
        public string Author { get; private set; }
        public string Text { get; private set; }

        public Comment()
        {
            this.Author = "";
            this.Text = "";
        }

        public Comment(string author, string text)
        {
            this.Author = author;
            this.Text = text;
        }
    }
}

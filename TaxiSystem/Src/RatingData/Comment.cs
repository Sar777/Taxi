namespace TaxiSystem.RatingData
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

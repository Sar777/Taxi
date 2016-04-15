using System.Collections.Generic;
using System.Linq;

namespace TaxiSystem.RatingData
{
    public class Rating
    {
        private readonly List<float> _rating;
        public Stack<Comment> Comments { get; private set; }

        public Rating()
        {
            this._rating = new List<float>();
            this.Comments = new Stack<Comment>();
        }

        public float GetRating()
        {
            if (_rating.Count == 0)
                return 0.0f;

            return _rating.Sum() / _rating.Count;
        }

        public void AddRating(float rating)
        {
            _rating.Add(rating);
        }

        public Comment GetLastComment()
        {
            return Comments.Last();
        }

        public void AddComment(Comment comment)
        {
            Comments.Push(comment);
        }
    }
}

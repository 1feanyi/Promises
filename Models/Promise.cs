using System;

namespace Promises.Models
{
    public class Promise
    {
        public int PromiseId { get; set; }
        public DateTime PromiseDate { get; set; }
        public Profile PromiseBy { get; set; }
        public Profile PromiseTo { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }
        public bool IsFulfilled { get; set; }
        public DateTime FulfilledDate { get; set; }
        public Rating FeedbackRating { get; set; }
        public bool IsLocked { get; set; }
        public string FinalNotes { get; set; }
    }

    public enum Rating
    {
        Terrible,
        Bad,
        Fair,
        Good,
        Excellent
    }
}
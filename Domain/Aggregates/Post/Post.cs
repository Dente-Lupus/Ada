using System;
using System.Linq;
using Domain.SeedWork;

namespace Domain.Aggregates.Post
{
    public class Post : Entity<long>, IAggregateRoot
    {
        public string Title { get; private set; }
        public string Summary { get; private set; }
        public string Slug { get; private set; }
        public string Content { get; private set; }
        public DateTime? PublishedDate { get; private set; }
        public DateTime? LastUpdateDate { get; private set; }
        public PostStatus Status { get; private set; }
        public Uri Header { get; private set; }

        public Post(string title, string summary, string slug, string content)
        {
            if(string.IsNullOrEmpty(title))
                throw new InvalidTitleException("Empty title is not valid", nameof(title));

            Title = title;
            Summary = string.IsNullOrEmpty(summary) ? content.Take(30).ToString() : summary;
            Slug = slug;
            Content = content;
            PublishedDate =  null;
            LastUpdateDate =  null;
            Status = PostStatus.Draft;
        }
    }
}
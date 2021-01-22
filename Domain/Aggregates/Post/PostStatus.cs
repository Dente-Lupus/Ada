using Domain.SeedWork;

namespace Domain.Aggregates.Post
{
    public class PostStatus : Enumeration
    {
        public static PostStatus Draft => new PostStatus("Draft", 0);
        public static PostStatus Published => new PostStatus("Published", 1);

        private PostStatus(string name, int id) : base(id, name) {}
    }
}
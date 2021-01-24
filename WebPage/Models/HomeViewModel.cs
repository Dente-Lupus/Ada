using System;
using System.Collections.Generic;

namespace Ada.Webpage.Models
{
    public class HomeViewModel
    {
        public List<BannerItem> Banner { get; set; }
        public List<PostSummary> Posts { get; set; }
    }

    public class BannerItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Uri Image { get; set; }
    }

    public class PostSummary
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Uri Header { get; set; }
        public Uri PostUri { get; set; }
    }
}
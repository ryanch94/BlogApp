using System;
using System.Collections.Generic;

namespace _14Oct2015.Models
{
    public class Blog
    {
        public string BlogTitle { get; set; }
        public List<Post> Posts { get; set; }
        public string BlogAuthor { get; set; }

    }

    public class Post
    {
        public DateTime PostDate { get; set; }
        public string PostContent { get; set; }
        public string PostTitle { get; set; }
    }
}
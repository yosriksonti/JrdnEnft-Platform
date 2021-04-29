using System;
namespace test_request.Models.daycare
{
    public class Post
    {
        public Post()
        {
        }

        public string body { get; set; }
        public string title { get; set; }
        public string media { get; set; }
        public Daycare daycare { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }

    }
}

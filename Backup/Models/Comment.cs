using System;

namespace ITSecuritySymposium.Models
{
    public class Comment : DomainObject
    {
        public Comment()
        {
            Created = DateTime.Now;
        }

        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }

        public Post Post { get; set; }
    }
}
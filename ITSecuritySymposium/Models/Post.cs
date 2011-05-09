using System;
using System.Collections.Generic;

namespace ITSecuritySymposium.Models
{
    public class Post : DomainObject
    {
        public Post()
        {
            Comments = new List<Comment>();
        }

        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
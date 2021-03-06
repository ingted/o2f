using System.Collections.Generic;

namespace Dos.Domain
{
    public class Post
    {
        public string Id { get; set; }

        public string WebLogId { get; set; }

        public string AuthorId { get; set; }

        public string Status { get; set; }

        public string Title { get; set; }

        public string Permalink { get; set; }

        public long PostedOn { get; set; }

        public long UpdatedOn { get; set; }

        public IArticleContent Text { get; set; }

        public ICollection<string> CategoryIds { get; set; } = new List<string>();

        public ICollection<string> Tags { get; set; } = new List<string>();

        public ICollection<Revision> Revisions { get; set; } = new List<Revision>();
    }
}
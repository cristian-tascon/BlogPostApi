using System;
using System.Collections.Generic;

namespace BlogPostApi.Models;

public partial class BlogPost
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public virtual ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
}

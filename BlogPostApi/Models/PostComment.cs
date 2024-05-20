using System;
using System.Collections.Generic;

namespace BlogPostApi.Models;

public partial class PostComment
{
    public Guid Id { get; set; }

    public Guid BlogPostId { get; set; }

    public string UserFullName { get; set; } = null!;

    public string? Comment { get; set; }

    public virtual BlogPost BlogPost { get; set; } = null!;
}

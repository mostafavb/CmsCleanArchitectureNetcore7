﻿using System.Security.Principal;

namespace Cms.Core.Domains;
internal class PostTag : BaseClass
{
    public int PostId { get; set; }
    public int TagId { get; set; }
    public Post Post{ get; set; }
    public Tag Tag{ get; set; }
}

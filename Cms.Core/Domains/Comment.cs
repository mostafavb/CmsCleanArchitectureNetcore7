namespace Cms.Core.Domains;
public class Comment:BaseClass
{
    public string Content { get; set; }
    public int PostId { get; set; }
}

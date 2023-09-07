public class Tag
{
    public int Id {get;set;}
    public string Name {get;set;}
    public ICollection<JobTag> JobTags {get;set;}
}
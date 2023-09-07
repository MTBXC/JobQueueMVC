public class Job
{
    public int Id {get;set;}
    public string Name {get;set;}
    public int TypeId {get;set;}
    public virtual Type Type {get;set;}

    public ICollection<JobTag> JobTags {get;set;}

}
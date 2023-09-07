public class Type
{
    public int Id {get;set;}
    public string Name {get;set;}
    public virtual ICollection<Job> Jobs {get;set;}

}
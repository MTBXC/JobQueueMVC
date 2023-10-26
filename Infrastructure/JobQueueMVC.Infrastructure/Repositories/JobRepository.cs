using JobQueueMVC.Infrastracture;

namespace JobQueueMVC.Infrastracture.Repositories
{
public class JobRepository : IJobRepository
{
    private readonly Context _context;
    public JobRepository(Context context)
    {
        _context = context;
    }

    public void DeleteJob(int jobId)
    {
        var job = _context.Jobs.Find(jobId);
        if(job != null)
        {
            _context.Jobs.Remove(job);
            _context.SaveChanges();
        }
    }

    public int AddJob(Job job)
    {
        _context.Jobs.Add(job);
        _context.SaveChanges();
        return job.Id;
    }

    public IQueryable<Job> GetJobsByTypeId(int typeId)
    {
        var jobs = _context.Jobs.Where(i=>i.TypeId==typeId);
        return jobs;
    }

    public Job GetJobById(int jobId)
    {
        var job = _context.Jobs.FirstOrDefault(i=>i.Id == jobId);
        return job;

    }

    public IQueryable<Tag> GetAllTags()
    {
        var tags = _context.Tags;
        return tags;
    }

    public IQueryable<Type> GetAllTypes()
    {
        var types = _context.Types;
        return types;
    }

    
}
}
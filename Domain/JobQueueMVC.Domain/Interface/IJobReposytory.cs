public interface IJobRepository
{
void Delete(int jobId);
int AddJob(Job job);
IQueryable<Job> GetJobsByTypeId(int typeId);
IQueryable<Tag> GetAllTags();
IQueryable<Type> GetAllTypes();

}
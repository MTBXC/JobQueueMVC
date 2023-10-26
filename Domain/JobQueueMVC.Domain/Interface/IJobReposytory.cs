public interface IJobRepository
{
void DeleteJob(int jobId);
int AddJob(Job job);
IQueryable<Job> GetJobsByTypeId(int typeId);
IQueryable<Tag> GetAllTags();
IQueryable<Type> GetAllTypes();

}
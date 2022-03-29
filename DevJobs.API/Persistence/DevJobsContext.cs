using DevJobs.API.Entities;

namespace DevJobs.API.Persistence
{
    public class DevJobsContext
    {
        public DevJobsContext()
        {
                jobVacancies = new List<JobVacancy>(); 
        }
        public List <JobVacancy> jobVacancies {get; set;}
    }
}
namespace DevJobs.API.Controllers
{
    using DevJobs.API.Entities;
    using DevJobs.API.Models;
    using DevJobs.API.Persistence;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies/{id}/applications")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly DevJobsContext _context;
        public JobApplicationsController(DevJobsContext context)
        {
            _context = context;
        }

        //post api/job-vacancies/4/applications
        [HttpPost]
        public IActionResult Post(int id, AddJobApplicationInputModel model)
        {
            var JobVacancy = _context.jobVacancies.SingleOrDefault(jv =>jv.Id == id);
                if (JobVacancy == null){

                        return NotFound();
                }
                    
                var application = new JobApplication(
                    model.applicationName,
                    model.applicationEmail,
                    id

                );
                JobVacancy.Applications.Add(application);
                return NoContent();
        }
    }
}
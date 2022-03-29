namespace DevJobs.API.Controllers
{
    using DevJobs.API.Entities;
    using DevJobs.API.Models;
    using DevJobs.API.Persistence;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[[job-Vacancies]]")]
    [ApiController]
    public class JobVacanciesController : ControllerBase
    {
        private readonly DevJobsContext _context;
        public JobVacanciesController(DevJobsContext context)
        {
           _context = context; 
        }
        //GET api/job-vacancies/4
        [HttpGet]
        public  IActionResult GetAll()
        {
            var jobVacancies = _context.jobVacancies;
            
            return Ok(jobVacancies);
        }
        //POST api/job-vacancies
        [HttpGet("{id}")] 
        public IActionResult GetById(int id){
            var JobVacancy = _context.jobVacancies.SingleOrDefault(jv => jv.Id == id);
                
                if (JobVacancy == null)
                {
                    return NotFound();
                }
                    
                    return Ok(JobVacancy);
        }
        //POST API/JOB-VACANcIES
       [HttpPost]
       public IActionResult Post ( AddJobVacancyInputModel model){
           var JobVacancy = new JobVacancy(

               model.Title,
               model.Description,
               model.Company, 
               model.IsRemote,
               model.SalaryRange
           );
           _context.jobVacancies.Add(JobVacancy);
           return CreatedAtAction("GetById", new {id = JobVacancy.Id},JobVacancy);
           
       }
        
       //PUT api/job-vacancies/4  
        [HttpPut("{id}")]
        public IActionResult put(int id, UpdateJobVacancyInputModel model){

            var JobVacancy = _context.jobVacancies.SingleOrDefault(jv =>jv.Id == id);
                if (JobVacancy == null)
                    return NotFound();


            JobVacancy.Update(model.Title, model.description);
            return NoContent();
        }
    }
    
}
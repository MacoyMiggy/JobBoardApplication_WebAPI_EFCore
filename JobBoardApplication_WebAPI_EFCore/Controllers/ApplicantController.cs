using JobBoardApplication_WebAPI_EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApplication_WebAPI_EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantController : ControllerBase
    {
        //private readonly JobBoardAppWebApiContext _context;

        //public ApplicantController(JobBoardAppWebApiContext context)
        //{
        //    _context = context;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        //{
        //    return await _context.Applicants.ToListAsync();
        //}



        [HttpGet]
        public IEnumerable<Applicant> Get()
        {
            using (var context = new JobBoardAppWebApiContext())
            {
                // get all applicants
                return context.Applicants.ToList();

                // add applicant
                //Applicant applicant = new Applicant();
                //applicant.ApplicantId = 1;
                //applicant.FirstName = "Juan";
                //applicant.LastName = "Cruz";
                //applicant.EmailAddress = "juancruz@gmail.com";
                //applicant.JobPosition = "Engineer";
                //context.Applicants.Add(applicant);

                //update applicant
                //Applicant applicant = context.Applicants.Where(a => a.FirstName == "Juan").FirstOrDefault();
                //applicant.JobPosition = "Developer";

                //remove applicant
                //Applicant applicant = context.Applicants.Where(a => a.FirstName == "Juan").FirstOrDefault();
                //context.Applicants.Remove(applicant);

                //context.SaveChanges();

                // get app by id
                //return context.Applicants.Where(app => app.FirstName == "Juan").ToList();
                
            }

        }
    }
}
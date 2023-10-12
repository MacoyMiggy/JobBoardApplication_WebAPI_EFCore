using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobBoardApplication_WebAPI_EFCore.Models;

namespace JobBoardApplication_WebAPI_EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly JobBoardAppWebApiContext _context;

        public ApplicantsController(JobBoardAppWebApiContext context)
        {
            _context = context;
        }

        // GET: api/Applicants1
        [HttpGet("GetApplicants")]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        {
          if (_context.Applicants == null)
          {
              return NotFound();
          }
            return await _context.Applicants.ToListAsync();
        }

        // GET: api/Applicants1/5
        [HttpGet("GetApplicant/{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int id)
        {
          if (_context.Applicants == null)
          {
              return NotFound();
          }
            var applicant = await _context.Applicants.FindAsync(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }

        // PUT: api/Applicants1/5
        [HttpPut("UpdateApplicant/{id}")]
        public async Task<IActionResult> PutApplicant(int id, Applicant applicant)
        {
            if (id != applicant.ApplicantId)
            {
                return BadRequest();
            }

            _context.Entry(applicant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Applicants1
        [HttpPost("CreateApplicant")]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant applicant)
        {
            if (_context.Applicants == null)
            {
                return Problem("Entity set 'JobBoardAppWebApiContext.Applicants' is null.");
            }
            _context.Applicants.Add(applicant);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ApplicantExists(applicant.ApplicantId) && ApplicantWorkExists(applicant.JobPosition))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }

            }

            return CreatedAtAction("GetApplicant", new { id = applicant.ApplicantId, jobPosition = applicant.JobPosition }, applicant) ;
        }

        // DELETE: api/Applicants1/5
        [HttpDelete("DeleteApplicant/{id}")]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            if (_context.Applicants == null)
            {
                return NotFound();
            }
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }

            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicantExists(int id)
        {
            return (_context.Applicants?.Any(e => e.ApplicantId == id)).GetValueOrDefault();
        }

        private bool ApplicantWorkExists(string ? jobPosition)
        {
            return (_context.Applicants?.Any(e => e.JobPosition == jobPosition)).GetValueOrDefault();
        }
    }
}

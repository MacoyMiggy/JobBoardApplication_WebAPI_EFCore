//GIT PROJECT LINK : https://github.com/MacoyMiggy/JobBoardApplication_WebAPI_EFCore

// Controller for Job Position WEB API


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
    public class JobPositionsController : ControllerBase
    {
        private readonly JobBoardAppWebApiContext _context;

        public JobPositionsController(JobBoardAppWebApiContext context)
        {
            _context = context;
        }

        // GET: api/JobPositions
        [HttpGet("GetJobPositions")]
        public async Task<ActionResult<IEnumerable<JobPosition>>> GetJobPositions()
        {
          if (_context.JobPositions == null)
          {
              return NotFound();
          }
            return await _context.JobPositions.ToListAsync();
        }

        // GET: api/JobPositions/5
        [HttpGet("GetJobPosition/{id}")]
        public async Task<ActionResult<JobPosition>> GetJobPosition(int id)
        {
          if (_context.JobPositions == null)
          {
              return NotFound();
          }
            var jobPosition = await _context.JobPositions.FindAsync(id);

            if (jobPosition == null)
            {
                return NotFound();
            }

            return jobPosition;
        }

        // PUT: api/JobPositions/5
        [HttpPut("UpdateJobPosition/{id}")]
        public async Task<IActionResult> PutJobPosition(int id, JobPosition jobPosition)
        {
            if (id != jobPosition.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobPositionIdExists(id))
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

        // POST: api/JobPositions
        [HttpPost("CreateJobPosition")]
        public async Task<ActionResult<JobPosition>> PostJobPosition(JobPosition jobPosition)
        {
          if (_context.JobPositions == null)
          {
              return Problem("Entity set 'JobBoardAppWebApiContext.JobPositions'  is null.");
          }
            _context.JobPositions.Add(jobPosition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (JobPositionIdExists(jobPosition.Id) && JobPositionExists(jobPosition.WorkPosition))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetJobPosition", new { id = jobPosition.Id, jobPosition.WorkPosition}, jobPosition);
        }

        // DELETE: api/JobPositions/5
        [HttpDelete("DeleteJobPosition/{id}")]
        public async Task<IActionResult> DeleteJobPosition(int id)
        {
            if (_context.JobPositions == null)
            {
                return NotFound();
            }
            var jobPosition = await _context.JobPositions.FindAsync(id);
            if (jobPosition == null)
            {
                return NotFound();
            }

            _context.JobPositions.Remove(jobPosition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobPositionExists(string ? workPosition)
        {
            return (_context.JobPositions?.Any(e => e.WorkPosition == workPosition)).GetValueOrDefault();
        }

        private bool JobPositionIdExists(int id)
        {
            return (_context.JobPositions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

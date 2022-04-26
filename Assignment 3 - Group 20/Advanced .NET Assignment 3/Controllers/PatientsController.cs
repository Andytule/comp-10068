using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Advanced_.NET_Assignment_3.Data;
using Advanced_.NET_Assignment_3.Models;

namespace Advanced_.NET_Assignment_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly Advanced_NET_Assignment_3Context _context;

        public PatientsController(Advanced_NET_Assignment_3Context context)
        {
            _context = context;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient()
        {
            return await _context.Patient.ToListAsync();
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(Guid id)
        {
            var patient = await _context.Patient.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // GET: api/Patient?firstName=... params are optional - if they're not defined in the request they will be null/empty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient(string firstName, string lastName, DateTimeOffset dateofBirth)
        {
            if (!(firstName == null))
            {
                var patient = await _context.Patient.Where(p => p.FirstName == firstName).ToListAsync();
                if (patient == null)
                {
                    return NotFound();
                }
                return patient;
            }

            if (!(lastName == null))
            {
                var patient = await _context.Patient.Where(p => p.LastName == lastName).ToListAsync();
                if (patient == null)
                {
                    return NotFound();
                }
                return patient;
            }

            if (!(dateofBirth == null))
            {
                var patient = await _context.Patient.Where(p => p.DateOfBirth == dateofBirth).ToListAsync();
                if (patient == null)
                {
                    return NotFound();
                }
                return patient;
            }

            try
            {
                var patient = await _context.Patient.ToListAsync();
                return patient;

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(Guid id, Patient patient)
        {
            if (id != patient.Id)
            {
                return BadRequest();
            }

            _context.Entry(patient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
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

        // POST: api/Patients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient patient)
        {
            _context.Patient.Add(patient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatient", new { id = patient.Id }, patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patient>> DeletePatient(Guid id)
        {
            var patient = await _context.Patient.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        private bool PatientExists(Guid id)
        {
            return _context.Patient.Any(e => e.Id == id);
        }
    }
}

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
    public class OrganizationsController : ControllerBase
    {
        private readonly Advanced_NET_Assignment_3Context _context;

        public OrganizationsController(Advanced_NET_Assignment_3Context context)
        {
            _context = context;
        }

        // GET: api/Organizations?creationTime= ... params are optional - if they're not defined in the request they will be null/empty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organization>>> GetImmunization(string name, int? type)
        {
            if (!(name == null))
            {
                try
                {
                    var organization = await _context.Organization.Where(o => o.Name == name).ToListAsync();
                    if (organization == null)
                    {
                        return NotFound();
                    }
                    return organization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }

            if (!(type == null))
            {
                try
                {
                    var organization = await _context.Organization.Where(o => (int)o.Type == type).ToListAsync();
                    if (organization == null)
                    {
                        return NotFound();
                    }
                    return organization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            } 

            try
            {
                var organization = await _context.Organization.ToListAsync();
                return organization;

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


        // GET: api/Organizations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organization>> GetOrganization(Guid id)
        {
            try
            {
                var organization = await _context.Organization.FindAsync(id);

                if (organization == null)
                {
                    return NotFound();
                }

                return organization;

            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        // PUT: api/Organizations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganization(Guid id, Organization organization)
        {
            if (id != organization.Id)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(organization).State = EntityState.Modified;
            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Organizations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Organization>> PostOrganization(Organization organization)
        {
            try
            {
                _context.Organization.Add(organization);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetOrganization", new { id = organization.Id }, organization);

            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        // DELETE: api/Organizations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Organization>> DeleteOrganization(Guid id)
        {
            try
            {
                var organization = await _context.Organization.FindAsync(id);
                if (organization == null)
                {
                    return NotFound();
                }

                _context.Organization.Remove(organization);
                await _context.SaveChangesAsync();

                return NoContent();

            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        private bool OrganizationExists(Guid id)
        {
            return _context.Organization.Any(e => e.Id == id);
        }
    }
}

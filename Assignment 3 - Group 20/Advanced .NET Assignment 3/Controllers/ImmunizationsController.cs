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
    public class ImmunizationsController : ControllerBase
    {
        private readonly Advanced_NET_Assignment_3Context _context;

        public ImmunizationsController(Advanced_NET_Assignment_3Context context)
        {
            _context = context;
        }

        // GET: api/Immunizations?creationTime= ... params are optional - if they're not defined in the request they will be null/empty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Immunization>>> GetImmunization(DateTimeOffset? creationTime, string officialName, string tradeName, string lotNumber)
        {
            if (!(creationTime == null))
            {
                try { 
                    var immunization = await _context.Immunization.Where(p => p.CreationTime == creationTime).ToListAsync();
                    if (immunization == null)
                    {
                        return NotFound();
                    }
                    return immunization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }

            if (!(officialName == null))
            {
                try { 
                    var immunization = await _context.Immunization.Where(p => p.OfficialName.ToUpper() == officialName.ToUpper()).ToListAsync();
                    if (immunization == null)
                    {
                        return NotFound();
                    }
                    return immunization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }

            if (!(tradeName == null))
            {
                try { 
                    var immunization = await _context.Immunization.Where(p => p.TradeName.ToUpper() == tradeName.ToUpper()).ToListAsync();
                    if (immunization == null)
                    {
                        return NotFound();
                    }
                    return immunization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }

            if (!(lotNumber == null))
            {
                try
                {
                    var immunization = await _context.Immunization.Where(p => p.LotNumber.ToUpper() == lotNumber.ToUpper()).ToListAsync();
                    if (immunization == null)
                    {
                        return NotFound();
                    }
                    return immunization;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }

            try
            {
                var immunizations = await _context.Immunization.ToListAsync();
                return immunizations;

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


        // GET: api/Immunizations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Immunization>> GetImmunization(Guid id)
        {
            try
            {
                var immunization = await _context.Immunization.FindAsync(id);

                if (immunization == null)
                {
                    return NotFound();
                }

                return immunization;

            }catch(Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        // PUT: api/Immunizations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImmunization(Guid id, Immunization immunization)
        {
            if (id != immunization.Id)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(immunization).State = EntityState.Modified;

            }catch(Exception ex) { return StatusCode(500, "Internal server error"); }
            
            immunization.UpdatedTime = DateTimeOffset.Now;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImmunizationExists(id))
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

        // POST: api/Immunizations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Immunization>> PostImmunization(Immunization immunization)
        {
            try
            {
                _context.Immunization.Add(immunization);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetImmunization", new { id = immunization.Id }, immunization);

            } catch(Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        // DELETE: api/Immunizations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Immunization>> DeleteImmunization(Guid id)
        {
            try
            {
                var immunization = await _context.Immunization.FindAsync(id);
                if (immunization == null)
                {
                    return NotFound();
                }

                _context.Immunization.Remove(immunization);
                await _context.SaveChangesAsync();

                return NoContent();

            }catch (Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        private bool ImmunizationExists(Guid id)
        {
            return _context.Immunization.Any(e => e.Id == id);
        }
    }
}

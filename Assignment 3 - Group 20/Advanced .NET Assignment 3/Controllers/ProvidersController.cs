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
    public class ProvidersController : ControllerBase
    {
        private readonly Advanced_NET_Assignment_3Context _context;

        public ProvidersController(Advanced_NET_Assignment_3Context context)
        {
            _context = context;
        }

        // GET: api/Providers
        // GET: api/Providers?firstName= ... params are optional - if they're not defined in the request they will be null/empty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provider>>> GetProvider(string firstName, string lastName, uint? licenseNumber)
        {
            if(!(firstName == null))
            {
                try
                {
                    var provider = await _context.Provider.Where(p => p.FirstName.ToUpper() == firstName.ToUpper()).ToListAsync();
                    if (provider == null)
                    {
                        return NotFound();
                    }
                    return provider;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }

            }
            if (!(lastName == null))
            {
                try
                {
                    var provider = await _context.Provider.Where(p => p.LastName.ToUpper() == lastName.ToUpper()).ToListAsync();
                    if (provider == null)
                    {
                        return NotFound();
                    }
                    return provider;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }

            }
            if (!(licenseNumber == null))
            {
                try
                {
                    var provider = await _context.Provider.Where(p => p.LicenseNumber == licenseNumber).ToListAsync();
                    if (provider == null)
                    {
                        return NotFound();
                    }
                    return provider;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Internal server error");
                }
            }
            try
            {
                var providers = await _context.Provider.ToListAsync();
                return providers;
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
            //return await _context.Provider.ToListAsync();
        }

        // GET: api/Providers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> GetProvider(Guid id)
        {
            try
            {
                var provider = await _context.Provider.FindAsync(id);

                if (provider == null)
                {
                    return NotFound();
                }

                return provider;
            } catch (Exception ex) { return StatusCode(500, "Internal server error"); }

        }

        // PUT: api/Providers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvider(Guid id, Provider provider)
        {
            if (id != provider.Id)
            {
                return BadRequest();
            }
            try
            {
                _context.Entry(provider).State = EntityState.Modified;
            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
            //return NoContent();
        }

        // POST: api/Providers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Provider>> PostProvider(Provider provider)
        {
            try
            {
                _context.Provider.Add(provider);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProvider", new { id = provider.Id }, provider);
            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }
        }

        // DELETE: api/Providers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Provider>> DeleteProvider(Guid id)
        {
            try
            {
                var provider = await _context.Provider.FindAsync(id);
                if (provider == null)
                {
                    return NotFound();
                }

                _context.Provider.Remove(provider);
                await _context.SaveChangesAsync();

                //return provider;
                return NoContent();
            }
            catch (Exception ex) { return StatusCode(500, "Internal server error"); }

        }

        // GET: api/Providers/name
        [HttpGet("test/{name}")]
        //[FromQuery(Name = "firstName")]
        public async Task<ActionResult<Provider>> GetProviderFirstName(string name)
        {
            var provider = await _context.Provider.FirstOrDefaultAsync(p => p.FirstName == name);
            if (provider == null)
            {
                return NotFound();
            }

            return provider;
        }

        private bool ProviderExists(Guid id)
        {
            return _context.Provider.Any(e => e.Id == id);
        }
    }
}

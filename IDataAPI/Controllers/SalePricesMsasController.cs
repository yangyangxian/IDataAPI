using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IDataAPI.Models;

namespace IDataAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SalePricesMsas")]
    public class SalePricesMsasController : Controller
    {
        private readonly IDataContext _context;

        public SalePricesMsasController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/SalePricesMsas
        [HttpGet]
        public IEnumerable<SalePricesMsa> GetSalePricesMsa()
        {
            return _context.SalePricesMsa;
        }

        // GET: api/SalePricesMsas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSalePricesMsa([FromRoute] double id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salePricesMsa = await _context.SalePricesMsa.SingleOrDefaultAsync(m => m.RegionId == id);

            if (salePricesMsa == null)
            {
                return NotFound();
            }

            return Ok(salePricesMsa);
        }

        // PUT: api/SalePricesMsas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalePricesMsa([FromRoute] double id, [FromBody] SalePricesMsa salePricesMsa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salePricesMsa.RegionId)
            {
                return BadRequest();
            }

            _context.Entry(salePricesMsa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalePricesMsaExists(id))
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

        // POST: api/SalePricesMsas
        [HttpPost]
        public async Task<IActionResult> PostSalePricesMsa([FromBody] SalePricesMsa salePricesMsa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SalePricesMsa.Add(salePricesMsa);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SalePricesMsaExists(salePricesMsa.RegionId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSalePricesMsa", new { id = salePricesMsa.RegionId }, salePricesMsa);
        }

        // DELETE: api/SalePricesMsas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalePricesMsa([FromRoute] double id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salePricesMsa = await _context.SalePricesMsa.SingleOrDefaultAsync(m => m.RegionId == id);
            if (salePricesMsa == null)
            {
                return NotFound();
            }

            _context.SalePricesMsa.Remove(salePricesMsa);
            await _context.SaveChangesAsync();

            return Ok(salePricesMsa);
        }

        private bool SalePricesMsaExists(double id)
        {
            return _context.SalePricesMsa.Any(e => e.RegionId == id);
        }
    }
}
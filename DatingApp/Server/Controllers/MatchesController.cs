﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Server.Data;
using DatingApp.Shared.Domain;
using DatingApp.Server.IRepository;

namespace DatingApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        //private object unitOfWork;

        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // public MatchesController(ApplicationDbContext context)
        public MatchesController(IUnitOfWork unitOfWork)
        {
            //Refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Matches
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<Match>>> GetMatches()
        public async Task<IActionResult> GetMatches()
        {
            //return await _context.Matches.ToListAsync();
            //Refacted
            var matches = await _unitOfWork.Matches.GetAll();
            return Ok(matches);
        }

        // GET: api/Matches/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Match>> GetMatch(int id)
        public async Task<IActionResult> GetMatch(int id)
        {
            //var match = await _context.Matches.FindAsync(id);
            var match = await _unitOfWork.Matches.Get(q => q.Id == id);

            if (match == null)
            {
                return NotFound();
            }

            //return match;
            return Ok(match);
        }

        // PUT: api/Matches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            //_context.Entry(match).State = EntityState.Modified;
            _unitOfWork.Matches.Update(match);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != match.Id)
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

        // POST: api/Matches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Match>> PostMatch(Match match)
        {
            // _context.Matches.Add(match);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Matches.Insert(match);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMatch", new { id = match.Id }, match);
        }

        // DELETE: api/Matches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch(int id)
        {
            //var match = await _context.Matches.FindAsync(id);

            var match = await _unitOfWork.Matches.Get(q => q.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            //_context.Matches.Remove(match);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Matches.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MatchExists(int id)
        {
            // return _context.Matches.Any(e => e.Id == id);
            var match = await _unitOfWork.Matches.Get(q => q.Id == id);
            return match != null;
        }
    }
}

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
    public class MessagesController : ControllerBase
    {
        //private object unitOfWork;

        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // public MessagesController(ApplicationDbContext context)
        public MessagesController(IUnitOfWork unitOfWork)
        {
            //Refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Messages
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        public async Task<IActionResult> GetMessages()
        {
            //return NotFound(); //Test for Global Error Handling
            //return await _context.Messages.ToListAsync();
            //Refacted
            var messages = await _unitOfWork.Messages.GetAll(includes: q => q.Include(x => x.Conversation));
            return Ok(messages);
        }

        // GET: api/Messages/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Message>> GetMessage(int id)
        public async Task<IActionResult> GetMessage(int id)
        {
            //var message = await _context.Messages.FindAsync(id);
            var message = await _unitOfWork.Messages.Get(q => q.Id == id);

            if (message == null)
            {
                return NotFound();
            }

            //return message;
            return Ok(message);
        }

        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage(int id, Message message)
        {
            if (id != message.Id)
            {
                return BadRequest();
            }

            //_context.Entry(message).State = EntityState.Modified;
            _unitOfWork.Messages.Update(message);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != message.Id)
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

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            // _context.Messages.Add(message);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Messages.Insert(message);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        // DELETE: api/Messages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            //var message = await _context.Messages.FindAsync(id);

            var message = await _unitOfWork.Messages.Get(q => q.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            //_context.Messages.Remove(message);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Messages.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MessageExists(int id)
        {
            // return _context.Messages.Any(e => e.Id == id);
            var message = await _unitOfWork.Messages.Get(q => q.Id == id);
            return message != null;
        }
    }
}

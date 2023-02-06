using System;
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
    public class ConversationsController : ControllerBase
    {
        //private object unitOfWork;

        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // public ConversationsController(ApplicationDbContext context)
        public ConversationsController(IUnitOfWork unitOfWork)
        {
            //Refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Conversations
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<Conversation>>> GetConversations()
        public async Task<IActionResult> GetConversations()
        {
            //return await _context.Conversations.ToListAsync();
            //Refacted
            var conversations = await _unitOfWork.Conversations.GetAll(includes: q => q.Include(x => x.Sender).Include(x => x.Receiver));
            return Ok(conversations);
        }

        // GET: api/Conversations/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Conversation>> GetConversation(int id)
        public async Task<IActionResult> GetConversation(int id)
        {
            //var conversation = await _context.Conversations.FindAsync(id);
            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);

            if (conversation == null)
            {
                return NotFound();
            }

            //return conversation;
            return Ok(conversation);
        }

        // PUT: api/Conversations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConversation(int id, Conversation conversation)
        {
            if (id != conversation.Id)
            {
                return BadRequest();
            }

            //_context.Entry(conversation).State = EntityState.Modified;
            _unitOfWork.Conversations.Update(conversation);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id != conversation.Id)
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

        // POST: api/Conversations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conversation>> PostConversation(Conversation conversation)
        {
            // _context.Conversations.Add(conversation);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Conversations.Insert(conversation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConversation", new { id = conversation.Id }, conversation);
        }

        // DELETE: api/Conversations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConversation(int id)
        {
            //var conversation = await _context.Conversations.FindAsync(id);

            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);
            if (conversation == null)
            {
                return NotFound();
            }

            //_context.Conversations.Remove(conversation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Conversations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ConversationExists(int id)
        {
            // return _context.Conversations.Any(e => e.Id == id);
            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);
            return conversation != null;
        }
    }
}

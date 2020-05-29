using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuotesWebAPI.Db;
using QuotesWebAPI.Models;

namespace QuotesWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private DataContext _context { get; }

        public QuotesController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Quote>>> GetAll()
        {
            var date = DateTime.Now;
            var q = await _context.Quotes.Where(x => date.Day - x.InsertDate.Day > 30).Select(x => x).ToListAsync();
            if( q.Count() > 0 ){
                foreach(var x in q){
                    _context.Remove(x);
                }
                await _context.SaveChangesAsync();
            }
            return await _context.Quotes.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Add(Quote quote)
        {
            quote.InsertDate = DateTime.Now;
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _context.Quotes.Add(quote);
            if (await _context.SaveChangesAsync() > 0)
                return Ok();
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Quote quote)
        {
            var q = await _context.Quotes.FindAsync(id);
            if(quote.Text == null)
                quote.Text = q.Text;
            if (q == null)
                return NotFound();
            q.Text = quote.Text;
            q.Author = quote.Author ?? q.Author;
            if (await _context.SaveChangesAsync() > 0)
                return Ok();
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var q = await _context.Quotes.FindAsync(id);
            if (q == null)
                return NotFound();
            _context.Quotes.Remove(q);
            if (await _context.SaveChangesAsync() > 0)
                return Ok();
            return BadRequest();
        }
    }    
}
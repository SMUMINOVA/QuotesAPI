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
            var q = _context.Quotes.Where(x => date.Day - x.InsertDate.Day > 30).Select(x => x);
            if( q.Count() > 0 ){
                _context.Remove(q);
                await _context.SaveChangesAsync();
            }       
            var t = await _context.Quotes.ToListAsync();
            return t;
        }

        
    }
    
}
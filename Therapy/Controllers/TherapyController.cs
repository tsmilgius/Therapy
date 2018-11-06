using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Therapy.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Therapy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapyController : Controller
    {
        private readonly TherapyContext _context;

        public TherapyController(TherapyContext context)
        {
            _context = context;
            if (_context.TherapyEntity.Count() == 0)
            {
                _context.TherapyEntity.Add(new TherapyEntity {StartDate = new DateTime(2018, 11, 06, 19, 53, 00), DwellCount = 4, DwellDuration = 128, TherapyDuration = 630});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TherapyEntity>> GetAll()
        {
            return _context.TherapyEntity.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TherapyEntity> GetById(long id)
        {
            var item = _context.TherapyEntity.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

    }
}

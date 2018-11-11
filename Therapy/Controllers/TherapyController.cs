using System;
using System.Collections.Generic;
using System.Linq;
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
            if (_context.Solution.Count() == 0)
            {
                //_context.Programme.Add(new Programme {StartDate = new DateTime(2018, 11, 06, 19, 53, 00), DwellCount = 4, DwellDuration = 128, TherapyDuration = 630});
                _context.Solution.Add(new Bag { Id = 1, Type = "Glucose", Concentration = 1.36f });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Bag>> GetAll()
        {
            return _context.Solution.ToList();
        }

      /* [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<Programme> GetById(long id)
        {
            var item = _context.Programme.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }*/

    }
}

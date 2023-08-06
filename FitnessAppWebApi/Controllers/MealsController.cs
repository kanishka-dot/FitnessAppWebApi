using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitnessAppWebApi.Models;

namespace FitnessAppWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly APIDbContext _context;

        public MealsController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Meals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
        {
          if (_context.Meals == null)
          {
              return NotFound();
          }
            return await _context.Meals.ToListAsync();
        }

        // GET: api/Meals/5
        [HttpGet("{id}")]
        public async Task<List<Meal>> GetMeal(string id)
        {
          if (_context.Meals == null)
          {
              return null;
          }
            var meal = await _context.Meals.AsQueryable().Where(i => i.UserID.Contains(id)).ToListAsync();

            if (meal == null)
            {
                return null;
            }

            return meal;
        }

        // PUT: api/Meals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}/{date}")]
        public async Task<IActionResult> updateMeal(string id, string date, Meal meal)
        {
            if (id != meal.UserID)
            {
                return BadRequest();
            }

            if (date != meal.Date)
            {
                return BadRequest();
            }


            var getworkout = await _context.Meals.FindAsync(id, date);

            if (getworkout == null)
            {
                _context.Meals.Add(meal);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    if (MealExists(meal.UserID))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            else
            {
                _context.Entry(meal).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }

            return NoContent();
        }

        // POST: api/Meals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meal>> PostMeal(Meal meal)
        {
          if (_context.Meals == null)
          {
              return Problem("Entity set 'APIDbContext.Meals'  is null.");
          }
            _context.Meals.Add(meal);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MealExists(meal.UserID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMeal", new { id = meal.UserID }, meal);
        }

        // DELETE: api/Meals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(string id)
        {
            if (_context.Meals == null)
            {
                return NotFound();
            }
            var meal = await _context.Meals.FindAsync(id);
            if (meal == null)
            {
                return NotFound();
            }

            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealExists(string id)
        {
            return (_context.Meals?.Any(e => e.UserID == id)).GetValueOrDefault();
        }
    }
}

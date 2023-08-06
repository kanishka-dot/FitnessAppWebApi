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
    public class WorkoutsController : ControllerBase
    {
        private readonly APIDbContext _context;

        public WorkoutsController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Workouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkouts()
        {
          if (_context.Workouts == null)
          {
              return NotFound();
          }
            return await _context.Workouts.ToListAsync();
        }

        // GET: api/Workouts/5
        [HttpGet("{id}")]
        public async Task<List<Workout>> GetWorkout(string id)
        {
          if (_context.Workouts == null)
          {
              return null;
          }
            var workout = await _context.Workouts.AsQueryable().Where(i=>i.UserID.Contains(id)).ToListAsync();

            if (workout == null)
            {
                return null;
            }

            return workout;
        }

        // PUT: api/Workouts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}/{date}")]
        public async Task<IActionResult> UpdateWorkout(string id, string date, Workout workout)
        {
            if (id != workout.UserID)
            {
                return BadRequest();
            }

            if (date != workout.Date)
            {
                return BadRequest();
            }

            var getworkout = await _context.Workouts.FindAsync(id,date);

            if (getworkout == null)
            {
                _context.Workouts.Add(workout);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    if (WorkoutExists(workout.UserID))
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
                _context.Entry(workout).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkoutExists(id))
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

        // POST: api/Workouts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Workout>> PostWorkout(Workout workout)
        {
          if (_context.Workouts == null)
          {
              return Problem("Entity set 'APIDbContext.Workouts'  is null.");
          }
            _context.Workouts.Add(workout);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WorkoutExists(workout.UserID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWorkout", new { id = workout.UserID }, workout);
        }

        // DELETE: api/Workouts/5
        [HttpDelete("{id}/{date}")]
        public async Task<IActionResult> DeleteWorkout(string id, string date)
        {
            if (_context.Workouts == null)
            {
                return NotFound();
            }
            var workout = await _context.Workouts.FindAsync(id, date);
            if (workout == null)
            {
                return NotFound();
            }

            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkoutExists(string id)
        {
            return (_context.Workouts?.Any(e => e.UserID == id)).GetValueOrDefault();
        }
    }
}

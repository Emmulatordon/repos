using ExpenseTracker.DataAccess.Entities;
using ExpenseTracker.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Core.Services
{
    public class HabitService:IHabitService
    {
        private readonly GoodHabitsDbContext _dbContext;
        public HabitService(GoodHabitsDbContext dbContext) =>
        _dbContext = dbContext;
        public async Task<Habit> Create(string name,
        string description)
        {
            var habit = _dbContext.Habits!.Add(new Habit
            {
                Name
            = name,
                Description = description
            }).Entity;
            await _dbContext.SaveChangesAsync();
            return habit;
        }
        public async Task<IReadOnlyList<Habit>> GetAll() =>
        await _dbContext.Habits!.ToListAsync();
        public async Task<Habit> GetById(int id) => await
        _dbContext.Habits.FindAsync(id);
    }
}

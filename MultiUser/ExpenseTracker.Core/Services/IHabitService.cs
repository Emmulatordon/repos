using ExpenseTracker.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Services
{
    public interface IHabitService
    {
        Task<Habit> Create(string name, string description);
        Task<Habit> GetById(int id);
        Task<IReadOnlyList<Habit>> GetAll();
    }
}

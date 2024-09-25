using ExpenseTracker.Core;
using ExpenseTracker.Core.Services;
using ExpenseTracker.Models.HabitDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitsController : ControllerBase
    {
        private readonly ILogger<HabitsController> _logger;
        private readonly IHabitService _habitService;
        public HabitsController(
        ILogger<HabitsController> logger,
        IHabitService goodHabitsService
        )
        {
            _logger = logger;
            _habitService = goodHabitsService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id) =>
        Ok(await _habitService.GetById(id));
        [HttpGet]
        public async Task<IActionResult> GetAsync() => Ok(await
        _habitService.GetAll());
        [HttpPost]
        public async Task<IActionResult>
        CreateAsync(CreateHabitDto request) => Ok(await
        _habitService.Create(request.Name,
        request.Description));
    }
}

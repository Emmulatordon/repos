﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models.HabitDTOs
{
    public class CreateHabitDto
    {

            public string Name { get; set; } = default!;
            public string Description { get; set; } = default!;
        

    }
}

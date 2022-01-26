using DristRent.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DristRent.Infrastructure
{
    public class MainMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public MainMenuViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}

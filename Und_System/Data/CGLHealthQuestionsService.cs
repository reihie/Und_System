﻿using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLHealthQuestionsService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Health_Question>> GetSubstandardAsync()
        {
            return await _context.CGL_HEALTH_QUESTION.ToListAsync();
        }
    }
}
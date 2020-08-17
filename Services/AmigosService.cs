using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class AmigosService
    {
        private readonly AmigosContext _context;
        
        public AmigosService(AmigosContext context)
        {
            _context = context;
        }

        public async Task<List<Amigos>> FindAllAsync()
        {
            return await _context.Amigo.ToListAsync();
        }
    }
}

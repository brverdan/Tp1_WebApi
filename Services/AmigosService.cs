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

        public List<Amigos> FindAll()
        {
            return _context.Amigo.ToList();
        }

        public Amigos FindAllById(int id)
        {
            return  _context.Amigo.FirstOrDefault(x => x.Id == id);
        }
    }
}

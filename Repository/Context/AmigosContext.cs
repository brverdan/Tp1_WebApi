using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository.Context
{
    public class AmigosContext : DbContext
    {
        public AmigosContext (DbContextOptions<AmigosContext> options) : base(options)
        {
        }
        public DbSet<Amigos> Amigo { get; set; }
    }
}

using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Seeding
{
    public class AmigosSeeding
    {
        private AmigosContext _amigosContext;

        public AmigosSeeding(AmigosContext context)
        {
            _amigosContext = context;
        }

        public void Seed()
        {
            if(_amigosContext.Amigo.Any())
            {
                return;
            }

            Amigos a1 = new Amigos ("Bruno", "Verdan",  new DateTime(2000, 2, 2),  "brgordinho@gmail.com" );
            Amigos a2 = new Amigos ("Gabriel", "Cunha",  new DateTime(1999, 3, 20),  "gabrielo@gmail.com" );
            Amigos a3 = new Amigos ("Thiago", "Rios",  new DateTime(2001, 4, 21),  "thiago@gmail.com" );
            Amigos a4 = new Amigos ("Lucas", "Barroso",  new DateTime(1980, 5, 24),  "lucas@gmail.com" );
            Amigos a5 = new Amigos ("Thiago", "Suassuna",  new DateTime(1985, 8, 12),  "batman@gmail.com" );
            Amigos a6 = new Amigos ("Juann", "Barroso",  new DateTime(1970, 10, 2),  "robin@gmail.com" );
            Amigos a7 = new Amigos ("Gabriel", "Suassuna",  new DateTime(2001, 11, 22),  "juann@gmail.com" );
            Amigos a8 = new Amigos ("Juann", "Barroso",  new DateTime(1975, 9, 16),  "goku@gmail.com" );
            Amigos a9 = new Amigos ("Lucas", "Cunha",  new DateTime(1966, 2, 17),  "vegeta@gmail.com" );
            Amigos a10 = new Amigos ("Thiago", "Rios",  new DateTime(2000, 5, 24),  "ban@gmail.com" );
            Amigos a11 = new Amigos ("Juann", "Cunha",  new DateTime(1995, 8, 3),  "piplupp@gmail.com" );
            Amigos a12 = new Amigos  ("Gabriel", "Verdan",  new DateTime(1998, 7, 30),  "evolucao@gmail.com" );
            Amigos a13 = new Amigos ("Lucas", "Rios",  new DateTime(1968, 6, 12),  "metaloroch@gmail.com" );
            Amigos a14 = new Amigos  ("Thiago",  "Cunha",  new DateTime(1984, 1, 10),  "watchtv@gmail.com" );

            _amigosContext.Amigo.AddRange(
                a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14
                );

            _amigosContext.SaveChanges();
        }
    }
}

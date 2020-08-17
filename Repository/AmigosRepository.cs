using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class AmigosRepository
    {
        private readonly AmigosContext _amigosContext;

        public AmigosRepository(AmigosContext amigosContext)
        {
            _amigosContext = amigosContext;
        }
    }
}

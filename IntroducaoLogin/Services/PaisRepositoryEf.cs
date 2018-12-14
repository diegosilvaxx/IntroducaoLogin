using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoLogin.Data;
using IntroducaoLogin.Models;

namespace IntroducaoLogin.Services
{ 
    public class PaisRepositoryEf : IRepositorioPaises
     
    {
        public PaisRepositoryEf(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObterPaises()
        {
            return DbContext.Paises.ToList();
        }
    }
}

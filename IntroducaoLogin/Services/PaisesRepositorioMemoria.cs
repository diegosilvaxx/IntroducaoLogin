using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoLogin.Models;

namespace IntroducaoLogin.Services
{
    public class PaisesRepositorioMemoria
    {
        public List<Pais> ObterPaises()
        {
            List<Pais>Paises = new List<Pais>()
            {
                new Pais("Canada")
            };

            return Paises;
        }
    }
}

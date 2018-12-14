using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoLogin.Models;

namespace IntroducaoLogin.Services
{
    public interface IRepositorioPaises
    {
        List<Pais> ObterPaises();
    }
}

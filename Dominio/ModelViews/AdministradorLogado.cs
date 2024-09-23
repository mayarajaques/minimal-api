using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Dominio.ModelViews
{
    public class AdministradorLogado
    {
   
        public string Email { get; set; } = default!; // propriedade não nulo
        public string Perfil { get; set; } = default!; // propriedade não nulo
         public string Token { get; set; } = default!; // propriedade não nulo
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews
{
    public record AdministradorModelView
    {
        public int Id { get; set; } = default!; // propriedade não nulo
        public string Email { get; set; } = default!; // propriedade não nulo
        public string Perfil { get; set; } = default!; // propriedade não nulo
    }
}
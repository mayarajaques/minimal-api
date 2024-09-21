using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.DTOs;

    public class LoginDTO
{
    public string Email { get; set; } = default!; // propriedade não nulo
    public string Senha { get; set; } = default!; // propriedade não nulo
}

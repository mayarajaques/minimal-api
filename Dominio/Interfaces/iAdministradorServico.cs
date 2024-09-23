using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces
{
    //interface
    public interface iAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO); //metodo
        Administrador Incluir(Administrador administrador); //metodo
        List<Administrador> Todos(int? pagina); //metodo
          Administrador? BuscaPorId(int id); //metodo


    }
}
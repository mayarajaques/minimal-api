using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Dominio.Interfaces
{
    //interface
    public interface iVeiculoServico
    {
        List<Veiculo> Todos(int? pagina =1, string? nome = null, string? marca = null); // paginação
        Veiculo? BuscaPorId(int id);
        void Incluir(Veiculo veiculo);
        void Atualizar(Veiculo veiculo);
        void Apagar(Veiculo veiculo);

    }
}
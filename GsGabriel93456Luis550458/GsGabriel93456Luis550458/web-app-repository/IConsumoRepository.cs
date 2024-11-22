using GsGabriel93456Luis550458;

namespace GsGabriel93456Luis550458
{
    public  interface IConsumoRepository 
    {
        Task<IEnumerable<Consumo>> ListarConsumos();
        Task SalvarConsumo(Consumo consumo);
        Task AtualizarConsumo(Consumo consumo);
        Task RemoverConsumo(string id);
    }
}

using MVC.Consumir.Models.Paises;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC.Consumir.ApiServices
{
    public interface IEstadoApi
    {
        Task<CriarEstadoViewModel> PostEstadoAsync(CriarEstadoViewModel estadoViewModel);
        Task<List<EstadoViewModel>> GetEstados();
        Task<EstadoViewModel> GetEstado(int id);
    }
}

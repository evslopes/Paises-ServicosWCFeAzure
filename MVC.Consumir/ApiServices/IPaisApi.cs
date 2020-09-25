using MVC.Consumir.Models.Paises;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC.Consumir.ApiServices
{
    public interface IPaisApi
    {
        Task<List<PaisViewModel>> GetPaises();
        Task<PaisViewModel> GetPais(int id);

        Task<CriarPaisViewModel> PostAsync(CriarPaisViewModel paisViewModel);
    }
}

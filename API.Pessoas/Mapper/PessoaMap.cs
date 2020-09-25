using API.Pessoas.Models;
using AutoMapper;

namespace API.Pessoas.Mapper
{
    public class PessoaMap : Profile
    {
        public PessoaMap()
        {
            CreateMap<Pessoa, PessoaResponse>();
        }
    }
}

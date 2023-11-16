using HW8.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HW8.Repositories.Abstractions
{
    public interface ICandyRepository
    {
        public List <CandysEntity> CraftCandys ();

        public CandyRepository SortCandysRepo(List<CandysEntity> list);
    }
}

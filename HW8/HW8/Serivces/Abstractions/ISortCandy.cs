using HW8.Entities;
using HW8.Models;
using HW8.Repositories;

namespace HW8.Serivces.Abstractions
{
    public interface ISortCandy
    {
        public List<CandysEntity> CraftedCandys();
        public CandyRepository SortCandys();
    }
}

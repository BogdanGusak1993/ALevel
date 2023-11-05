using HW8.Entities;
using HW8.Models;
using HW8.Repositories;
using HW8.Repositories.Abstractions;
using HW8.Serivces.Abstractions;

namespace HW8.Serivces
{
    public class SortCandy : ISortCandy
    {
        private readonly ICandyRepository _candysRepository;

        public SortCandy(ICandyRepository candysRepository)
        {
            _candysRepository = candysRepository;
        }
        public void SortCandys()
        {
            var candys = _candysRepository.CraftCandys();
            _candysRepository.SortCandysRepo(candys);
        }
    }
}

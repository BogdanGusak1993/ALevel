using HW8.Entities;
using HW8.Models;
using HW8.Repositories;
using HW8.Repositories.Abstractions;
using HW8.Serivces.Abstractions;

namespace HW8.Serivces
{
    public class SortCandy : ISortCandy
    {
        public  ICandyRepository CandysRepository;
        public List<CandysEntity> Candys;

        public SortCandy(ICandyRepository candysRepository)
        {
            CandysRepository = candysRepository;
        }
        public List<CandysEntity> CraftedCandys()
        {
            Candys = CandysRepository.CraftCandys();
            return Candys;
        }

        public CandyRepository SortCandys()
        {
            var cadysRepo = CandysRepository.SortCandysRepo(Candys);
            return cadysRepo;
        }
    }
}

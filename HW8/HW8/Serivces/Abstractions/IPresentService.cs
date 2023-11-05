using HW8.Entities;
using HW8.Models;

namespace HW8.Serivces.Abstractions
{
    public interface IPresentService
    {
        public Candy AddCandy (List<CandysEntity> candyList, string name);
    }
}

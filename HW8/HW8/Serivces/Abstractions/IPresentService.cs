using HW8.Entities;
using HW8.Models;
using Microsoft.Extensions.DependencyInjection;

namespace HW8.Serivces.Abstractions
{
    public interface IPresentService
    {
        public Candy AddCandy (List<CandysEntity> candyList, string name);
    }
}

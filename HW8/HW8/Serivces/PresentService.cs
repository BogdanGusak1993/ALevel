using HW8.Entities;
using HW8.Models;
using HW8.Serivces.Abstractions;

namespace HW8.Serivces
{
    public class PresentService : IPresentService
    {
        public Candy AddCandy(List<CandysEntity> candyList, string name)
        {
            foreach (CandysEntity candyEntity in candyList)
            {
               if(candyEntity.Name == name)
                {
                    Candy candy = new Candy();
                    candy.Name = name;
                    candy.Price = candyEntity.Price;
                    candy.Weight = candyEntity.Weight;
                    candy.Type = candyEntity.Type;
                    return candy;
                }
            }
            return null;
        }
    }
}

using HW8.Entities;
using HW8.Models;
using HW8.Repositories;
using HW8.Repositories.Abstractions;
using HW8.Serivces;
using HW8.Serivces.Abstractions;
using Microsoft.Extensions.DependencyInjection;



namespace HW8
{
    public class App
    {
        public ISortCandy SortCandy;
        private readonly IPresentService _present;

        public App(ISortCandy candyList, IPresentService present)
        {
            SortCandy = candyList;
            _present = present;
        }

        public void Start()
        {
            var craftedCandys = SortCandy.CraftedCandys();
            var sortedCandys = SortCandy.SortCandys();
            sortedCandys.CandysList = craftedCandys;

            Console.WriteLine($"Its all candys:");
            for (int i = 0; i < sortedCandys.ChocolateList.Count; i++)
            {
                
                Console.WriteLine($"Name:{ sortedCandys.CandysList[i].Name}, weight:{sortedCandys.CandysList[i].Weight}, " +
                                  $"price:{sortedCandys.CandysList[i].Price}, type:{sortedCandys.CandysList[i].Type}");
            }

            Console.WriteLine($"Its Chocolate candys:");
            for (int i = 0; i < sortedCandys.ChocolateList.Count; i++)
            {
               
                Console.WriteLine($"Name:{sortedCandys.ChocolateList[i].Name}, weight:{sortedCandys.ChocolateList[i].Weight}, " +
                                  $"price:{sortedCandys.ChocolateList[i].Price}, type:{sortedCandys.ChocolateList[i].Type}, " +
                                  $"chocolate type:{sortedCandys.ChocolateList[i].ChocolatType}");
            }

            Console.WriteLine($"Its Sugar candys:");
            for (int i = 0; i < sortedCandys.SugarList.Count; i++)
            {
                
                Console.WriteLine($"Name:{sortedCandys.SugarList[i].Name}, weight:{sortedCandys.SugarList[i].Weight}, " +
                                  $"price:{sortedCandys.SugarList[i].Price}, type:{sortedCandys.SugarList[i].Type}, " +
                                  $"chocolate type:{sortedCandys.SugarList[i].Stick}");
            }
        }
    }
}

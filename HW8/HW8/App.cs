using HW8.Entities;
using HW8.Models;
using HW8.Repositories;
using HW8.Repositories.Abstractions;
using HW8.Serivces.Abstractions;
using Microsoft.Extensions.DependencyInjection;



namespace HW8
{
    public class App
    {
        private readonly ISortCandy _sortCandy;
        private readonly IPresentService _present;

        public App(ISortCandy candyList, IPresentService present)
        {
            _sortCandy = candyList;
            _present = present;
        }

        public void Start()
        {
            _sortCandy.SortCandys();
            Console.WriteLine(_sortCandy);
        }
    }
}

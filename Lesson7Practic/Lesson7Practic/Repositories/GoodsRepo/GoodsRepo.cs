using Lesson7Practic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practic.Repositories.GoodsRepo
{
    internal class GoodsRepo : IGoodsRepo
    {
        public  Goods[] GoodsForSale(string[] array) 
        {
            Goods[] listOfGoods = new Goods[array.Length];
            int minPrice = 100;
            int maxPrice = 1000;
            int count = 0;
            foreach (var item in array)
            {
                Goods goods = new Goods();
                goods.name = item;
                goods.price = new Random().Next(minPrice, maxPrice);
                goods.quantity = new Random().Next(minPrice, maxPrice);
                listOfGoods[count] = goods;
                count++;
            }
            return listOfGoods;
        }
    }
}

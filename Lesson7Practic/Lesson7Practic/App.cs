using Lesson7Practic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practic
{
    public class Order
    {
        public int Price;
        public int Quantity;
        public string[] OrderedGoods;

        public Goods[] CheckOrder(Goods[] listOfGoods, Goods[] myCart)
        {
            int count = 0;
            Goods[] order = new Goods[myCart.Length];
            foreach (var item in listOfGoods)
            {
                foreach (var item2 in myCart)
                {
                    if (item.name == item2.name)
                    {
                        order[count] = item; 
                        count++;
                    }
                }
            }

            return order;
        }
        public Order FinishingOrder(Goods[] list) 
        {
            int price = 0, quantity = 0, count = 0;
            string[] orderedGoods = new string [list.Length];
            try
            {  
                foreach (var item in list)
                {
                    if (item != null)
                    {
                        price = price + item.price;
                        quantity = item.quantity;
                        orderedGoods[count] = item.name;
                        count++;
                    }
                }
            }
            catch 
            {
                Console.WriteLine("You order is empty");   
            }
            Price = price;
            Quantity = quantity;
            OrderedGoods = orderedGoods;
            return this;
        }
    }
}

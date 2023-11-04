using Lesson7Practic.Models;
using System.ComponentModel;
using System;
using Lesson7Practic.Repositories.UsersRepo;
using Lesson7Practic.Repositories.GoodsRepo;
using System.Runtime.CompilerServices;

namespace Lesson7Practic
{
    internal class Program
    {
        static void Main()
        {
            string listOFGoods = "banana, potato, crab, apple, car, lion, tiger, fly, motor oil, crocodile, papaya, coconat," +
                "snikers, baunti, mars, nuts, fish";

            ListOfGoods list = new ListOfGoods(listOFGoods);

            GoodsRepo forSale = new GoodsRepo();
            Goods[] productsForSale = forSale.GoodsForSale(list.menu);

            UserRepo userRepo = new UserRepo();

            string userName;
            string password;

            int count = 0;

            do
            {
                Console.Write("User name :");
                userName = Console.ReadLine();

                Console.Write("User password :");
                password = Console.ReadLine();

            } while (userName.Trim().Length == 0 || password.Trim().Length == 0);

            userRepo.AddUser(userName, password);

            Console.WriteLine("Add the goods from the list to you cart, separating them with a comma :");
            Console.WriteLine(listOFGoods);

            string myCart = Console.ReadLine();

            Console.WriteLine("If u are ready to finish your order type YES");

            string answer = Console.ReadLine();
            if(answer.Trim() == "YES")
            {
                ListOfGoods order = new ListOfGoods(myCart);
                GoodsRepo saleGoods = new GoodsRepo();
                Goods [] products = saleGoods.GoodsForSale(order.menu);

                Order myOrder = new Order();
                products = myOrder.CheckOrder(productsForSale, products);
                myOrder = myOrder.FinishingOrder(products);
                Console.WriteLine($"Order finished, list of ordered goods:{String.Join(",",myOrder.OrderedGoods)} " +
                    $"\n order price: {myOrder.Price}, order quantity:{myOrder.Quantity}.");
            }
            else
            {
                Main();
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practic.Models
{
    public class ListOfGoods
    {
        public string[] menu;
        public ListOfGoods(string listOfGoods) 
        {
            menu = listOfGoods.Trim().Split(',');
        }
    }
}

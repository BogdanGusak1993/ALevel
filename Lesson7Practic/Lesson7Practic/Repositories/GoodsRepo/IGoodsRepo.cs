using Lesson7Practic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practic.Repositories.GoodsRepo
{
    public interface IGoodsRepo
    {
        public Goods[] GoodsForSale(string[] array);
    }
}

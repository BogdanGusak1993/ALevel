using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel9Lesson9.Exeptions
{
    internal class ShowNotFoundExeption : Exception
    {
        public ShowNotFoundExeption(string message) : base(message){ }

        public ShowNotFoundExeption() { }
    
    }
}

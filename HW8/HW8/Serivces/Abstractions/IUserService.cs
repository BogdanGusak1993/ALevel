using HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Serivces.Abstractions
{
    internal interface IUserService
    {
        string AddUser(string firstName, string lastName);
        User GetUser(string id);
    }
}

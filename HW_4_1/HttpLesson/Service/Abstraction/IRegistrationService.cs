using HttpLesson.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpLesson.Service.Abstraction
{
    public interface IRegistrationService
    {
       Task<LoginData> Registration(string email, string password = null);
        Task<LoginData> LoginIn(string email, string password = null);
    }
}

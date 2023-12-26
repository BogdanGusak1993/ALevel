using ALevelSample.Dtos;
using ALevelSample.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpLesson.Service.Abstraction
{
    public interface IResourceService
    {
        Task<UserDto> GetResourcesList();
        Task<UserDto> GetResourceById(int id);
        
    }
}

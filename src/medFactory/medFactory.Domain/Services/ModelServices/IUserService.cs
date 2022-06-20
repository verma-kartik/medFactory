using medFactory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Services.ModelServices
{
    public interface IUserService : IDataService<User>
    {
        Task<User> GetByUsername(string username);
        Task<User> GetById(string id);
    }
}

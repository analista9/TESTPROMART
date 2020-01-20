using HilarioMarket.DTO;
using HilarioMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<UserDTO.Response> GetAll();
        Task<UserDTO.Response> GetById(UserDTO.Request request);
        //Operaciones Transaccionales
        Task<string> Insert(User User);
        Task<string> Update(User User);
        Task Delete(int UserID);
        Task Save();
    }
}

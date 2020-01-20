using HilarioMarket.Data;
using HilarioMarket.DTO;
using HilarioMarket.Models;
using HilarioMarket.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HilarioMarketServiceContext _context;
        public UserRepository(HilarioMarketServiceContext context)
        {
            _context = context;
        }
        public async Task Delete(int UserID)
        {
            User user = await _context.HilarioMarket_User.FindAsync(UserID);
            _context.HilarioMarket_User.Remove(user);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<string> Insert(User User)
        {
            try
            {
                await _context.HilarioMarket_User.AddAsync(User);
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<string> Update(User User)
        {
            try
            {
                _context.Entry(User).State = EntityState.Modified;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<UserDTO.Response> GetAll()
        {
            List<UserDTO.Response.User> users = await (from c in _context.HilarioMarket_User
                                                       select new UserDTO.Response.User
                                                        {
                                                            IdUser = c.IdUser,
                                                            Name = c.Name,
                                                            LastName = c.LastName,
                                                            UserName = c.UserName,
                                                            Password = c.Password
                                                        }).ToListAsync();
            if (users.Count != 0)
            {
                UserDTO.Response userResponse = new UserDTO.Response
                {
                    success = true,
                    Data = users
                };
                return userResponse;
            }
            else return new UserDTO.Response { success=false};
        }

        public async Task<UserDTO.Response> GetById(UserDTO.Request request)
        {
            UserDTO.Response response = new UserDTO.Response();
            response.Data = new List<UserDTO.Response.User>();
            UserDTO.Response.User user = await (from c in _context.HilarioMarket_User
                                                where c.UserName == request.UserName 
                                                && c.Password == request.Password
                                                select new UserDTO.Response.User
                                                {
                                                    IdUser = c.IdUser,
                                                    Name = c.Name,
                                                    LastName = c.LastName,
                                                    UserName = c.UserName,
                                                    Password = c.Password
                                                }).FirstOrDefaultAsync();
            if (user != null)
            {
                response.success = true; 
                response.Data.Add(user);
            }
            else response.success = false;

            return response;
        }
    }
}

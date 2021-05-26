using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5.Data
{
    public class UserServices
    {
        private SecretsDbContext dbContext;
        public UserServices(SecretsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //get
        public async Task<List<User>> GetUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        //add
        public async Task<User> AddUserAsync(User user)
        {
            try
            {
                dbContext.Users.Add(user);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }

        //update
        public async Task<User> UpdateUserAsync(User user)
        {
            try
            {
                var userExist = dbContext.Users.FirstOrDefault(p => p.UserId == user.UserId);
                if (userExist != null)
                {
                    dbContext.Users.Update(user);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5.Data
{
    public class SecretServices
    {
        private SecretsDbContext dbContext;
        public SecretServices(SecretsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //get
        public async Task<List<Secret>> GetSecretsAsync()
        {
            return await dbContext.Secrets.ToListAsync();
        }
    }
}

﻿using EWarehouse.Repository.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EWarehouse.Repository.Account
{
    public class RoleRepository : RepositoryBase<Role>
    {
        public RoleRepository(DbContext dbContext, ILogger logger) : base(dbContext, logger)
        {

        }
    }
}

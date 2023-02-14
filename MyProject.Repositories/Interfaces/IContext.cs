using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;

namespace MyProject.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Child> Children { get; set; }

     

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}

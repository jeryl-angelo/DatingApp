using DatingApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<User> Users { get; }
        IGenericRepository<Match> Matches { get; }

        IGenericRepository<Staff> Staffs { get; }

    }
}
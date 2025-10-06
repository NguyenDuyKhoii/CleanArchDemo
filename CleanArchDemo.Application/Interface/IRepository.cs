using CleanArchDemo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchDemo.Application.Interface
{
    public interface IRepository
    {
        Task<List<User>> GetAllUser();
    }
}

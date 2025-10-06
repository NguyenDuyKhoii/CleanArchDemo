using CleanArchDemo.Application.Interface;
using CleanArchDemo.Domain.Entity;
using CleanArchDemo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Infrastructure.Repositories
{
    public class UserRepository : IRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }
    }
}

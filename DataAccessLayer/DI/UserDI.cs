﻿using BusinessLayer.Model;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.DI
{
    public sealed class UserDI
    {
        private readonly WalletOneContext _context;

        public UserDI(WalletOneContext context)
        {
            _context = context;
        }
        public async Task Create(User user, CancellationToken cancellationToken)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Save(User user, CancellationToken cancellationToken)
        {
            if (_context.Entry(user).State == EntityState.Detached)
                _context.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Get(int id, CancellationToken cancellationToken)
        {
            return await _context.Users.SingleOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        public async Task<List<User>> GetUsers(int offset, int limit)
        {
            return await _context.Users.Skip(offset).Take(limit).ToListAsync();
        }
    }
}

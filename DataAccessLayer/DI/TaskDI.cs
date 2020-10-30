using BusinessLayer.Model;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.DI
{
    public sealed class TaskDI
    {
        private readonly WalletOneContext _context;
        public TaskDI(WalletOneContext context)
        {
            _context = context;
        }

        public async Task<TaskUser> Get(int id, CancellationToken cancellationToken)
        {
            return await _context.TaskUsers.SingleOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        public async Task<List<TaskUser>> GetByDirector(int id, CancellationToken cancellationToken, int offset, int limit)
        {
            return await _context.TaskUsers.Skip(offset).Take(limit).Where(o => o.DirectorId == id).ToListAsync(cancellationToken);
        }

        public async Task<List<TaskUser>> GetByPerformer(int id, CancellationToken cancellationToken, int offset, int limit)
        {
            return await _context.TaskUsers.Skip(offset).Take(limit).Where(o => o.PerformerId == id).ToListAsync(cancellationToken);
        }

        public async Task Create(TaskUser task, CancellationToken cancellationToken)
        {
            await _context.TaskUsers.AddAsync(task);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Save(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

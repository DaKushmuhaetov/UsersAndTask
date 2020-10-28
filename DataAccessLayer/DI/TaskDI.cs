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

        public async Task<List<TaskUser>> GetByDirector(int id, CancellationToken cancellationToken)
        {
            return await _context.TaskUsers.Where(o => o.DirectorId == id).ToListAsync(cancellationToken);
        }

        public async Task<List<TaskUser>> GetByPerformer(int id, CancellationToken cancellationToken)
        {
            return await _context.TaskUsers.Where(o => o.PerformerId == id).ToListAsync(cancellationToken);
        }

        public async Task Create(TaskUser task, CancellationToken cancellationToken)
        {
            await _context.TaskUsers.AddAsync(task);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Save(TaskUser task, CancellationToken cancellationToken)
        {
            TaskUser editTask = await _context.TaskUsers.Where(o => o.Id == task.Id).SingleOrDefaultAsync();
            _context.TaskUsers.Remove(editTask);
            await _context.AddAsync(task);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SetStatus(int id, BusinessLayer.Model.TaskStatus status, CancellationToken cancellationToken)
        {
            TaskUser editTask = await _context.TaskUsers.Where(o => o.Id == id).SingleOrDefaultAsync();
            _context.Remove(editTask);
            await _context.SaveChangesAsync();
            editTask.SetStatus(status);
            await _context.TaskUsers.AddAsync(editTask);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SetDirector(int id, int directorId, CancellationToken cancellationToken)
        {
            TaskUser editTask = await _context.TaskUsers.Where(o => o.Id == id).SingleOrDefaultAsync();
            _context.Remove(editTask);
            await _context.SaveChangesAsync();
            editTask.SetDirector(directorId);
            await _context.TaskUsers.AddAsync(editTask);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

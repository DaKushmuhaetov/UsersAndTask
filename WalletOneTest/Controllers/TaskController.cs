using BusinessLayer.Model;
using DataAccessLayer.DI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WalletOneTest.Binding;
using WalletOneTest.ViewModels;

namespace WalletOneTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskDI _taskDI;

        public TaskController(TaskDI taskDI)
        {
            _taskDI = taskDI;
        }
        /// <summary>
        /// Get task by Id
        /// </summary>
        /// <param name="id">Id task</param>
        /// <param name="cancellationToken"></param>
        /// <response code ="200">Successfully</response>
        /// <response code ="400">Id is empty</response>
        /// <response code ="404">Task not found</response>
        [HttpGet("task")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<TaskView>> GetUser([FromQuery]int id
            , CancellationToken cancellationToken)
        {
            if (id == 0)
            {
                return BadRequest(id);
            }
            var task = await _taskDI.Get(id, cancellationToken);

            if (task == null)
            {
                return NotFound(task);
            }

            return new TaskView
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                DirectorId = task.DirectorId,
                PerformerId = task.PerformerId,
                Status = task.Status,
                DateCreate = task.DateCreate,
                DateLastEdit = task.DateLastEdit
            };
        }

        /// <summary>
        /// Get task by PerformerID
        /// </summary>
        /// <param name="page"></param>
        /// <param name="cancellationToken"></param>
        /// <response code ="200">Successfully</response>
        /// <response code ="404">Task not found</response>
        [HttpGet("tasksByPerformerId")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<Page<TaskView>>> GetByPefrormerId([FromQuery]PageBinding page, [FromQuery]int id
            , CancellationToken cancellationToken)
        {
            var tasks = await _taskDI.GetByPerformer(id, cancellationToken);

            var query = tasks.Select(o => new TaskView
            {
                Id = o.Id,
                Name = o.Name,
                Description = o.Description,
                DateCreate = o.DateCreate,
                DateLastEdit = o.DateLastEdit,
                DirectorId = o.DirectorId,
                PerformerId = o.PerformerId
            });

            var items = query
                .Skip(page.Offset)
                .Take(page.Limit)
                .ToList();

            if (items.Count == 0)
            {
                return NotFound(items);
            }

            return new Page<TaskView>
            {
                Limit = page.Limit,
                Offset = page.Offset,
                Total = query.Count(),
                Items = items
            };
        }

        /// <summary>
        /// Get task by PerformerID
        /// </summary>
        /// <param name="page"></param>
        /// <param name="cancellationToken"></param>
        /// <response code ="200">Successfully</response>
        /// <response code ="404">Task not found</response>
        [HttpGet("tasksByDirectorId")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<Page<TaskView>>> GetTaskBiDirectorId([FromQuery]PageBinding page, [FromQuery]int id
            , CancellationToken cancellationToken)
        {
            var tasks = await _taskDI.GetByDirector(id, cancellationToken);

            var query = tasks.Select(o => new TaskView
            {
                Id = o.Id,
                Name = o.Name,
                Description = o.Description,
                DateCreate = o.DateCreate,
                DateLastEdit = o.DateLastEdit,
                DirectorId = o.DirectorId,
                PerformerId = o.PerformerId
            });

            var items = query
                .Skip(page.Offset)
                .Take(page.Limit)
                .ToList();

            if (items.Count == 0)
            {
                return NotFound(items);
            }

            return new Page<TaskView>
            {
                Limit = page.Limit,
                Offset = page.Offset,
                Total = query.Count(),
                Items = items
            };
        }

        /// <summary>
        /// Edit task
        /// </summary>
        /// <param name="id">Id task</param>
        /// <response code ="200">Successfully</response>
        /// <param name="cancellationToken"></param>
        /// <response code ="404">Task not found</response>
        [HttpPost("save")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<TaskView>> EditTask([FromQuery] int id, [FromBody]SaveTaskBinding taskBinding
            , CancellationToken cancellationToken)
        {
            var editTask = await _taskDI.Get(id, cancellationToken);

            if (editTask == null)
            {
                return NotFound(editTask);
            }

            TaskUser task = new TaskUser(id, taskBinding.Name, taskBinding.Description, editTask.DateCreate, DateTime.Now, editTask.Status, editTask.DirectorId, taskBinding.PerformerId);
            await _taskDI.Save(task, cancellationToken);

            return new TaskView
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                DateCreate = task.DateCreate,
                DateLastEdit = task.DateLastEdit,
                DirectorId = task.DirectorId,
                PerformerId = task.PerformerId,
                Status = task.Status
            };
        }

        /// <summary>
        /// Edit status
        /// </summary>
        /// <param name="id">Id task</param>
        /// <response code ="200">Successfully</response>
        /// <param name="cancellationToken"></param>
        /// <response code ="404">Task not found</response>
        [HttpPost("status")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<TaskView>> EditTaskStatus([FromQuery] int id, [FromBody]BusinessLayer.Model.TaskStatus status
            , CancellationToken cancellationToken)
        {
            var editTask = await _taskDI.Get(id, cancellationToken);

            if (editTask == null)
            {
                return NotFound(editTask);
            }

            await _taskDI.SetStatus(id, status, cancellationToken);

            var task = await _taskDI.Get(id, cancellationToken);

            return new TaskView
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                DateCreate = task.DateCreate,
                DateLastEdit = task.DateLastEdit,
                DirectorId = task.DirectorId,
                PerformerId = task.PerformerId,
                Status = task.Status
            };
        }

        /// <summary>
        /// Edit director
        /// </summary>
        /// <param name="id">Id task</param>
        /// <response code ="200">Successfully</response>
        /// <param name="cancellationToken"></param>
        /// <response code ="404">Task not found</response>
        [HttpPost("director")]
        [ProducesResponseType(typeof(TaskView), 200)]
        public async Task<ActionResult<TaskView>> EditTaskDirector([FromQuery] int id, [FromBody]int idDirector
            , CancellationToken cancellationToken)
        {
            var editTask = await _taskDI.Get(id, cancellationToken);

            if (editTask == null)
            {
                return NotFound(editTask);
            }

            await _taskDI.SetDirector(id, idDirector, cancellationToken);

            var task = await _taskDI.Get(id, cancellationToken);

            return new TaskView
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                DateCreate = task.DateCreate,
                DateLastEdit = task.DateLastEdit,
                DirectorId = task.DirectorId,
                PerformerId = task.PerformerId,
                Status = task.Status
            };
        }
    }
}
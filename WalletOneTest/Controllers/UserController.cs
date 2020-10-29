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
    public class UserController : ControllerBase
    {
        private readonly UserDI _userDI;
        private readonly TaskDI _taskDI;

        public UserController(UserDI userDI, TaskDI taskDI)
        {
            _userDI = userDI;
            _taskDI = taskDI;
        }
        /// <summary>
        /// Get user by Id
        /// </summary>
        /// <param name="id">Id user</param>
        /// <param name="cancellationToken"></param>
        /// <response code ="200">Successfully</response>
        /// <response code ="400">Id is empty</response>
        /// <response code ="404">User not found</response>
        [HttpGet("user")]
        [ProducesResponseType(typeof(UserViewModel), 200)]
        public async Task<ActionResult<UserViewModel>> GetUser([FromQuery]int id
            , CancellationToken cancellationToken)
        {
            if (id == 0)
            {
                return BadRequest(id);
            }
            var user = await _userDI.Get(id, cancellationToken);

            if (user == null)
            {
                return NotFound(user);
            }

            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                DateCreate = user.DateCreate,
                DateLastEdit = user.DateLastEdit,
                Status = user.Status
            };
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="page"></param>
        /// <param name="cancellationToken"></param>
        /// <response code ="200">Successfully</response>
        /// <response code ="404">Users not found</response>
        [HttpGet("users")]
        [ProducesResponseType(typeof(UserViewModel), 200)]
        public async Task<ActionResult<Page<UserViewModel>>> GetUsers([FromQuery]PageBinding page
            , CancellationToken cancellationToken)
        {
            var users = await _userDI.GetUsers(page.Offset, page.Limit);

            var query = users.Select(o => new UserViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                MiddleName = o.MiddleName,
                DateCreate = o.DateCreate,
                DateLastEdit = o.DateLastEdit,
                Status = o.Status
            });

            var items = query.ToList();

            if (items.Count == 0)
            {
                return NotFound(items);
            }

            return new Page<UserViewModel>
            {
                Total = items.Count(),
                Items = items
            };
        }

        /// <summary>
        /// Edit user
        /// </summary>
        /// <param name="id">Id user</param>
        /// <response code ="200">Successfully</response>
        /// <param name="cancellationToken"></param>
        /// <response code ="404">User not found</response>
        [HttpPost("save")]
        [ProducesResponseType(typeof(UserViewModel), 200)]
        public async Task<ActionResult<UserViewModel>> EditUser([FromQuery] int id, [FromBody]SaveUserBinding userBinding
            , CancellationToken cancellationToken)
        {
            var editUser = await _userDI.Get(id, cancellationToken);

            if (editUser == null)
            {
                return NotFound(editUser);
            }

            editUser.EditUser(userBinding.FirstName, userBinding.MiddleName);
            await _userDI.Save(editUser, cancellationToken);

            return new UserViewModel
            {
                Id = editUser.Id,
                FirstName = editUser.FirstName,
                MiddleName = editUser.MiddleName,
                DateCreate = editUser.DateCreate,
                DateLastEdit = editUser.DateLastEdit,
                Status = editUser.Status
            };
        }

        /// <summary>
        /// Set task
        /// </summary>
        /// <param name="id">Id director</param>
        /// <response code ="200">Successfully</response>
        /// <param name="cancellationToken"></param>
        /// <response code ="404">User not found</response>
        /// <response code ="409">this number task is busy</response>
        [HttpPost("task")]
        [ProducesResponseType(typeof(UserViewModel), 200)]
        public async Task<ActionResult<TaskView>> SetTask([FromQuery] int id, [FromBody]CreateTaskBinding taskBinding
            , CancellationToken cancellationToken)
        {
            var user = await _userDI.Get(id, cancellationToken);
            var task = await _taskDI.Get(taskBinding.Id, cancellationToken);

            if (user == null)
            {
                return NotFound(user);
            }

            if (task != null)
            {
                return Conflict(task);
            }
            TaskUser newTask = new TaskUser(taskBinding.Id, taskBinding.Name, taskBinding.Description, DateTime.Now, DateTime.Now, taskBinding.Status, id, taskBinding.PerformerId);

            await _taskDI.Create(newTask, cancellationToken);

            return new TaskView
            {
                Id = newTask.Id,
                Name = newTask.Name,
                Description = newTask.Description,
                DateCreate = newTask.DateCreate,
                DateLastEdit = newTask.DateLastEdit,
                DirectorId = newTask.DirectorId,
                PerformerId = newTask.PerformerId,
                Status = newTask.Status
            };
        }
    }
}
using DevAttic.Hive.AspNetCore.Services;
using DevAttic.Hive.Core;
using Microsoft.AspNetCore.Mvc;
using ModuleDefinitions;
using ModuleDefinitions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hive_Web_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IEnumerable<IFormNotifier> _formNotifiers;

        public UsersController(IModuleServices<IFormNotifier> notifiers)
        {
            _formNotifiers = notifiers.Instances;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserFormData userInfo)
        {
            // Let us assume we have a logic that saves our user.
            foreach (var notifier in _formNotifiers)
            {
                await notifier.NotifyFormSubmitAsync($"User with name {userInfo.Name} has been created.");
            }

            return Ok();
        }
    }
}
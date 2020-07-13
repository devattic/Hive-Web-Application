using ModuleDefinitions.Services;

namespace Hive_Web_Application
{
    public class UserService : IUserService
    {
        public string[] GetUsers()
        {
            return new string[] { "Jane Doe", "John Doe" };
        }
    }
}
